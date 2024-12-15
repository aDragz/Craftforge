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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Theme");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Maximize");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("AutoScroll");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Console", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Maximize");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Specifications");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Startup", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Appearance", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Release");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("AutoUpdate");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Version", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("App", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.Appearance = new System.Windows.Forms.TabPage();
            this.StartupPanel = new System.Windows.Forms.Panel();
            this.SpecificationsStartupPanel = new System.Windows.Forms.CheckBox();
            this.MaximizeStartupPanel = new System.Windows.Forms.CheckBox();
            this.Startup = new System.Windows.Forms.Label();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.ConsoleConsolePanel = new System.Windows.Forms.Label();
            this.autoScrollConsolePanel = new System.Windows.Forms.CheckBox();
            this.AutoStartConsolePanel = new System.Windows.Forms.CheckBox();
            this.Console = new System.Windows.Forms.Label();
            this.ThemeConsolePanel = new System.Windows.Forms.Label();
            this.themeListConsolePanel = new System.Windows.Forms.ComboBox();
            this.App = new System.Windows.Forms.TabPage();
            this.VersionPanel = new System.Windows.Forms.Panel();
            this.AutoUpdateAppPanel = new System.Windows.Forms.CheckBox();
            this.Version = new System.Windows.Forms.Label();
            this.TypeVersionPanel = new System.Windows.Forms.Label();
            this.TypeListAppPanel = new System.Windows.Forms.ComboBox();
            this.customThemeBtn = new System.Windows.Forms.Button();
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
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "themeList";
            treeNode1.Text = "Theme";
            treeNode2.Name = "MaximizeConsole";
            treeNode2.Text = "Maximize";
            treeNode3.Name = "AutoScrollConsole";
            treeNode3.Text = "AutoScroll";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Console";
            treeNode5.Name = "MaximizeStartup";
            treeNode5.Text = "Maximize";
            treeNode6.Name = "SpecificationsStartup";
            treeNode6.Text = "Specifications";
            treeNode7.Name = "StartupNode";
            treeNode7.Text = "Startup";
            treeNode8.Name = "Appearance";
            treeNode8.Text = "Appearance";
            treeNode9.Name = "ReleaseVersion";
            treeNode9.Text = "Release";
            treeNode10.Name = "AutoUpdateVersion";
            treeNode10.Text = "AutoUpdate";
            treeNode11.Name = "Version";
            treeNode11.Text = "Version";
            treeNode12.Name = "App";
            treeNode12.Text = "App";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(372, 531);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabPage);
            this.splitContainer1.Size = new System.Drawing.Size(1118, 531);
            this.splitContainer1.SplitterDistance = 372;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.Appearance);
            this.tabPage.Controls.Add(this.App);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Location = new System.Drawing.Point(0, 0);
            this.tabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(742, 531);
            this.tabPage.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPage.TabIndex = 0;
            // 
            // Appearance
            // 
            this.Appearance.AutoScroll = true;
            this.Appearance.Controls.Add(this.StartupPanel);
            this.Appearance.Controls.Add(this.ConsolePanel);
            this.Appearance.Location = new System.Drawing.Point(4, 25);
            this.Appearance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Appearance.Name = "Appearance";
            this.Appearance.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Appearance.Size = new System.Drawing.Size(734, 502);
            this.Appearance.TabIndex = 0;
            this.Appearance.Text = "Appearance";
            this.Appearance.UseVisualStyleBackColor = true;
            // 
            // StartupPanel
            // 
            this.StartupPanel.Controls.Add(this.SpecificationsStartupPanel);
            this.StartupPanel.Controls.Add(this.MaximizeStartupPanel);
            this.StartupPanel.Controls.Add(this.Startup);
            this.StartupPanel.Location = new System.Drawing.Point(0, 197);
            this.StartupPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartupPanel.Name = "StartupPanel";
            this.StartupPanel.Size = new System.Drawing.Size(729, 134);
            this.StartupPanel.TabIndex = 11;
            // 
            // SpecificationsStartupPanel
            // 
            this.SpecificationsStartupPanel.AutoSize = true;
            this.SpecificationsStartupPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SpecificationsStartupPanel.Location = new System.Drawing.Point(18, 72);
            this.SpecificationsStartupPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpecificationsStartupPanel.Name = "SpecificationsStartupPanel";
            this.SpecificationsStartupPanel.Size = new System.Drawing.Size(281, 29);
            this.SpecificationsStartupPanel.TabIndex = 17;
            this.SpecificationsStartupPanel.Text = "Show System Specifications";
            this.SpecificationsStartupPanel.UseVisualStyleBackColor = true;
            this.SpecificationsStartupPanel.CheckedChanged += new System.EventHandler(this.SpecificationsStartupPanel_CheckedChanged);
            // 
            // MaximizeStartupPanel
            // 
            this.MaximizeStartupPanel.AutoSize = true;
            this.MaximizeStartupPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MaximizeStartupPanel.Location = new System.Drawing.Point(18, 32);
            this.MaximizeStartupPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeStartupPanel.Name = "MaximizeStartupPanel";
            this.MaximizeStartupPanel.Size = new System.Drawing.Size(212, 29);
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
            this.Startup.Size = new System.Drawing.Size(119, 32);
            this.Startup.TabIndex = 9;
            this.Startup.Text = "Startup";
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.Controls.Add(this.customThemeBtn);
            this.ConsolePanel.Controls.Add(this.ConsoleConsolePanel);
            this.ConsolePanel.Controls.Add(this.autoScrollConsolePanel);
            this.ConsolePanel.Controls.Add(this.AutoStartConsolePanel);
            this.ConsolePanel.Controls.Add(this.Console);
            this.ConsolePanel.Controls.Add(this.ThemeConsolePanel);
            this.ConsolePanel.Controls.Add(this.themeListConsolePanel);
            this.ConsolePanel.Location = new System.Drawing.Point(0, 0);
            this.ConsolePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(729, 197);
            this.ConsolePanel.TabIndex = 10;
            // 
            // ConsoleConsolePanel
            // 
            this.ConsoleConsolePanel.AutoSize = true;
            this.ConsoleConsolePanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.ConsoleConsolePanel.Location = new System.Drawing.Point(13, 136);
            this.ConsoleConsolePanel.Name = "ConsoleConsolePanel";
            this.ConsoleConsolePanel.Size = new System.Drawing.Size(87, 23);
            this.ConsoleConsolePanel.TabIndex = 17;
            this.ConsoleConsolePanel.Text = "Console";
            // 
            // autoScrollConsolePanel
            // 
            this.autoScrollConsolePanel.AutoSize = true;
            this.autoScrollConsolePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.autoScrollConsolePanel.Location = new System.Drawing.Point(18, 160);
            this.autoScrollConsolePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoScrollConsolePanel.Name = "autoScrollConsolePanel";
            this.autoScrollConsolePanel.Size = new System.Drawing.Size(129, 29);
            this.autoScrollConsolePanel.TabIndex = 16;
            this.autoScrollConsolePanel.Text = "Auto Scroll";
            this.autoScrollConsolePanel.UseVisualStyleBackColor = true;
            this.autoScrollConsolePanel.CheckedChanged += new System.EventHandler(this.autoScrollConsolePanel_CheckedChanged);
            // 
            // AutoStartConsolePanel
            // 
            this.AutoStartConsolePanel.AutoSize = true;
            this.AutoStartConsolePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AutoStartConsolePanel.Location = new System.Drawing.Point(18, 96);
            this.AutoStartConsolePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AutoStartConsolePanel.Name = "AutoStartConsolePanel";
            this.AutoStartConsolePanel.Size = new System.Drawing.Size(279, 29);
            this.AutoStartConsolePanel.TabIndex = 15;
            this.AutoStartConsolePanel.Text = "Auto Start Server on Startup";
            this.AutoStartConsolePanel.UseVisualStyleBackColor = true;
            this.AutoStartConsolePanel.CheckedChanged += new System.EventHandler(this.AutoStartConsolePanel_CheckedChanged);
            // 
            // Console
            // 
            this.Console.AutoSize = true;
            this.Console.Font = new System.Drawing.Font("Consolas", 16F);
            this.Console.Location = new System.Drawing.Point(0, 0);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(119, 32);
            this.Console.TabIndex = 9;
            this.Console.Text = "Console";
            // 
            // ThemeConsolePanel
            // 
            this.ThemeConsolePanel.AutoSize = true;
            this.ThemeConsolePanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.ThemeConsolePanel.Location = new System.Drawing.Point(13, 32);
            this.ThemeConsolePanel.Name = "ThemeConsolePanel";
            this.ThemeConsolePanel.Size = new System.Drawing.Size(65, 23);
            this.ThemeConsolePanel.TabIndex = 1;
            this.ThemeConsolePanel.Text = "Theme";
            // 
            // themeListConsolePanel
            // 
            this.themeListConsolePanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.themeListConsolePanel.FormattingEnabled = true;
            this.themeListConsolePanel.Location = new System.Drawing.Point(18, 56);
            this.themeListConsolePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.themeListConsolePanel.Name = "themeListConsolePanel";
            this.themeListConsolePanel.Size = new System.Drawing.Size(369, 31);
            this.themeListConsolePanel.TabIndex = 6;
            this.themeListConsolePanel.SelectedIndexChanged += new System.EventHandler(this.themeList_SelectedIndexChanged);
            // 
            // App
            // 
            this.App.Controls.Add(this.VersionPanel);
            this.App.Location = new System.Drawing.Point(4, 25);
            this.App.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.App.Name = "App";
            this.App.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.App.Size = new System.Drawing.Size(734, 502);
            this.App.TabIndex = 1;
            this.App.Text = "App";
            this.App.UseVisualStyleBackColor = true;
            // 
            // VersionPanel
            // 
            this.VersionPanel.Controls.Add(this.AutoUpdateAppPanel);
            this.VersionPanel.Controls.Add(this.Version);
            this.VersionPanel.Controls.Add(this.TypeVersionPanel);
            this.VersionPanel.Controls.Add(this.TypeListAppPanel);
            this.VersionPanel.Location = new System.Drawing.Point(0, 0);
            this.VersionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VersionPanel.Name = "VersionPanel";
            this.VersionPanel.Size = new System.Drawing.Size(729, 160);
            this.VersionPanel.TabIndex = 11;
            // 
            // AutoUpdateAppPanel
            // 
            this.AutoUpdateAppPanel.AutoSize = true;
            this.AutoUpdateAppPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AutoUpdateAppPanel.Location = new System.Drawing.Point(18, 96);
            this.AutoUpdateAppPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AutoUpdateAppPanel.Name = "AutoUpdateAppPanel";
            this.AutoUpdateAppPanel.Size = new System.Drawing.Size(143, 29);
            this.AutoUpdateAppPanel.TabIndex = 17;
            this.AutoUpdateAppPanel.Text = "Auto Update";
            this.AutoUpdateAppPanel.UseVisualStyleBackColor = true;
            this.AutoUpdateAppPanel.CheckedChanged += new System.EventHandler(this.AutoUpdateAppPanel_CheckedChanged);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Consolas", 16F);
            this.Version.Location = new System.Drawing.Point(0, 0);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(119, 32);
            this.Version.TabIndex = 9;
            this.Version.Text = "Version";
            // 
            // TypeVersionPanel
            // 
            this.TypeVersionPanel.AutoSize = true;
            this.TypeVersionPanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.TypeVersionPanel.Location = new System.Drawing.Point(13, 32);
            this.TypeVersionPanel.Name = "TypeVersionPanel";
            this.TypeVersionPanel.Size = new System.Drawing.Size(87, 23);
            this.TypeVersionPanel.TabIndex = 1;
            this.TypeVersionPanel.Text = "Release";
            // 
            // TypeListAppPanel
            // 
            this.TypeListAppPanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.TypeListAppPanel.FormattingEnabled = true;
            this.TypeListAppPanel.Location = new System.Drawing.Point(18, 56);
            this.TypeListAppPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeListAppPanel.Name = "TypeListAppPanel";
            this.TypeListAppPanel.Size = new System.Drawing.Size(369, 31);
            this.TypeListAppPanel.TabIndex = 6;
            this.TypeListAppPanel.SelectedIndexChanged += new System.EventHandler(this.TypeListConsolePanel_SelectedIndexChanged);
            // 
            // customThemeBtn
            // 
            this.customThemeBtn.Font = new System.Drawing.Font("Consolas", 8F);
            this.customThemeBtn.Location = new System.Drawing.Point(393, 57);
            this.customThemeBtn.Name = "customThemeBtn";
            this.customThemeBtn.Size = new System.Drawing.Size(166, 30);
            this.customThemeBtn.TabIndex = 18;
            this.customThemeBtn.Text = "Customize Theme";
            this.customThemeBtn.UseVisualStyleBackColor = true;
            this.customThemeBtn.Click += new System.EventHandler(this.customThemeBtn_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 531);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.CheckBox AutoStartConsolePanel;
        private System.Windows.Forms.CheckBox MaximizeStartupPanel;
        private System.Windows.Forms.TabPage App;
        private System.Windows.Forms.Panel VersionPanel;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label TypeVersionPanel;
        private System.Windows.Forms.ComboBox TypeListAppPanel;
        private System.Windows.Forms.Label ConsoleConsolePanel;
        private System.Windows.Forms.CheckBox autoScrollConsolePanel;
        private System.Windows.Forms.CheckBox AutoUpdateAppPanel;
        private System.Windows.Forms.CheckBox SpecificationsStartupPanel;
        private System.Windows.Forms.Button customThemeBtn;
    }
}