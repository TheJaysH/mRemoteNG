namespace mRemoteNG.UI.Window
{
    partial class SFTPBrowserWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SFTPBrowserWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCollapse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ngTextBoxCurrentDirectoryRemote = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.ngListViewFilesRemote = new mRemoteNG.UI.Controls.Base.NGListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ngListViewProgress = new mRemoteNG.UI.Controls.Base.NGListView();
            this.olvColumn_File = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.ngButtonConnect = new mRemoteNG.UI.Controls.Base.NGButton();
            this.ngTextBoxLocalDirectory = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.ngGroupBoxSftpConnection = new mRemoteNG.UI.Controls.Base.NGGroupBox();
            this.ngTextBoxPort = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.ngLabelPort = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.ngTextBoxHost = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.ngLabelServer = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.ngGroupBoxCredentials = new mRemoteNG.UI.Controls.Base.NGGroupBox();
            this.ngTextBoxPassword = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.ngTextBoxUsername = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.ngLabelPassword = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.ngLabelUserName = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.ngGroupBox1 = new mRemoteNG.UI.Controls.Base.NGGroupBox();
            this.ngButtonBrowse = new mRemoteNG.UI.Controls.Base.NGButton();
            this.ngLabel1 = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.splitContainerBrowser = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ngListViewFilesLocal = new mRemoteNG.UI.Controls.Base.NGListView();
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ngTextBoxCurrentDirectoryLocal = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngListViewFilesRemote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngListViewProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.ngGroupBoxSftpConnection.SuspendLayout();
            this.ngGroupBoxCredentials.SuspendLayout();
            this.ngGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBrowser)).BeginInit();
            this.splitContainerBrowser.Panel1.SuspendLayout();
            this.splitContainerBrowser.Panel2.SuspendLayout();
            this.splitContainerBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngListViewFilesLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCollapse,
            this.toolStripSeparator2,
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(697, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonCollapse
            // 
            this.toolStripButtonCollapse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCollapse.Image = global::mRemoteNG.Resources.Tools;
            this.toolStripButtonCollapse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCollapse.Name = "toolStripButtonCollapse";
            this.toolStripButtonCollapse.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCollapse.Text = "toolStripButtonCollapse";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // ngTextBoxCurrentDirectoryRemote
            // 
            this.ngTextBoxCurrentDirectoryRemote.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngTextBoxCurrentDirectoryRemote.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngTextBoxCurrentDirectoryRemote.Location = new System.Drawing.Point(0, 0);
            this.ngTextBoxCurrentDirectoryRemote.Name = "ngTextBoxCurrentDirectoryRemote";
            this.ngTextBoxCurrentDirectoryRemote.Size = new System.Drawing.Size(370, 22);
            this.ngTextBoxCurrentDirectoryRemote.TabIndex = 1;
            // 
            // ngListViewFilesRemote
            // 
            this.ngListViewFilesRemote.AllColumns.Add(this.olvColumn1);
            this.ngListViewFilesRemote.AllColumns.Add(this.olvColumn2);
            this.ngListViewFilesRemote.AllColumns.Add(this.olvColumn3);
            this.ngListViewFilesRemote.AllColumns.Add(this.olvColumn4);
            this.ngListViewFilesRemote.AllColumns.Add(this.olvColumn5);
            this.ngListViewFilesRemote.AllColumns.Add(this.olvColumn6);
            this.ngListViewFilesRemote.CellEditUseWholeCell = false;
            this.ngListViewFilesRemote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this.ngListViewFilesRemote.Cursor = System.Windows.Forms.Cursors.Default;
            this.ngListViewFilesRemote.DecorateLines = true;
            this.ngListViewFilesRemote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngListViewFilesRemote.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngListViewFilesRemote.Location = new System.Drawing.Point(0, 22);
            this.ngListViewFilesRemote.Name = "ngListViewFilesRemote";
            this.ngListViewFilesRemote.ShowGroups = false;
            this.ngListViewFilesRemote.Size = new System.Drawing.Size(370, 318);
            this.ngListViewFilesRemote.TabIndex = 0;
            this.ngListViewFilesRemote.UseCompatibleStateImageBehavior = false;
            this.ngListViewFilesRemote.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.ImageAspectName = "Icon";
            this.olvColumn1.Text = "Name";
            this.olvColumn1.Width = 264;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Size";
            this.olvColumn2.AspectToStringFormat = "{0:N0}";
            this.olvColumn2.Text = "Size (KB)";
            this.olvColumn2.Width = 106;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Modified";
            this.olvColumn3.Text = "Last Modified";
            this.olvColumn3.Width = 171;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Owner";
            this.olvColumn4.Text = "Owner";
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Group";
            this.olvColumn5.Text = "Group";
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Access";
            this.olvColumn6.FillsFreeSpace = true;
            this.olvColumn6.Text = "Access";
            // 
            // ngListViewProgress
            // 
            this.ngListViewProgress.AllColumns.Add(this.olvColumn_File);
            this.ngListViewProgress.AllColumns.Add(this.olvColumn_Status);
            this.ngListViewProgress.CellEditUseWholeCell = false;
            this.ngListViewProgress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_File,
            this.olvColumn_Status});
            this.ngListViewProgress.Cursor = System.Windows.Forms.Cursors.Default;
            this.ngListViewProgress.DecorateLines = true;
            this.ngListViewProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngListViewProgress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngListViewProgress.Location = new System.Drawing.Point(0, 0);
            this.ngListViewProgress.Name = "ngListViewProgress";
            this.ngListViewProgress.ShowGroups = false;
            this.ngListViewProgress.Size = new System.Drawing.Size(697, 72);
            this.ngListViewProgress.TabIndex = 0;
            this.ngListViewProgress.UseCompatibleStateImageBehavior = false;
            this.ngListViewProgress.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn_File
            // 
            this.olvColumn_File.AspectName = "Name";
            this.olvColumn_File.ImageAspectName = "Icon";
            this.olvColumn_File.Text = "File";
            this.olvColumn_File.Width = 255;
            // 
            // olvColumn_Status
            // 
            this.olvColumn_Status.AspectName = "Status";
            this.olvColumn_Status.FillsFreeSpace = true;
            this.olvColumn_Status.Text = "Status";
            this.olvColumn_Status.Width = 99;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.ngButtonConnect);
            this.splitContainerMain.Panel1.Controls.Add(this.ngTextBoxLocalDirectory);
            this.splitContainerMain.Panel1.Controls.Add(this.ngGroupBoxSftpConnection);
            this.splitContainerMain.Panel1.Controls.Add(this.ngGroupBoxCredentials);
            this.splitContainerMain.Panel1.Controls.Add(this.ngGroupBox1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerBrowser);
            this.splitContainerMain.Size = new System.Drawing.Size(960, 441);
            this.splitContainerMain.SplitterDistance = 259;
            this.splitContainerMain.TabIndex = 1;
            // 
            // ngButtonConnect
            // 
            this.ngButtonConnect._mice = mRemoteNG.UI.Controls.Base.NGButton.MouseState.OUT;
            this.ngButtonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ngButtonConnect.Location = new System.Drawing.Point(178, 233);
            this.ngButtonConnect.Name = "ngButtonConnect";
            this.ngButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ngButtonConnect.TabIndex = 2;
            this.ngButtonConnect.Text = "Connect";
            this.ngButtonConnect.UseVisualStyleBackColor = true;
            // 
            // ngTextBoxLocalDirectory
            // 
            this.ngTextBoxLocalDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ngTextBoxLocalDirectory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngTextBoxLocalDirectory.Location = new System.Drawing.Point(73, 19);
            this.ngTextBoxLocalDirectory.Name = "ngTextBoxLocalDirectory";
            this.ngTextBoxLocalDirectory.Size = new System.Drawing.Size(145, 22);
            this.ngTextBoxLocalDirectory.TabIndex = 1;
            this.ngTextBoxLocalDirectory.Text = "C:\\Temp";
            // 
            // ngGroupBoxSftpConnection
            // 
            this.ngGroupBoxSftpConnection.Controls.Add(this.ngTextBoxPort);
            this.ngGroupBoxSftpConnection.Controls.Add(this.ngLabelPort);
            this.ngGroupBoxSftpConnection.Controls.Add(this.ngTextBoxHost);
            this.ngGroupBoxSftpConnection.Controls.Add(this.ngLabelServer);
            this.ngGroupBoxSftpConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngGroupBoxSftpConnection.Location = new System.Drawing.Point(0, 141);
            this.ngGroupBoxSftpConnection.Name = "ngGroupBoxSftpConnection";
            this.ngGroupBoxSftpConnection.Size = new System.Drawing.Size(259, 86);
            this.ngGroupBoxSftpConnection.TabIndex = 0;
            this.ngGroupBoxSftpConnection.TabStop = false;
            this.ngGroupBoxSftpConnection.Text = "Connection";
            // 
            // ngTextBoxPort
            // 
            this.ngTextBoxPort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngTextBoxPort.Location = new System.Drawing.Point(77, 47);
            this.ngTextBoxPort.MaxLength = 5;
            this.ngTextBoxPort.Name = "ngTextBoxPort";
            this.ngTextBoxPort.Size = new System.Drawing.Size(70, 22);
            this.ngTextBoxPort.TabIndex = 3;
            this.ngTextBoxPort.Text = "22";
            // 
            // ngLabelPort
            // 
            this.ngLabelPort.AutoSize = true;
            this.ngLabelPort.Location = new System.Drawing.Point(12, 50);
            this.ngLabelPort.Name = "ngLabelPort";
            this.ngLabelPort.Size = new System.Drawing.Size(26, 13);
            this.ngLabelPort.TabIndex = 2;
            this.ngLabelPort.Text = "Port";
            // 
            // ngTextBoxHost
            // 
            this.ngTextBoxHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ngTextBoxHost.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngTextBoxHost.Location = new System.Drawing.Point(77, 19);
            this.ngTextBoxHost.Name = "ngTextBoxHost";
            this.ngTextBoxHost.Size = new System.Drawing.Size(176, 22);
            this.ngTextBoxHost.TabIndex = 1;
            // 
            // ngLabelServer
            // 
            this.ngLabelServer.AutoSize = true;
            this.ngLabelServer.Location = new System.Drawing.Point(12, 22);
            this.ngLabelServer.Name = "ngLabelServer";
            this.ngLabelServer.Size = new System.Drawing.Size(38, 13);
            this.ngLabelServer.TabIndex = 0;
            this.ngLabelServer.Text = "Server";
            // 
            // ngGroupBoxCredentials
            // 
            this.ngGroupBoxCredentials.Controls.Add(this.ngTextBoxPassword);
            this.ngGroupBoxCredentials.Controls.Add(this.ngTextBoxUsername);
            this.ngGroupBoxCredentials.Controls.Add(this.ngLabelPassword);
            this.ngGroupBoxCredentials.Controls.Add(this.ngLabelUserName);
            this.ngGroupBoxCredentials.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngGroupBoxCredentials.Location = new System.Drawing.Point(0, 52);
            this.ngGroupBoxCredentials.Name = "ngGroupBoxCredentials";
            this.ngGroupBoxCredentials.Size = new System.Drawing.Size(259, 89);
            this.ngGroupBoxCredentials.TabIndex = 1;
            this.ngGroupBoxCredentials.TabStop = false;
            this.ngGroupBoxCredentials.Text = "Credentials";
            // 
            // ngTextBoxPassword
            // 
            this.ngTextBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ngTextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngTextBoxPassword.Location = new System.Drawing.Point(73, 47);
            this.ngTextBoxPassword.Name = "ngTextBoxPassword";
            this.ngTextBoxPassword.Size = new System.Drawing.Size(180, 22);
            this.ngTextBoxPassword.TabIndex = 4;
            this.ngTextBoxPassword.UseSystemPasswordChar = true;
            // 
            // ngTextBoxUsername
            // 
            this.ngTextBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ngTextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngTextBoxUsername.Location = new System.Drawing.Point(73, 19);
            this.ngTextBoxUsername.Name = "ngTextBoxUsername";
            this.ngTextBoxUsername.Size = new System.Drawing.Size(180, 22);
            this.ngTextBoxUsername.TabIndex = 3;
            // 
            // ngLabelPassword
            // 
            this.ngLabelPassword.AutoSize = true;
            this.ngLabelPassword.Location = new System.Drawing.Point(12, 50);
            this.ngLabelPassword.Name = "ngLabelPassword";
            this.ngLabelPassword.Size = new System.Drawing.Size(53, 13);
            this.ngLabelPassword.TabIndex = 2;
            this.ngLabelPassword.Text = "Password";
            // 
            // ngLabelUserName
            // 
            this.ngLabelUserName.AutoSize = true;
            this.ngLabelUserName.Location = new System.Drawing.Point(12, 22);
            this.ngLabelUserName.Name = "ngLabelUserName";
            this.ngLabelUserName.Size = new System.Drawing.Size(55, 13);
            this.ngLabelUserName.TabIndex = 0;
            this.ngLabelUserName.Text = "Username";
            // 
            // ngGroupBox1
            // 
            this.ngGroupBox1.Controls.Add(this.ngButtonBrowse);
            this.ngGroupBox1.Controls.Add(this.ngLabel1);
            this.ngGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ngGroupBox1.Name = "ngGroupBox1";
            this.ngGroupBox1.Size = new System.Drawing.Size(259, 52);
            this.ngGroupBox1.TabIndex = 3;
            this.ngGroupBox1.TabStop = false;
            this.ngGroupBox1.Text = "Local Directory";
            // 
            // ngButtonBrowse
            // 
            this.ngButtonBrowse._mice = mRemoteNG.UI.Controls.Base.NGButton.MouseState.OUT;
            this.ngButtonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ngButtonBrowse.Location = new System.Drawing.Point(224, 19);
            this.ngButtonBrowse.Name = "ngButtonBrowse";
            this.ngButtonBrowse.Size = new System.Drawing.Size(29, 23);
            this.ngButtonBrowse.TabIndex = 2;
            this.ngButtonBrowse.Text = "...";
            this.ngButtonBrowse.UseVisualStyleBackColor = true;
            // 
            // ngLabel1
            // 
            this.ngLabel1.AutoSize = true;
            this.ngLabel1.Location = new System.Drawing.Point(12, 22);
            this.ngLabel1.Name = "ngLabel1";
            this.ngLabel1.Size = new System.Drawing.Size(29, 13);
            this.ngLabel1.TabIndex = 0;
            this.ngLabel1.Text = "Path";
            // 
            // splitContainerBrowser
            // 
            this.splitContainerBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBrowser.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerBrowser.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBrowser.Name = "splitContainerBrowser";
            this.splitContainerBrowser.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBrowser.Panel1
            // 
            this.splitContainerBrowser.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainerBrowser.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainerBrowser.Panel2
            // 
            this.splitContainerBrowser.Panel2.Controls.Add(this.ngListViewProgress);
            this.splitContainerBrowser.Size = new System.Drawing.Size(697, 441);
            this.splitContainerBrowser.SplitterDistance = 365;
            this.splitContainerBrowser.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 25);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.ngListViewFilesLocal);
            this.splitContainer3.Panel1.Controls.Add(this.ngTextBoxCurrentDirectoryLocal);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ngListViewFilesRemote);
            this.splitContainer3.Panel2.Controls.Add(this.ngTextBoxCurrentDirectoryRemote);
            this.splitContainer3.Size = new System.Drawing.Size(697, 340);
            this.splitContainer3.SplitterDistance = 323;
            this.splitContainer3.TabIndex = 2;
            // 
            // ngListViewFilesLocal
            // 
            this.ngListViewFilesLocal.AllColumns.Add(this.olvColumn7);
            this.ngListViewFilesLocal.AllColumns.Add(this.olvColumn8);
            this.ngListViewFilesLocal.AllColumns.Add(this.olvColumn9);
            this.ngListViewFilesLocal.CellEditUseWholeCell = false;
            this.ngListViewFilesLocal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn7,
            this.olvColumn8,
            this.olvColumn9});
            this.ngListViewFilesLocal.Cursor = System.Windows.Forms.Cursors.Default;
            this.ngListViewFilesLocal.DecorateLines = true;
            this.ngListViewFilesLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngListViewFilesLocal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngListViewFilesLocal.Location = new System.Drawing.Point(0, 22);
            this.ngListViewFilesLocal.Name = "ngListViewFilesLocal";
            this.ngListViewFilesLocal.ShowGroups = false;
            this.ngListViewFilesLocal.Size = new System.Drawing.Size(323, 318);
            this.ngListViewFilesLocal.TabIndex = 1;
            this.ngListViewFilesLocal.UseCompatibleStateImageBehavior = false;
            this.ngListViewFilesLocal.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "Name";
            this.olvColumn7.ImageAspectName = "Icon";
            this.olvColumn7.Text = "Name";
            this.olvColumn7.Width = 96;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "Size";
            this.olvColumn8.AspectToStringFormat = "{0:N0}";
            this.olvColumn8.Text = "Size (KB)";
            this.olvColumn8.Width = 78;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "Modified";
            this.olvColumn9.FillsFreeSpace = true;
            this.olvColumn9.Text = "Last Modified";
            this.olvColumn9.Width = 120;
            // 
            // ngTextBoxCurrentDirectoryLocal
            // 
            this.ngTextBoxCurrentDirectoryLocal.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngTextBoxCurrentDirectoryLocal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngTextBoxCurrentDirectoryLocal.Location = new System.Drawing.Point(0, 0);
            this.ngTextBoxCurrentDirectoryLocal.Name = "ngTextBoxCurrentDirectoryLocal";
            this.ngTextBoxCurrentDirectoryLocal.Size = new System.Drawing.Size(323, 22);
            this.ngTextBoxCurrentDirectoryLocal.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SFTPBrowserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 441);
            this.Controls.Add(this.splitContainerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SFTPBrowserWindow";
            this.Text = "SFTP Browser";
            this.Load += new System.EventHandler(this.SFTPBrowserWindow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngListViewFilesRemote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngListViewProgress)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ngGroupBoxSftpConnection.ResumeLayout(false);
            this.ngGroupBoxSftpConnection.PerformLayout();
            this.ngGroupBoxCredentials.ResumeLayout(false);
            this.ngGroupBoxCredentials.PerformLayout();
            this.ngGroupBox1.ResumeLayout(false);
            this.ngGroupBox1.PerformLayout();
            this.splitContainerBrowser.Panel1.ResumeLayout(false);
            this.splitContainerBrowser.Panel1.PerformLayout();
            this.splitContainerBrowser.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBrowser)).EndInit();
            this.splitContainerBrowser.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ngListViewFilesLocal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private Controls.Base.NGTextBox ngTextBoxCurrentDirectoryRemote;
        private Controls.Base.NGListView ngListViewFilesRemote;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private Controls.Base.NGListView ngListViewProgress;
        private BrightIdeasSoftware.OLVColumn olvColumn_File;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private Controls.Base.NGGroupBox ngGroupBoxCredentials;
        private Controls.Base.NGGroupBox ngGroupBoxSftpConnection;
        private Controls.Base.NGLabel ngLabelPort;
        private Controls.Base.NGTextBox ngTextBoxHost;
        private Controls.Base.NGLabel ngLabelServer;
        private Controls.Base.NGLabel ngLabelPassword;
        private Controls.Base.NGLabel ngLabelUserName;
        private Controls.Base.NGButton ngButtonConnect;
        private Controls.Base.NGTextBox ngTextBoxPort;
        private Controls.Base.NGTextBox ngTextBoxPassword;
        private Controls.Base.NGTextBox ngTextBoxUsername;
        private Controls.Base.NGGroupBox ngGroupBox1;
        private Controls.Base.NGButton ngButtonBrowse;
        private Controls.Base.NGTextBox ngTextBoxLocalDirectory;
        private Controls.Base.NGLabel ngLabel1;
        private BrightIdeasSoftware.OLVColumn olvColumn_Status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Controls.Base.NGListView ngListViewFilesLocal;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private Controls.Base.NGTextBox ngTextBoxCurrentDirectoryLocal;
        private System.Windows.Forms.ToolStripButton toolStripButtonCollapse;
        private System.Windows.Forms.SplitContainer splitContainerBrowser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}