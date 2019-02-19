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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SFTPBrowserWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
            this.ngTextBoxCurrentDirectory = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.ngListViewFiles = new mRemoteNG.UI.Controls.Base.NGListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ngListViewProgress = new mRemoteNG.UI.Controls.Base.NGListView();
            this.olvColumn_File = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ngGroupBox1 = new mRemoteNG.UI.Controls.Base.NGGroupBox();
            this.ngButtonBrowse = new mRemoteNG.UI.Controls.Base.NGButton();
            this.ngTextBoxLocalDirectory = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.ngLabel1 = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.ngButtonConnect = new mRemoteNG.UI.Controls.Base.NGButton();
            this.ngGroupBoxCredentials = new mRemoteNG.UI.Controls.Base.NGGroupBox();
            this.ngTextBoxPassword = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.ngTextBoxUsername = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.ngLabelPassword = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.ngLabelUserName = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.ngGroupBoxSftpConnection = new mRemoteNG.UI.Controls.Base.NGGroupBox();
            this.ngTextBoxPort = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.ngLabelPort = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.ngTextBoxHost = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.ngLabelServer = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngListViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngListViewProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ngGroupBox1.SuspendLayout();
            this.ngGroupBoxCredentials.SuspendLayout();
            this.ngGroupBoxSftpConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            // ngTextBoxCurrentDirectory
            // 
            this.ngTextBoxCurrentDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngTextBoxCurrentDirectory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngTextBoxCurrentDirectory.Location = new System.Drawing.Point(0, 25);
            this.ngTextBoxCurrentDirectory.Name = "ngTextBoxCurrentDirectory";
            this.ngTextBoxCurrentDirectory.Size = new System.Drawing.Size(697, 22);
            this.ngTextBoxCurrentDirectory.TabIndex = 1;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.ngListViewFiles);
            this.splitContainerMain.Panel1.Controls.Add(this.ngTextBoxCurrentDirectory);
            this.splitContainerMain.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.ngListViewProgress);
            this.splitContainerMain.Size = new System.Drawing.Size(697, 441);
            this.splitContainerMain.SplitterDistance = 360;
            this.splitContainerMain.TabIndex = 2;
            // 
            // ngListViewFiles
            // 
            this.ngListViewFiles.AllColumns.Add(this.olvColumn1);
            this.ngListViewFiles.AllColumns.Add(this.olvColumn2);
            this.ngListViewFiles.AllColumns.Add(this.olvColumn3);
            this.ngListViewFiles.AllColumns.Add(this.olvColumn4);
            this.ngListViewFiles.AllColumns.Add(this.olvColumn5);
            this.ngListViewFiles.AllColumns.Add(this.olvColumn6);
            this.ngListViewFiles.CellEditUseWholeCell = false;
            this.ngListViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this.ngListViewFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.ngListViewFiles.DecorateLines = true;
            this.ngListViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngListViewFiles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngListViewFiles.Location = new System.Drawing.Point(0, 47);
            this.ngListViewFiles.Name = "ngListViewFiles";
            this.ngListViewFiles.ShowGroups = false;
            this.ngListViewFiles.Size = new System.Drawing.Size(697, 313);
            this.ngListViewFiles.TabIndex = 0;
            this.ngListViewFiles.UseCompatibleStateImageBehavior = false;
            this.ngListViewFiles.View = System.Windows.Forms.View.Details;
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
            this.ngListViewProgress.Size = new System.Drawing.Size(697, 77);
            this.ngListViewProgress.TabIndex = 0;
            this.ngListViewProgress.UseCompatibleStateImageBehavior = false;
            this.ngListViewProgress.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn_File
            // 
            this.olvColumn_File.AspectName = "Name";
            this.olvColumn_File.ImageAspectName = "Icon";
            this.olvColumn_File.Text = "File";
            this.olvColumn_File.Width = 221;
            // 
            // olvColumn_Status
            // 
            this.olvColumn_Status.AspectName = "Status";
            this.olvColumn_Status.Text = "Status";
            this.olvColumn_Status.Width = 188;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ngGroupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.ngButtonConnect);
            this.splitContainer1.Panel1.Controls.Add(this.ngGroupBoxCredentials);
            this.splitContainer1.Panel1.Controls.Add(this.ngGroupBoxSftpConnection);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerMain);
            this.splitContainer1.Size = new System.Drawing.Size(960, 441);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 1;
            // 
            // ngGroupBox1
            // 
            this.ngGroupBox1.Controls.Add(this.ngButtonBrowse);
            this.ngGroupBox1.Controls.Add(this.ngTextBoxLocalDirectory);
            this.ngGroupBox1.Controls.Add(this.ngLabel1);
            this.ngGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngGroupBox1.Location = new System.Drawing.Point(0, 175);
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
            // ngLabel1
            // 
            this.ngLabel1.AutoSize = true;
            this.ngLabel1.Location = new System.Drawing.Point(12, 22);
            this.ngLabel1.Name = "ngLabel1";
            this.ngLabel1.Size = new System.Drawing.Size(29, 13);
            this.ngLabel1.TabIndex = 0;
            this.ngLabel1.Text = "Path";
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
            // ngGroupBoxCredentials
            // 
            this.ngGroupBoxCredentials.Controls.Add(this.ngTextBoxPassword);
            this.ngGroupBoxCredentials.Controls.Add(this.ngTextBoxUsername);
            this.ngGroupBoxCredentials.Controls.Add(this.ngLabelPassword);
            this.ngGroupBoxCredentials.Controls.Add(this.ngLabelUserName);
            this.ngGroupBoxCredentials.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngGroupBoxCredentials.Location = new System.Drawing.Point(0, 86);
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
            // ngGroupBoxSftpConnection
            // 
            this.ngGroupBoxSftpConnection.Controls.Add(this.ngTextBoxPort);
            this.ngGroupBoxSftpConnection.Controls.Add(this.ngLabelPort);
            this.ngGroupBoxSftpConnection.Controls.Add(this.ngTextBoxHost);
            this.ngGroupBoxSftpConnection.Controls.Add(this.ngLabelServer);
            this.ngGroupBoxSftpConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.ngGroupBoxSftpConnection.Location = new System.Drawing.Point(0, 0);
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
            // SFTPBrowserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 441);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SFTPBrowserWindow";
            this.Text = "SFTPBrowserWindow";
            this.Load += new System.EventHandler(this.SFTPBrowserWindow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ngListViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngListViewProgress)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ngGroupBox1.ResumeLayout(false);
            this.ngGroupBox1.PerformLayout();
            this.ngGroupBoxCredentials.ResumeLayout(false);
            this.ngGroupBoxCredentials.PerformLayout();
            this.ngGroupBoxSftpConnection.ResumeLayout(false);
            this.ngGroupBoxSftpConnection.PerformLayout();
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
        private Controls.Base.NGTextBox ngTextBoxCurrentDirectory;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private Controls.Base.NGListView ngListViewFiles;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private Controls.Base.NGListView ngListViewProgress;
        private BrightIdeasSoftware.OLVColumn olvColumn_File;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
    }
}