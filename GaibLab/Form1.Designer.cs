namespace GaibLab
{
    partial class frmExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExplorer));
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameFileHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.largeIcon = new System.Windows.Forms.ImageList(this.components);
            this.smallIcon = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tampilanLembarKerjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewMenu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.recordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordVoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mediumIcon = new System.Windows.Forms.ImageList(this.components);
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameFileHeader,
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.largeIcon;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(827, 380);
            this.listView1.SmallImageList = this.smallIcon;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // nameFileHeader
            // 
            this.nameFileHeader.Text = "Nama File";
            this.nameFileHeader.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Jenis File";
            this.columnHeader1.Width = 90;
            // 
            // largeIcon
            // 
            this.largeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeIcon.ImageStream")));
            this.largeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.largeIcon.Images.SetKeyName(0, "MSACCESS_265.ico");
            this.largeIcon.Images.SetKeyName(1, "EXCEL_258.ico");
            this.largeIcon.Images.SetKeyName(2, "WINWORD_2.ico");
            this.largeIcon.Images.SetKeyName(3, "POWERPNT_1312.ico");
            this.largeIcon.Images.SetKeyName(4, "wiashext_107.ico");
            this.largeIcon.Images.SetKeyName(5, "wmp_29102.ico");
            this.largeIcon.Images.SetKeyName(6, "wmp_29105.ico");
            this.largeIcon.Images.SetKeyName(7, "wmp_29107.ico");
            // 
            // smallIcon
            // 
            this.smallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallIcon.ImageStream")));
            this.smallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.smallIcon.Images.SetKeyName(0, "MSACCESS_265.ico");
            this.smallIcon.Images.SetKeyName(1, "EXCEL_258.ico");
            this.smallIcon.Images.SetKeyName(2, "WINWORD_2.ico");
            this.smallIcon.Images.SetKeyName(3, "POWERPNT_1312.ico");
            this.smallIcon.Images.SetKeyName(4, "wiashext_107.ico");
            this.smallIcon.Images.SetKeyName(5, "wmp_29102.ico");
            this.smallIcon.Images.SetKeyName(6, "wmp_29107.ico");
            this.smallIcon.Images.SetKeyName(7, "wmp_29105.ico");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.recordingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tampilanLembarKerjaToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // tampilanLembarKerjaToolStripMenuItem
            // 
            this.tampilanLembarKerjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenu1,
            this.viewMenu2,
            this.viewMenu3,
            this.toolStripMenuItem1,
            this.viewMenu4});
            this.tampilanLembarKerjaToolStripMenuItem.Name = "tampilanLembarKerjaToolStripMenuItem";
            this.tampilanLembarKerjaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.tampilanLembarKerjaToolStripMenuItem.Text = "Tampilan Lembar Kerja";
            // 
            // viewMenu1
            // 
            this.viewMenu1.Checked = true;
            this.viewMenu1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewMenu1.Name = "viewMenu1";
            this.viewMenu1.Size = new System.Drawing.Size(150, 22);
            this.viewMenu1.Tag = "1";
            this.viewMenu1.Text = "Small Icons";
            this.viewMenu1.Click += new System.EventHandler(this.ubahLembarKerja);
            // 
            // viewMenu2
            // 
            this.viewMenu2.Name = "viewMenu2";
            this.viewMenu2.Size = new System.Drawing.Size(150, 22);
            this.viewMenu2.Tag = "2";
            this.viewMenu2.Text = "Medium Icons";
            this.viewMenu2.Click += new System.EventHandler(this.ubahLembarKerja);
            // 
            // viewMenu3
            // 
            this.viewMenu3.Name = "viewMenu3";
            this.viewMenu3.Size = new System.Drawing.Size(150, 22);
            this.viewMenu3.Tag = "3";
            this.viewMenu3.Text = "Large Icons";
            this.viewMenu3.Click += new System.EventHandler(this.ubahLembarKerja);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // viewMenu4
            // 
            this.viewMenu4.Name = "viewMenu4";
            this.viewMenu4.Size = new System.Drawing.Size(150, 22);
            this.viewMenu4.Tag = "4";
            this.viewMenu4.Text = "Details";
            this.viewMenu4.Click += new System.EventHandler(this.ubahLembarKerja);
            // 
            // recordingToolStripMenuItem
            // 
            this.recordingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordVoiceToolStripMenuItem,
            this.paintToolStripMenuItem});
            this.recordingToolStripMenuItem.Name = "recordingToolStripMenuItem";
            this.recordingToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.recordingToolStripMenuItem.Text = "Learning";
            // 
            // recordVoiceToolStripMenuItem
            // 
            this.recordVoiceToolStripMenuItem.Name = "recordVoiceToolStripMenuItem";
            this.recordVoiceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recordVoiceToolStripMenuItem.Text = "Record Voice";
            this.recordVoiceToolStripMenuItem.Click += new System.EventHandler(this.recordVoiceToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(250, 380);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(1081, 380);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 3;
            // 
            // menuFile
            // 
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(61, 4);
            // 
            // mediumIcon
            // 
            this.mediumIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mediumIcon.ImageStream")));
            this.mediumIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.mediumIcon.Images.SetKeyName(0, "MSACCESS_265.ico");
            this.mediumIcon.Images.SetKeyName(1, "EXCEL_258.ico");
            this.mediumIcon.Images.SetKeyName(2, "WINWORD_2.ico");
            this.mediumIcon.Images.SetKeyName(3, "POWERPNT_1312.ico");
            this.mediumIcon.Images.SetKeyName(4, "wiashext_107.ico");
            this.mediumIcon.Images.SetKeyName(5, "wmp_29102.ico");
            this.mediumIcon.Images.SetKeyName(6, "wmp_29105.ico");
            this.mediumIcon.Images.SetKeyName(7, "wmp_29107.ico");
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.paintToolStripMenuItem.Text = "Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.paintToolStripMenuItem_Click);
            // 
            // frmExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 404);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmExplorer";
            this.Text = "Laboratorium GaIB";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ImageList smallIcon;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tampilanLembarKerjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu1;
        private System.Windows.Forms.ToolStripMenuItem viewMenu2;
        private System.Windows.Forms.ToolStripMenuItem viewMenu3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewMenu4;
        private System.Windows.Forms.ColumnHeader nameFileHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip menuFile;
        private System.Windows.Forms.ImageList mediumIcon;
        private System.Windows.Forms.ImageList largeIcon;
        private System.Windows.Forms.ToolStripMenuItem recordingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordVoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
    }
}

