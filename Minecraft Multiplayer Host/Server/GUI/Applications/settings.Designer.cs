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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Theme");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Test");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Buttons", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Colour");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Appearance", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Default Tab");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Startup", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Appearance = new System.Windows.Forms.TabPage();
            this.themeList = new System.Windows.Forms.ComboBox();
            this.Spigot = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Test = new System.Windows.Forms.Label();
            this.Theme = new System.Windows.Forms.Label();
            this.Startup = new System.Windows.Forms.TabPage();
            this.SpigotBuildTools = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Appearance.SuspendLayout();
            this.Startup.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "themeList";
            treeNode1.Text = "Theme";
            treeNode2.Name = "Test";
            treeNode2.Text = "Test";
            treeNode3.Name = "AppearanceButtons";
            treeNode3.Text = "Buttons";
            treeNode4.Name = "AppearanceColour";
            treeNode4.Text = "Colour";
            treeNode5.Name = "Appearance";
            treeNode5.Text = "Appearance";
            treeNode6.Name = "StartupDefaultTab";
            treeNode6.Text = "Default Tab";
            treeNode7.Name = "Startup";
            treeNode7.Text = "Startup";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7});
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
            this.splitContainer1.Panel1.Controls.Add(this.saveBtn);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1258, 664);
            this.splitContainer1.SplitterDistance = 419;
            this.splitContainer1.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(3, 578);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(391, 74);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Appearance);
            this.tabControl1.Controls.Add(this.Startup);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 664);
            this.tabControl1.TabIndex = 0;
            // 
            // Appearance
            // 
            this.Appearance.AutoScroll = true;
            this.Appearance.Controls.Add(this.themeList);
            this.Appearance.Controls.Add(this.Spigot);
            this.Appearance.Controls.Add(this.textBox1);
            this.Appearance.Controls.Add(this.Test);
            this.Appearance.Controls.Add(this.Theme);
            this.Appearance.Location = new System.Drawing.Point(4, 29);
            this.Appearance.Name = "Appearance";
            this.Appearance.Padding = new System.Windows.Forms.Padding(3);
            this.Appearance.Size = new System.Drawing.Size(827, 631);
            this.Appearance.TabIndex = 0;
            this.Appearance.Text = "Appearance";
            this.Appearance.UseVisualStyleBackColor = true;
            // 
            // themeList
            // 
            this.themeList.FormattingEnabled = true;
            this.themeList.Location = new System.Drawing.Point(6, 26);
            this.themeList.Name = "themeList";
            this.themeList.Size = new System.Drawing.Size(415, 28);
            this.themeList.TabIndex = 6;
            this.themeList.SelectedIndexChanged += new System.EventHandler(this.themeList_SelectedIndexChanged);
            // 
            // Spigot
            // 
            this.Spigot.Location = new System.Drawing.Point(214, 402);
            this.Spigot.Name = "Spigot";
            this.Spigot.Size = new System.Drawing.Size(405, 26);
            this.Spigot.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // Test
            // 
            this.Test.AutoSize = true;
            this.Test.Location = new System.Drawing.Point(431, 5780);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(51, 20);
            this.Test.TabIndex = 2;
            this.Test.Text = "label1";
            // 
            // Theme
            // 
            this.Theme.AutoSize = true;
            this.Theme.Location = new System.Drawing.Point(6, 3);
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(65, 20);
            this.Theme.TabIndex = 1;
            this.Theme.Text = "Buttons";
            // 
            // Startup
            // 
            this.Startup.Controls.Add(this.SpigotBuildTools);
            this.Startup.Location = new System.Drawing.Point(4, 29);
            this.Startup.Name = "Startup";
            this.Startup.Padding = new System.Windows.Forms.Padding(3);
            this.Startup.Size = new System.Drawing.Size(827, 631);
            this.Startup.TabIndex = 1;
            this.Startup.Text = "Startup";
            this.Startup.UseVisualStyleBackColor = true;
            // 
            // SpigotBuildTools
            // 
            this.SpigotBuildTools.Location = new System.Drawing.Point(161, 302);
            this.SpigotBuildTools.Name = "SpigotBuildTools";
            this.SpigotBuildTools.Size = new System.Drawing.Size(505, 26);
            this.SpigotBuildTools.TabIndex = 5;
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
            this.Appearance.PerformLayout();
            this.Startup.ResumeLayout(false);
            this.Startup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Appearance;
        private System.Windows.Forms.TabPage Startup;
        private System.Windows.Forms.Label Theme;
        private System.Windows.Forms.Label Test;
        private System.Windows.Forms.TextBox Spigot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox SpigotBuildTools;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox themeList;
    }
}