namespace Minecraft_Multiplayer_Host.Server.GUI.Applications
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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Buttons");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Theme", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Maximize");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Console", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Maximize");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Startup", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Appearance", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode23});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Appearance = new System.Windows.Forms.TabPage();
            this.StartupPanel = new System.Windows.Forms.Panel();
            this.Startup = new System.Windows.Forms.Label();
            this.MaximizeStartupPanel = new System.Windows.Forms.Label();
            this.MaximizedListStartupPanel = new System.Windows.Forms.ComboBox();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.AutoStartListConsolePanel = new System.Windows.Forms.ComboBox();
            this.AutoStartConsolePanel = new System.Windows.Forms.Label();
            this.MaximizeConsolePanel = new System.Windows.Forms.Label();
            this.maximizedListConsolePanel = new System.Windows.Forms.ComboBox();
            this.Console = new System.Windows.Forms.Label();
            this.ThemeConsolePanel = new System.Windows.Forms.Label();
            this.themeListConsolePanel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Appearance.SuspendLayout();
            this.StartupPanel.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode17.Name = "AppearanceButtons";
            treeNode17.Text = "Buttons";
            treeNode18.Name = "themeList";
            treeNode18.Text = "Theme";
            treeNode19.Name = "MaximizeConsole";
            treeNode19.Text = "Maximize";
            treeNode20.Name = "Node1";
            treeNode20.Text = "Console";
            treeNode21.Name = "Node1";
            treeNode21.Text = "Maximize";
            treeNode22.Name = "Node2";
            treeNode22.Text = "Node2";
            treeNode23.Name = "StartupNode";
            treeNode23.Text = "Startup";
            treeNode24.Name = "Appearance";
            treeNode24.Text = "Appearance";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24});
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
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1258, 664);
            this.splitContainer1.SplitterDistance = 419;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Appearance);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 664);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
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
            this.StartupPanel.Controls.Add(this.Startup);
            this.StartupPanel.Controls.Add(this.MaximizeStartupPanel);
            this.StartupPanel.Controls.Add(this.MaximizedListStartupPanel);
            this.StartupPanel.Location = new System.Drawing.Point(0, 285);
            this.StartupPanel.Name = "StartupPanel";
            this.StartupPanel.Size = new System.Drawing.Size(820, 130);
            this.StartupPanel.TabIndex = 11;
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
            // MaximizeStartupPanel
            // 
            this.MaximizeStartupPanel.AutoSize = true;
            this.MaximizeStartupPanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.MaximizeStartupPanel.Location = new System.Drawing.Point(15, 40);
            this.MaximizeStartupPanel.Name = "MaximizeStartupPanel";
            this.MaximizeStartupPanel.Size = new System.Drawing.Size(259, 28);
            this.MaximizeStartupPanel.TabIndex = 1;
            this.MaximizeStartupPanel.Text = "Maximize on Startup";
            // 
            // MaximizedListStartupPanel
            // 
            this.MaximizedListStartupPanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.MaximizedListStartupPanel.FormattingEnabled = true;
            this.MaximizedListStartupPanel.Items.AddRange(new object[] {
            "True",
            "False"});
            this.MaximizedListStartupPanel.Location = new System.Drawing.Point(20, 70);
            this.MaximizedListStartupPanel.Name = "MaximizedListStartupPanel";
            this.MaximizedListStartupPanel.Size = new System.Drawing.Size(415, 36);
            this.MaximizedListStartupPanel.TabIndex = 6;
            this.MaximizedListStartupPanel.SelectedIndexChanged += new System.EventHandler(this.maximizedOnStartup_SelectedIndexChanged);
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.Controls.Add(this.AutoStartListConsolePanel);
            this.ConsolePanel.Controls.Add(this.AutoStartConsolePanel);
            this.ConsolePanel.Controls.Add(this.MaximizeConsolePanel);
            this.ConsolePanel.Controls.Add(this.maximizedListConsolePanel);
            this.ConsolePanel.Controls.Add(this.Console);
            this.ConsolePanel.Controls.Add(this.ThemeConsolePanel);
            this.ConsolePanel.Controls.Add(this.themeListConsolePanel);
            this.ConsolePanel.Location = new System.Drawing.Point(0, 0);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(820, 280);
            this.ConsolePanel.TabIndex = 10;
            // 
            // AutoStartListConsolePanel
            // 
            this.AutoStartListConsolePanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.AutoStartListConsolePanel.FormattingEnabled = true;
            this.AutoStartListConsolePanel.Items.AddRange(new object[] {
            "True",
            "False"});
            this.AutoStartListConsolePanel.Location = new System.Drawing.Point(20, 230);
            this.AutoStartListConsolePanel.Name = "AutoStartListConsolePanel";
            this.AutoStartListConsolePanel.Size = new System.Drawing.Size(415, 36);
            this.AutoStartListConsolePanel.TabIndex = 13;
            this.AutoStartListConsolePanel.SelectedIndexChanged += new System.EventHandler(this.AutoStartListConsolePanel_SelectedIndexChanged);
            // 
            // AutoStartConsolePanel
            // 
            this.AutoStartConsolePanel.AutoSize = true;
            this.AutoStartConsolePanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.AutoStartConsolePanel.Location = new System.Drawing.Point(15, 200);
            this.AutoStartConsolePanel.Name = "AutoStartConsolePanel";
            this.AutoStartConsolePanel.Size = new System.Drawing.Size(220, 28);
            this.AutoStartConsolePanel.TabIndex = 12;
            this.AutoStartConsolePanel.Text = "Autostart Server";
            // 
            // MaximizeConsolePanel
            // 
            this.MaximizeConsolePanel.AutoSize = true;
            this.MaximizeConsolePanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.MaximizeConsolePanel.Location = new System.Drawing.Point(15, 120);
            this.MaximizeConsolePanel.Name = "MaximizeConsolePanel";
            this.MaximizeConsolePanel.Size = new System.Drawing.Size(259, 28);
            this.MaximizeConsolePanel.TabIndex = 10;
            this.MaximizeConsolePanel.Text = "Maximize on Startup";
            // 
            // maximizedListConsolePanel
            // 
            this.maximizedListConsolePanel.Font = new System.Drawing.Font("Consolas", 12F);
            this.maximizedListConsolePanel.FormattingEnabled = true;
            this.maximizedListConsolePanel.Items.AddRange(new object[] {
            "True",
            "False"});
            this.maximizedListConsolePanel.Location = new System.Drawing.Point(20, 150);
            this.maximizedListConsolePanel.Name = "maximizedListConsolePanel";
            this.maximizedListConsolePanel.Size = new System.Drawing.Size(415, 36);
            this.maximizedListConsolePanel.TabIndex = 11;
            this.maximizedListConsolePanel.SelectedIndexChanged += new System.EventHandler(this.maximizedListConsolePanel_SelectedIndexChanged);
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
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.splitContainer1);
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Appearance.ResumeLayout(false);
            this.StartupPanel.ResumeLayout(false);
            this.StartupPanel.PerformLayout();
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Appearance;
        private System.Windows.Forms.Label ThemeConsolePanel;
        private System.Windows.Forms.ComboBox themeListConsolePanel;
        private System.Windows.Forms.Label Console;
        private System.Windows.Forms.Panel ConsolePanel;
        private System.Windows.Forms.Panel StartupPanel;
        private System.Windows.Forms.Label MaximizeStartupPanel;
        private System.Windows.Forms.ComboBox MaximizedListStartupPanel;
        private System.Windows.Forms.Label Startup;
        private System.Windows.Forms.Label MaximizeConsolePanel;
        private System.Windows.Forms.ComboBox maximizedListConsolePanel;
        private System.Windows.Forms.Label AutoStartConsolePanel;
        private System.Windows.Forms.ComboBox AutoStartListConsolePanel;
    }
}