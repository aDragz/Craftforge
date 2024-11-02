namespace CraftForge.Server.GUI.Applications
{
    partial class settings
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Buttons");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Theme", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Maximize");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Console", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Maximize");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Startup", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Appearance", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Release");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("App", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.Appearance = new System.Windows.Forms.TabPage();
            this.StartupPanel = new System.Windows.Forms.Panel();
            this.MaximizeStartupPanel = new System.Windows.Forms.CheckBox();
            this.Startup = new System.Windows.Forms.Label();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.AutoStartConsolePanel = new System.Windows.Forms.CheckBox();
            this.MaximizeConsolePanel = new System.Windows.Forms.CheckBox();
            this.Console = new System.Windows.Forms.Label();
            this.ThemeConsolePanel = new System.Windows.Forms.Label();
            this.themeListConsolePanel = new System.Windows.Forms.ComboBox();
            this.App = new System.Windows.Forms.TabPage();
            this.VersionPanel = new System.Windows.Forms.Panel();
            this.Version = new System.Windows.Forms.Label();
            this.TypeApplicationPanel = new System.Windows.Forms.Label();
            this.TypeListConsolePanel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.Appearance.SuspendLayout();
            this.StartupPanel.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.App.SuspendLayout();
            this.VersionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "AppearanceButtons";
            treeNode1.Text = "Buttons";
            treeNode2.Name = "themeList";
            treeNode2.Text = "Theme";
            treeNode3.Name = "MaximizeConsole";
            treeNode3.Text = "Maximize";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Console";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Maximize";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Node2";
            treeNode7.Name = "StartupNode";
            treeNode7.Text = "Startup";
            treeNode8.Name = "Appearance";
            treeNode8.Text = "Appearance";
            treeNode9.Name = "Release";
            treeNode9.Text = "Release";
            treeNode10.Name = "App";
            treeNode10.Text = "App";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(419, 664);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabPage);
            this.splitContainer1.Size = new System.Drawing.Size(1258, 664);
            this.splitContainer1.SplitterDistance = 419;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.Appearance);
            this.tabPage.Controls.Add(this.App);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Location = new System.Drawing.Point(0, 0);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(835, 664);
            this.tabPage.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPage.TabIndex = 0;
            // 
            // Appearance
            // 
            this.Appearance.AutoScroll = true;
            this.Appearance.Controls.Add(this.StartupPanel);
            this.Appearance.Controls.Add(this.ConsolePanel);
            this.Appearance.Location = new System.Drawing.Point(4, 29);
            this.Appearance.Name = "Appearance";
            this.Appearance.Padding = new System.Windows.Forms.Padding(3);
            this.Appearance.Size = new System.Drawing.Size(827, 631);
            this.Appearance.TabIndex = 0;
            this.Appearance.Text = "Appearance";
            this.Appearance.UseVisualStyleBackColor = true;
            // 
            // StartupPanel
            // 
            this.StartupPanel.Controls.Add(this.MaximizeStartupPanel);
            this.StartupPanel.Controls.Add(this.Startup);
            this.StartupPanel.Location = new System.Drawing.Point(0, 205);
            this.StartupPanel.Name = "StartupPanel";
            this.StartupPanel.Size = new System.Drawing.Size(820, 130);
            this.StartupPanel.TabIndex = 11;
            // 
            // MaximizeStartupPanel
            // 
            this.MaximizeStartupPanel.AutoSize = true;
            this.MaximizeStartupPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MaximizeStartupPanel.Location = new System.Drawing.Point(20, 40);
            this.MaximizeStartupPanel.Name = "MaximizeStartupPanel";
            this.MaximizeStartupPanel.Size = new System.Drawing.Size(255, 33);
            this.MaximizeStartupPanel.TabIndex = 16;
            this.MaximizeStartupPanel.Text = "Maximize on Startup";
            this.MaximizeStartupPanel.UseVisualStyleBackColor = true;
            this.MaximizeStartupPanel.CheckedChanged += new System.EventHandler(this.MaximizeStartupPanel_CheckedChanged);
            // 
            // Startup
            // 
            this.Startup.AutoSize = true;
            this.Startup.Font = new System.Drawing.Font("Consolas", 16F);
            this.Startup.Location = new System.Drawing.Point(0, 0);
            this.Startup.Name = "Startup";
            this.Startup.Size = new System.Drawing.Size(143, 37);
            this.Startup.TabIndex = 9;
            this.Startup.Text = "Startup";
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.Controls.Add(this.AutoStartConsolePanel);
            this.ConsolePanel.Controls.Add(this.MaximizeConsolePanel);
            this.ConsolePanel.Controls.Add(this.Console);
            this.ConsolePanel.Controls.Add(this.ThemeConsolePanel);
            this.ConsolePanel.Controls.Add(this.themeListConsolePanel);
            this.ConsolePanel.Location = new System.Drawing.Point(0, 0);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(820, 200);
            this.ConsolePanel.TabIndex = 10;
            // 
            // AutoStartConsolePanel
            // 
            this.AutoStartConsolePanel.AutoSize = true;
            this.AutoStartConsolePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AutoStartConsolePanel.Location = new System.Drawing.Point(20, 160);
            this.AutoStartConsolePanel.Name = "AutoStartConsolePanel";
            this.AutoStartConsolePanel.Size = new System.Drawing.Size(334, 33);
            this.AutoStartConsolePanel.TabIndex = 15;
            this.AutoStartConsolePanel.Text = "Auto Start Server on Startup";
            this.AutoStartConsolePanel.UseVisualStyleBackColor = true;
            this.AutoStartConsolePanel.CheckedChanged += new System.EventHandler(this.AutoStartConsolePanel_CheckedChanged);
            // 
            // MaximizeConsolePanel
            // 
            this.MaximizeConsolePanel.AutoSize = true;
            this.MaximizeConsolePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MaximizeConsolePanel.Location = new System.Drawing.Point(20, 120);
            this.MaximizeConsolePanel.Name = "MaximizeConsolePanel";
            this.MaximizeConsolePanel.Size = new System.Drawing.Size(255, 33);
            this.MaximizeConsolePanel.TabIndex = 14;
            this.MaximizeConsolePanel.Text = "Maximize on Startup";
            this.MaximizeConsolePanel.UseVisualStyleBackColor = true;
            this.MaximizeConsolePanel.CheckedChanged += new System.EventHandler(this.MaximizeConsolePanel_CheckedChanged);
            // 
            // Console
            // 
            this.Console.AutoSize = true;
            this.Console.Font = new System.Drawing.Font("Consolas", 16F);
            this.Console.Location = new System.Drawing.Point(0, 0);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(143, 37);
            this.Console.TabIndex = 9;
            this.Console.Text = "Console";
            // 
            // ThemeConsolePanel
            // 
            this.ThemeConsolePanel.AutoSize = true;
            this.ThemeConsolePanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.ThemeConsolePanel.Location = new System.Drawing.Point(15, 40);
            this.ThemeConsolePanel.Name = "ThemeConsolePanel";
            this.ThemeConsolePanel.Size = new System.Drawing.Size(77, 28);
            this.ThemeConsolePanel.TabIndex = 1;
            this.ThemeConsolePanel.Text = "Theme";
            // 
            // themeListConsolePanel
            // 
            this.themeListConsolePanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.themeListConsolePanel.FormattingEnabled = true;
            this.themeListConsolePanel.Location = new System.Drawing.Point(20, 70);
            this.themeListConsolePanel.Name = "themeListConsolePanel";
            this.themeListConsolePanel.Size = new System.Drawing.Size(415, 36);
            this.themeListConsolePanel.TabIndex = 6;
            this.themeListConsolePanel.SelectedIndexChanged += new System.EventHandler(this.themeList_SelectedIndexChanged);
            // 
            // App
            // 
            this.App.Controls.Add(this.VersionPanel);
            this.App.Location = new System.Drawing.Point(4, 29);
            this.App.Name = "App";
            this.App.Padding = new System.Windows.Forms.Padding(3);
            this.App.Size = new System.Drawing.Size(827, 631);
            this.App.TabIndex = 1;
            this.App.Text = "App";
            this.App.UseVisualStyleBackColor = true;
            // 
            // VersionPanel
            // 
            this.VersionPanel.Controls.Add(this.Version);
            this.VersionPanel.Controls.Add(this.TypeApplicationPanel);
            this.VersionPanel.Controls.Add(this.TypeListConsolePanel);
            this.VersionPanel.Location = new System.Drawing.Point(0, 0);
            this.VersionPanel.Name = "VersionPanel";
            this.VersionPanel.Size = new System.Drawing.Size(820, 200);
            this.VersionPanel.TabIndex = 11;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Consolas", 16F);
            this.Version.Location = new System.Drawing.Point(0, 0);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(143, 37);
            this.Version.TabIndex = 9;
            this.Version.Text = "Version";
            // 
            // TypeApplicationPanel
            // 
            this.TypeApplicationPanel.AutoSize = true;
            this.TypeApplicationPanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.TypeApplicationPanel.Location = new System.Drawing.Point(15, 40);
            this.TypeApplicationPanel.Name = "TypeApplicationPanel";
            this.TypeApplicationPanel.Size = new System.Drawing.Size(103, 28);
            this.TypeApplicationPanel.TabIndex = 1;
            this.TypeApplicationPanel.Text = "Release";
            // 
            // TypeListConsolePanel
            // 
            this.TypeListConsolePanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.TypeListConsolePanel.FormattingEnabled = true;
            this.TypeListConsolePanel.Location = new System.Drawing.Point(20, 70);
            this.TypeListConsolePanel.Name = "TypeListConsolePanel";
            this.TypeListConsolePanel.Size = new System.Drawing.Size(415, 36);
            this.TypeListConsolePanel.TabIndex = 6;
            this.TypeListConsolePanel.SelectedIndexChanged += new System.EventHandler(this.TypeListConsolePanel_SelectedIndexChanged);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.Appearance.ResumeLayout(false);
            this.StartupPanel.ResumeLayout(false);
            this.StartupPanel.PerformLayout();
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            this.App.ResumeLayout(false);
            this.VersionPanel.ResumeLayout(false);
            this.VersionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage Appearance;
        private System.Windows.Forms.Label ThemeConsolePanel;
        private System.Windows.Forms.ComboBox themeListConsolePanel;
        private System.Windows.Forms.Label Console;
        private System.Windows.Forms.Panel ConsolePanel;
        private System.Windows.Forms.Panel StartupPanel;
        private System.Windows.Forms.Label Startup;
        private System.Windows.Forms.CheckBox MaximizeConsolePanel;
        private System.Windows.Forms.CheckBox AutoStartConsolePanel;
        private System.Windows.Forms.CheckBox MaximizeStartupPanel;
        private System.Windows.Forms.TabPage App;
        private System.Windows.Forms.Panel VersionPanel;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label TypeApplicationPanel;
        private System.Windows.Forms.ComboBox TypeListConsolePanel;
    }
}