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
         *
         *  BONUS:
         *      - Report Download/Upload Progress %
         *      
         * */

        private string Host { get => ngTextBoxHost.Text; }
        private string Username { get => ngTextBoxUsername.Text; }
        private string Password { get => ngTextBoxPassword.Text; }
        private int Port { get => int.Parse(ngTextBoxPort.Text); }

        private string HomeDirectory { get => $"/home/{Username}"; }

        public SftpClient Client { get; set; }

        public string CurrentDirectory
        {
            get => ngTextBoxCurrentDirectory.Text;
            set => ngTextBoxCurrentDirectory.Text = value;
        }

        public string LocalDirectory
        {
            get => ngTextBoxLocalDirectory.Text;
            set => ngTextBoxLocalDirectory.Text = value;
        }

        public SFTPBrowserWindow()
        {
            InitializeComponent();

            AllowDrop = true;
       
            ngListViewFiles.AllowDrop = true;
            ngListViewFiles.IsSimpleDragSource = true;
            ngListViewFiles.IsSimpleDropSink = true;
            ngListViewProgress.UseNotifyPropertyChanged = true;

            ngListViewProgress.ModelCanDrop += NgListViewProgress_ModelCanDrop;
            ngListViewFiles.DoubleClick += NgListViewFiles_DoubleClick;

            ngListViewProgress.DoubleClick += NgListViewProgress_DoubleClick;

            ngButtonConnect.Click += NgButtonConnect_Click;
            ngButtonBrowse.Click += NgButtonBrowse_Click;

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

        #region Misc Methods

        private bool CheckControls()
        {
            // TODO Check each of the controls
            return true;
        }

        private void ApplyLanguage()
        {
            // TODO
        }

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
            FileRow fileRow = (FileRow)e.TargetModel;
            if (fileRow == null)
            {
                e.Effect = DragDropEffects.None;
            }
            else
            {
                if (fileRow.File.IsDirectory)
                {
                    e.Effect = DragDropEffects.None;
                    e.InfoMessage = "Can't download a directory";
                }
                else
                {
                    e.Effect = DragDropEffects.Move;
                }
            }
        }

        private void NgButtonBrowse_Click(object sender, EventArgs e)
        {
            using (var browser = new FolderBrowserDialog())
            {
                DialogResult result = browser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browser.SelectedPath))
                {
                    LocalDirectory = browser.SelectedPath;
                }
            }
        }


        private void NgListViewFiles_DoubleClick(object sender, EventArgs e)
        {
            ObjectListView objectList = (ObjectListView)sender;

            FileRow oRow = (FileRow)objectList.SelectedItem.RowObject;

            if (!oRow.File.OthersCanRead)
            {
                MessageBox.Show("You have insufficient permissions",
                      "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (oRow.File.IsDirectory)
                    ChangeDirectory(oRow.File.FullName);
                else
                    DownloadFile(oRow.File);
            }

        }

        private void NgButtonConnect_Click(object sender, EventArgs e)
        {
            if (!CheckControls()) return;

            if (!Connect()) return;

            ChangeDirectory(HomeDirectory);
        }

        #endregion

        #region SFTP Methods
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
            return new ConnectionInfo(Host, Port, Username, new AuthenticationMethod[]{
                new PasswordAuthenticationMethod(Username,Password)
            });
        }

        public async void DownloadFile(SftpFile file)
        {
            string dest = $"{LocalDirectory}\\{file.Name}";
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

        public async void ChangeDirectory(string path)
        {
            IAsyncResult result = Client.BeginListDirectory(path, AsyncListDirectoryCallback, null);

            var files = await Task.Factory.FromAsync(result, Client.EndListDirectory);

            PopulateListView((List<SftpFile>)files);
        }

        private void PopulateListView(List<SftpFile> results)
        {
            List<FileRow> rows = new List<FileRow>();

            foreach (var file in results)
            {
                FileRow fileRow = new FileRow(file);
                rows.Add(fileRow);

                if (file.Name == ".")
                {
                    CurrentDirectory = file.FullName.Substring(0, file.FullName.LastIndexOf("/."));
                }

                if (string.IsNullOrEmpty(CurrentDirectory))
                {
                    CurrentDirectory = "/";
                }
            }

            ngListViewFiles.SetObjects(rows.OrderBy(r => r.Name));
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
                this.Name = Path.Substring(Path.LastIndexOf('\\') + 1);
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
            public int Size { get; set; }
            public string Modified { get; set; }

            public SftpFile File { get; set; }

            public Image Icon { get; set; }

            public FileRow(SftpFile File)
            {

                this.File = File;

                this.Name = File.Name;
                this.Size = (int)Math.Round(File.Attributes.Size / 1024f);
                this.Modified = File.Attributes.LastWriteTime.ToString("yyyy-MM-dd hh:mm");

                this.Icon = (File.IsDirectory) ? Resources.Folder : Resources.File;
            }

         
        }
    }
}
