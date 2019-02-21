using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using System.Text.RegularExpressions;

namespace mRemoteNG.UI.Window
{
    public partial class SFTPBrowserWindow : BaseWindow
    {
        /*
         *  TODO:
         *      - File Upload
         *      - Drag & Drop (Upload/Download)
         *      - Port Logic into it's own class
         *      - Use Credential manager
         *      - Add support for KeyAuth
         *      - Conext Menu's
         *      - Overwrite dialog (kinda done)
         *      - Sanity checks
         *
         *  BONUS:
         *      - Report Download/Upload Progress %
         *      
         * */

        public string Hostname { get => ngTextBoxHost.Text; set => ngTextBoxHost.Text = value; }
        public string Username { get => ngTextBoxUsername.Text; set => ngTextBoxUsername.Text = value;  }
        public string Password { get => ngTextBoxPassword.Text; set => ngTextBoxPassword.Text = value; }
        public int Port { get => int.Parse(ngTextBoxPort.Text); set => ngTextBoxPort.Text = value.ToString(); }

        private string HomeDirectory { get => (Username == "root") ? "/root" : $"/home/{Username}"; }

        private FileSystemWatcher Watcher { get; set; }

        public SftpClient Client { get; set; }

        public string CurrentDirectoryRemote
        {
            get => ngTextBoxCurrentDirectoryRemote.Text;
            set => ngTextBoxCurrentDirectoryRemote.Text = value;
        }

        public string CurrentDirectoryLocal
        {
            get => ngTextBoxCurrentDirectoryLocal.Text;
            set => ngTextBoxCurrentDirectoryLocal.Text = value;
        }

        public SFTPBrowserWindow()
        {
            InitializeComponent();

            AllowDrop = true;
       
            ngListViewFilesRemote.AllowDrop = true;
            ngListViewFilesRemote.IsSimpleDragSource = true;
            ngListViewFilesRemote.IsSimpleDropSink = true;
            ngListViewFilesRemote.DoubleClick += NgListViewFilesRemote_DoubleClick;
            ngListViewFilesRemote.DragOver += NgListViewFilesRemote_DragOver;
            ngListViewFilesRemote.DragDrop += NgListViewFilesRemote_DragDrop;
            ngListViewFilesRemote.DragEnter += NgListViewFilesRemote_DragEnter;
            ngListViewFilesRemote.CanDrop += NgListViewFilesRemote_CanDrop;
            ngListViewFilesRemote.Dropped += NgListViewFilesRemote_Dropped;

            ngListViewFilesLocal.AllowDrop = true;
            ngListViewFilesLocal.IsSimpleDragSource = true;
            ngListViewFilesLocal.IsSimpleDropSink = true;
            ngListViewFilesLocal.DoubleClick += NgListViewFilesLocal_DoubleClick;


            ngListViewProgress.UseNotifyPropertyChanged = true;
            ngListViewProgress.ModelCanDrop += NgListViewProgress_ModelCanDrop;
            ngListViewProgress.DoubleClick += NgListViewProgress_DoubleClick;


            ngButtonConnect.Click += NgButtonConnect_Click;
            ngButtonBrowse.Click += NgButtonBrowse_Click;

            toolStripButtonCollapse.Click += ToolStripButtonCollapse_Click;

            Watcher = new FileSystemWatcher();

            Watcher.NotifyFilter = NotifyFilters.LastAccess
                              | NotifyFilters.LastWrite
                              | NotifyFilters.FileName
                              | NotifyFilters.DirectoryName;

            Watcher.Changed += Watcher_Changed;
            Watcher.Created += Watcher_Changed;
            Watcher.Deleted += Watcher_Changed;
            Watcher.Renamed += Watcher_Renamed;
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            ChangeDirectoryLocal(CurrentDirectoryLocal);
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            ChangeDirectoryLocal(CurrentDirectoryLocal);
        }

        #region Methods

        private bool CheckControls()
        {
            return (ngTextBoxHost.Text != string.Empty &&
            ngTextBoxUsername.Text != string.Empty &&
            ngTextBoxPassword.Text != string.Empty &&
            Regex.IsMatch(ngTextBoxPort.Text, @"^(\d?)+$"));
        }

        private void ApplyLanguage()
        {
            // TODO
        }

        public void ChangeDirectoryLocal(string path)
        {
            var dirInfo = new DirectoryInfo(path);

            try
            {
                Watcher.EnableRaisingEvents = false;

                var dirs = dirInfo.EnumerateDirectories().AsParallel().Where(d => (d.Attributes & FileAttributes.Hidden) == 0 && (d.Attributes & FileAttributes.System) == 0).ToList();
                var files = dirInfo.EnumerateFiles().AsParallel().Where(f => (f.Attributes & FileAttributes.Hidden) == 0 && (f.Attributes & FileAttributes.System) == 0).ToList();

                CurrentDirectoryLocal = path;

                Watcher.Path = CurrentDirectoryLocal;

                PopulateListViewLocal(dirInfo, dirs, files);

                Watcher.EnableRaisingEvents = true;

            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(e.Message,
                      "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred - {e.Message}",
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void PopulateListViewLocal(DirectoryInfo currentDirectory, List<DirectoryInfo> directories, List<FileInfo> files)
        {
            List<FileRow> rows = new List<FileRow>();

            FileRow currentDir = new FileRow(currentDirectory, true, ".");
            FileRow parentDir = new FileRow(currentDirectory.Parent, true, "..");

            rows.Add(currentDir);
            rows.Add(parentDir);

            foreach (var dir in directories)
            {
                FileRow fileRow = new FileRow(dir);
                rows.Add(fileRow);
            }

            foreach (var file in files)
            {
                FileRow fileRow = new FileRow(file);
                rows.Add(fileRow);
            }

            ngListViewFilesLocal.SetObjects(rows.OrderBy(r => r.Size).ToList());
        }



        private void ToggleConnectionInfo()
        {
            splitContainerMain.Panel1Collapsed = !splitContainerMain.Panel1Collapsed;
        }

        public void ConnectAndBrowse(bool collapse = false)
        {
            if (!CheckControls()) return;

            if (!Connect()) return;

            if (!splitContainerMain.Panel1Collapsed) ToggleConnectionInfo();

            ChangeDirectoryLocal(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            ChangeDirectoryRemote(HomeDirectory);


        }

        public bool Connect()
        {
            Client = new SftpClient(GetConnectionInfo());

            try
            {
                Client.Connect();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect: " + ex.Message,
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public ConnectionInfo GetConnectionInfo()
        {
            return new ConnectionInfo(Hostname, Port, Username, new AuthenticationMethod[]{
                new PasswordAuthenticationMethod(Username,Password)
            });
        }

        public async void UploadFile(FileInfo file)
        {
            string dest = $"{CurrentDirectoryRemote}/{file.Name}";
            ProgressRow progressRow = null;

            using (FileStream SourceStream = File.Open(file.FullName, FileMode.Open, FileAccess.Read))
            {
                progressRow = new ProgressRow(dest, ProgressRow.StatusType.Waiting, false);

                ngListViewProgress.AddObject(progressRow);

                IAsyncResult result = Client.BeginUploadFile(SourceStream, dest);

                progressRow.Status = ProgressRow.StatusType.Uploading;

                await Task.Factory.FromAsync(result, Client.EndUploadFile);

                progressRow.Status = ProgressRow.StatusType.Complete;

                ChangeDirectoryRemote(CurrentDirectoryRemote);
            }

        }


        public async void DownloadFile(SftpFile file)
        {
            string dest = $"{CurrentDirectoryLocal}\\{file.Name}";
            ProgressRow progressRow = null;

            try
            {
                if (File.Exists(dest))
                {
                    DialogResult result = MessageBox.Show("The file you are downloading already exists. Do you wish to overwrite?",
                        "File Exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    // TODO Rename the file { File.ext => File (1).ext }

                    if (result != DialogResult.Yes) return;
                }

                using (FileStream SourceStream = File.Open(dest, FileMode.Create, FileAccess.Write))
                {
                    progressRow = new ProgressRow(dest, ProgressRow.StatusType.Waiting);

                    ngListViewProgress.AddObject(progressRow);

                    IAsyncResult result = Client.BeginDownloadFile(file.FullName, SourceStream, AsyncDownloadCallback, progressRow);

                    progressRow.Status = ProgressRow.StatusType.Downloading;

                    await Task.Factory.FromAsync(result, Client.EndDownloadFile);

                    progressRow.Status = ProgressRow.StatusType.Complete;

                }
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (progressRow != null)
                {
                    progressRow.Status = ProgressRow.StatusType.Failed;
                }
            }

        }

        public async void ChangeDirectoryRemote(string path)
        {
            try
            {
                IAsyncResult result = Client.BeginListDirectory(path, AsyncListDirectoryCallback, null);
                IEnumerable<SftpFile>  files = await Task.Factory.FromAsync(result, Client.EndListDirectory);
                PopulateListViewRemote((List<SftpFile>)files);
            }
            catch (Renci.SshNet.Common.SftpPathNotFoundException e)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private void PopulateListViewRemote(List<SftpFile> results)
        {
            List<FileRow> rows = new List<FileRow>();

            foreach (var file in results)
            {
                FileRow fileRow = new FileRow(file);
                rows.Add(fileRow);

                if (file.Name == ".")
                {
                    CurrentDirectoryRemote = file.FullName.Substring(0, file.FullName.LastIndexOf("/."));
                }

                if (string.IsNullOrEmpty(CurrentDirectoryRemote))
                {
                    CurrentDirectoryRemote = "/";
                }
            }

            ngListViewFilesRemote.SetObjects(rows.OrderBy(r => r.Name));
        }

        #region Async Callbacks
        private void AsyncListDirectoryCallback(IAsyncResult state)
        {
            // TODO
        }

        private void AsyncDownloadCallback(IAsyncResult asyncResult)
        {
            var result = (SftpDownloadAsyncResult)asyncResult;

            Debug.WriteLine(result.DownloadedBytes);
        }


        #endregion

        #endregion

        #region Form Events

        private void SFTPBrowserWindow_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            ApplyLanguage();
            var display = new DisplayProperties();
        }

        private void NgListViewProgress_ModelCanDrop(object sender, ModelDropEventArgs e)
        {
            //FileRow fileRow = (FileRow)e.TargetModel;
            //if (fileRow == null)
            //{
            //    e.Effect = DragDropEffects.None;
            //}
            //else
            //{
            //    if (fileRow.File.IsDirectory)
            //    {
            //        e.Effect = DragDropEffects.None;
            //        e.InfoMessage = "Can't download a directory";
            //    }
            //    else
            //    {
            //        e.Effect = DragDropEffects.Move;
            //    }
            //}
        }

        private void NgButtonBrowse_Click(object sender, EventArgs e)
        {
            using (var browser = new FolderBrowserDialog())
            {
                DialogResult result = browser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browser.SelectedPath))
                {
                    CurrentDirectoryLocal = browser.SelectedPath;
                }
            }
        }

        private void NgListViewFilesRemote_DoubleClick(object sender, EventArgs e)
        {
            ObjectListView objectList = (ObjectListView)sender;

            FileRow oRow = (FileRow)objectList.SelectedItem.RowObject;
            SftpFile file = (SftpFile)oRow.File;

            if (!file.OthersCanRead)
            {
                MessageBox.Show("You have insufficient permissions",
                      "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (file.IsDirectory)
                    ChangeDirectoryRemote(file.FullName);
                else
                    DownloadFile(file);
            }

        }

        private void NgListViewFilesRemote_Dropped(object sender, OlvDropEventArgs e)
        {
            Debug.WriteLine(e.DataObject);
        }

        private void NgListViewFilesRemote_CanDrop(object sender, OlvDropEventArgs e)
        {
            Debug.WriteLine(e.DataObject);
        }

        private void NgListViewFilesRemote_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void NgListViewFilesRemote_DragDrop(object sender, DragEventArgs e)
        {
            ObjectListView objectList = (ObjectListView)sender;
            FileRow oRow = (FileRow)objectList.SelectedItem.RowObject;
            SftpFile ofile = (SftpFile)oRow.File;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var f in files)
                {

                    if (ofile.IsDirectory)
                    {
                        Debug.WriteLine($"Write {f} => {ofile.FullName}");
                    }
                    else
                    {
                        Debug.WriteLine($"Write {f} => {CurrentDirectoryRemote}");
                    }

                    //UploadFile(file, CurrentDirectoryRemote);
                }
            }
        }

        private void NgListViewFilesRemote_DragOver(object sender, DragEventArgs e)
        {

        }

        private void NgButtonConnect_Click(object sender, EventArgs e)
        {
            ConnectAndBrowse();
        }

        private void NgListViewFilesLocal_DoubleClick(object sender, EventArgs e)
        {
            ObjectListView objectList = (ObjectListView)sender;

            FileRow oRow = (FileRow)objectList.SelectedItem.RowObject;

            if (oRow.File is null) return;

            if (oRow.File.GetType() == typeof(DirectoryInfo))
            {
                DirectoryInfo directory = (DirectoryInfo)oRow.File;
                ChangeDirectoryLocal(directory.FullName);
            }
            else if (oRow.File.GetType() == typeof(FileInfo))
            {
                FileInfo file = (FileInfo)oRow.File;
                UploadFile(file);
            }
        }


        private void ToolStripButtonCollapse_Click(object sender, EventArgs e)
        {
            ToggleConnectionInfo();
        }

        private void NgListViewProgress_DoubleClick(object sender, EventArgs e)
        {
            ObjectListView objectList = (ObjectListView)sender;

            ProgressRow oRow = (ProgressRow)objectList.SelectedItem.RowObject;

            if (!File.Exists(oRow.Path)) return;

            try
            {
                Process.Start(oRow.Path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open file. " + ex.Message,
                      "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        public class ProgressRow : INotifyPropertyChanged
        {
            public enum StatusType
            {
                Waiting,Downloading,Uploading,Canceled,Complete,Failed
            }

            private StatusType _Status { get; set; }

            public string Name { get; set; }
            public string Path { get; set; }
            public StatusType Status
            {
                get => this._Status;
                set
                {
                    if (value != this._Status)
                    {
                        this._Status = value;
                        NotifyPropertyChanged();
                    }
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            public Image Icon { get; set; }
          
            public ProgressRow(string Path, StatusType Status, bool IsDownload = true)
            {
                this.Path = Path;
                this.Name = (IsDownload) ? Path.Substring(Path.LastIndexOf('\\') + 1) : Path.Substring(Path.LastIndexOf('/') + 1);
                this._Status = Status;
                this.Icon = (IsDownload) ? Resources.Arrow_Down : Resources.Arrow_Up;
            }

            private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
            { 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public class FileRow
        {  
            public string Name { get; set; }
            public int? Size { get; set; }
            public string Modified { get; set; }

            public object File { get; set; }

            public Image Icon { get; set; }

            public FileRow(SftpFile File)
            {
                this.File = File;

                this.Name = File.Name;
                this.Size = (int)Math.Round(File.Attributes.Size / 1024f);
                this.Modified = File.Attributes.LastWriteTime.ToString("yyyy-MM-dd hh:mm");

                this.Icon = (File.IsDirectory) ? Resources.Folder : Resources.File;
            }

            public FileRow(FileInfo File)
            {
                this.File = File;

                this.Name = File.Name;
                this.Size = (int)Math.Round(File.Length / 1024f);
                this.Modified = File.LastWriteTime.ToString("yyyy-MM-dd hh:mm");

                this.Icon = Resources.File;
            }

            public FileRow(DirectoryInfo Directory, bool IsSpecial = false, string SpecialName = "")
            {
                this.File = Directory;
                
                this.Name = (IsSpecial) ? SpecialName : Directory.Name;
                this.Size = null;
                this.Modified = (IsSpecial) ? string.Empty : Directory.LastWriteTime.ToString("yyyy-MM-dd hh:mm");

                this.Icon = Resources.Folder;
            }
          
        }
    }
}
