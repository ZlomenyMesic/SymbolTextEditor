namespace HighQualityTextEditor {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.obsahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hledatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.oprogramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxMain = new RichTextBoxExtended();
            this.label1 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numberLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.toolsMenu,
            this.helpMenu,
            this.customizeMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.openMenu,
            this.toolStripSeparator,
            this.saveMenu,
            this.saveAsMenu,
            this.toolStripSeparator1,
            this.exitMenu});
            this.fileMenu.Image = ((System.Drawing.Image)(resources.GetObject("fileMenu.Image")));
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(53, 20);
            this.fileMenu.Text = "&File";
            // 
            // newMenu
            // 
            this.newMenu.Image = ((System.Drawing.Image)(resources.GetObject("newMenu.Image")));
            this.newMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newMenu.Name = "newMenu";
            this.newMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenu.Size = new System.Drawing.Size(146, 22);
            this.newMenu.Text = "&New";
            this.newMenu.Click += new System.EventHandler(this.NewFile);
            // 
            // openMenu
            // 
            this.openMenu.Image = ((System.Drawing.Image)(resources.GetObject("openMenu.Image")));
            this.openMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openMenu.Name = "openMenu";
            this.openMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenu.Size = new System.Drawing.Size(146, 22);
            this.openMenu.Text = "&Open";
            this.openMenu.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveMenu
            // 
            this.saveMenu.Image = ((System.Drawing.Image)(resources.GetObject("saveMenu.Image")));
            this.saveMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenu.Size = new System.Drawing.Size(146, 22);
            this.saveMenu.Text = "&Save";
            this.saveMenu.Click += new System.EventHandler(this.Save);
            // 
            // saveAsMenu
            // 
            this.saveAsMenu.Name = "saveAsMenu";
            this.saveAsMenu.Size = new System.Drawing.Size(146, 22);
            this.saveAsMenu.Text = "Save &As";
            this.saveAsMenu.Click += new System.EventHandler(this.SaveAs);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Image = ((System.Drawing.Image)(resources.GetObject("exitMenu.Image")));
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(146, 22);
            this.exitMenu.Text = "&Exit";
            this.exitMenu.Click += new System.EventHandler(this.Exit);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenu,
            this.redoMenu,
            this.toolStripSeparator3,
            this.cutMenu,
            this.copyMenu,
            this.pasteMenu,
            this.toolStripSeparator4,
            this.selectAllMenu});
            this.editMenu.Image = ((System.Drawing.Image)(resources.GetObject("editMenu.Image")));
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(55, 20);
            this.editMenu.Text = "&Edit";
            // 
            // undoMenu
            // 
            this.undoMenu.Name = "undoMenu";
            this.undoMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenu.Size = new System.Drawing.Size(144, 22);
            this.undoMenu.Text = "&Undo";
            this.undoMenu.Click += new System.EventHandler(this.Undo);
            // 
            // redoMenu
            // 
            this.redoMenu.Name = "redoMenu";
            this.redoMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoMenu.Size = new System.Drawing.Size(144, 22);
            this.redoMenu.Text = "&Redo";
            this.redoMenu.Click += new System.EventHandler(this.Redo);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutMenu
            // 
            this.cutMenu.Image = ((System.Drawing.Image)(resources.GetObject("cutMenu.Image")));
            this.cutMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutMenu.Name = "cutMenu";
            this.cutMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenu.Size = new System.Drawing.Size(144, 22);
            this.cutMenu.Text = "&Cut";
            this.cutMenu.Click += new System.EventHandler(this.Cut);
            // 
            // copyMenu
            // 
            this.copyMenu.Image = ((System.Drawing.Image)(resources.GetObject("copyMenu.Image")));
            this.copyMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenu.Size = new System.Drawing.Size(144, 22);
            this.copyMenu.Text = "&Copy";
            this.copyMenu.Click += new System.EventHandler(this.Copy);
            // 
            // pasteMenu
            // 
            this.pasteMenu.Image = ((System.Drawing.Image)(resources.GetObject("pasteMenu.Image")));
            this.pasteMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteMenu.Name = "pasteMenu";
            this.pasteMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenu.Size = new System.Drawing.Size(144, 22);
            this.pasteMenu.Text = "&Paste";
            this.pasteMenu.Click += new System.EventHandler(this.Paste);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllMenu
            // 
            this.selectAllMenu.Name = "selectAllMenu";
            this.selectAllMenu.Size = new System.Drawing.Size(144, 22);
            this.selectAllMenu.Text = "&Select All";
            this.selectAllMenu.Click += new System.EventHandler(this.SelectAll);
            // 
            // toolsMenu
            // 
            this.toolsMenu.Image = ((System.Drawing.Image)(resources.GetObject("toolsMenu.Image")));
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(62, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obsahToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.hledatToolStripMenuItem,
            this.toolStripSeparator5,
            this.oprogramuToolStripMenuItem});
            this.helpMenu.Image = ((System.Drawing.Image)(resources.GetObject("helpMenu.Image")));
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(60, 20);
            this.helpMenu.Text = "&Help";
            // 
            // obsahToolStripMenuItem
            // 
            this.obsahToolStripMenuItem.Name = "obsahToolStripMenuItem";
            this.obsahToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.obsahToolStripMenuItem.Text = "&Obsah";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // hledatToolStripMenuItem
            // 
            this.hledatToolStripMenuItem.Name = "hledatToolStripMenuItem";
            this.hledatToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.hledatToolStripMenuItem.Text = "&Hledat";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(145, 6);
            // 
            // oprogramuToolStripMenuItem
            // 
            this.oprogramuToolStripMenuItem.Name = "oprogramuToolStripMenuItem";
            this.oprogramuToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.oprogramuToolStripMenuItem.Text = "&O programu...";
            // 
            // customizeMenu
            // 
            this.customizeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeMenu});
            this.customizeMenu.Name = "customizeMenu";
            this.customizeMenu.Size = new System.Drawing.Size(75, 20);
            this.customizeMenu.Text = "&Customize";
            // 
            // darkModeMenu
            // 
            this.darkModeMenu.Name = "darkModeMenu";
            this.darkModeMenu.Size = new System.Drawing.Size(132, 22);
            this.darkModeMenu.Text = "&Dark mode";
            this.darkModeMenu.Click += new System.EventHandler(this.DarkMode);
            // 
            // textBoxMain
            // 
            this.textBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMain.Font = new System.Drawing.Font("Courier new", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMain.ForeColor = System.Drawing.Color.Black;
            this.textBoxMain.Location = new System.Drawing.Point(0, 0);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(776, 387);
            this.textBoxMain.AcceptsTab = true;
            this.textBoxMain.SelectionTabs = new int[]{ 32, 64, 96, 128, 160, 192 };
            this.textBoxMain.TabIndex = 1;
            this.textBoxMain.Text = "";
            this.textBoxMain.VScroll += new System.EventHandler(this.TextBoxVScroll);
            this.textBoxMain.FontChanged += new System.EventHandler(this.TextBoxFontChanged);
            this.textBoxMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyUp);
            this.textBoxMain.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.textBoxMain.Resize += new System.EventHandler(this.TextBoxResized);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "HQ Text Editor";
            // 
            // quitButton
            // 
            this.quitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quitButton.BackgroundImage")));
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Location = new System.Drawing.Point(797, 0);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(20, 20);
            this.quitButton.TabIndex = 3;
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.Exit);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(774, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.Minimize);
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 44);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.numberLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxMain);
            this.splitContainer1.Size = new System.Drawing.Size(817, 387);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // numberLabel
            // 
            this.numberLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.numberLabel.Location = new System.Drawing.Point(0, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(37, 9999);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "1";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 431);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(817, 431);
            this.MinimumSize = new System.Drawing.Size(817, 431);
            this.Name = "Form1";
            this.Text = "HQ Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion++


        public MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem newMenu;
        private ToolStripMenuItem openMenu;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveMenu;
        private ToolStripMenuItem saveAsMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitMenu;
        private ToolStripMenuItem editMenu;
        private ToolStripMenuItem undoMenu;
        private ToolStripMenuItem redoMenu;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutMenu;
        private ToolStripMenuItem copyMenu;
        private ToolStripMenuItem pasteMenu;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllMenu;
        private ToolStripMenuItem toolsMenu;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem obsahToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem hledatToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem oprogramuToolStripMenuItem;
        public RichTextBoxExtended textBoxMain;
        private ToolStripMenuItem customizeMenu;
        private ToolStripMenuItem darkModeMenu;
        public Label label1;
        private Button quitButton;
        private Button minimizeButton;
        public SplitContainer splitContainer1;
        public Label numberLabel;
    }
}