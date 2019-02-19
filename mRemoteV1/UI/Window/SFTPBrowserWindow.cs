using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private string Host { get => ngTextBoxHost.Text; }
        private string Username { get => ngTextBoxUsername.Text; }
        private string Password { get => ngTextBoxPassword.Text; }
        private int Port { get => int.Parse(ngTextBoxPort.Text); }

        private string HomeDirectory { get => $"/home/{Username}"; }

        public SftpClient Client;

        private List<Task> Tasks { get; set; }

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

            ngButtonConnect.Click += NgButtonConnect_Click;
            ngButtonBrowse.Click += NgButtonBrowse_Click;

            ngListViewFiles.DoubleClick += NgListViewFiles_DoubleClick;
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

            Connect();

            ChangeDirectory(HomeDirectory);
        }

        #endregion

        #region SFTP Methods
        public void Connect()
        {
            Client = new SftpClient(GetConnectionInfo());

            try
            {
                Client.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect: " + ex.Message,
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (Tasks is null) Tasks = new List<Task>();

            try
            {
                var dest = $"{LocalDirectory}\\{file.Name}";

                using (FileStream SourceStream = File.Open(dest, FileMode.CreateNew, FileAccess.Write))
                {
                    ProgressRow progressRow = new ProgressRow(file.Name, "Waiting");
                    ngListViewProgress.AddObject(progressRow);



                    IAsyncResult result = Client.BeginDownloadFile(file.FullName, SourceStream, AsyncDownloadCallback, progressRow);

                    progressRow.Status = "Downloading";

                    await Task.Factory.FromAsync(result, Client.EndDownloadFile);

                    progressRow.Status = "Complete";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ChangeDirectory(string path)
        {
            IAsyncResult sftp = Client.BeginListDirectory(path, AsyncListDirectoryCallback, null);
            List<SftpFile> result = (List<SftpFile>)Client.EndListDirectory(sftp);

            PopulateListView(result);
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
            private string _Status { get; set; }

            public string Name { get; set; }
            public string Status
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
          
            public ProgressRow(string Name, string Status, bool IsDownload = true)
            {
                this.Name = Name;
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
