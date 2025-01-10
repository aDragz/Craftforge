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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.applicationLbl = new System.Windows.Forms.Label();
            this.appearanceLbl = new System.Windows.Forms.Label();
            this.VersionPanel = new System.Windows.Forms.Panel();
            this.AutoUpdateAppPanel = new System.Windows.Forms.CheckBox();
            this.Version = new System.Windows.Forms.Label();
            this.TypeVersionPanel = new System.Windows.Forms.Label();
            this.TypeListAppPanel = new System.Windows.Forms.ComboBox();
            this.StartupPanel = new System.Windows.Forms.Panel();
            this.AutoCloseStartupPanel = new System.Windows.Forms.CheckBox();
            this.SpecificationsStartupPanel = new System.Windows.Forms.CheckBox();
            this.MaximizeStartupPanel = new System.Windows.Forms.CheckBox();
            this.Startup = new System.Windows.Forms.Label();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.warnStopServerConsolePanel = new System.Windows.Forms.CheckBox();
            this.customThemeBtn = new System.Windows.Forms.Button();
            this.ConsoleConsolePanel = new System.Windows.Forms.Label();
            this.autoScrollConsolePanel = new System.Windows.Forms.CheckBox();
            this.AutoStartConsolePanel = new System.Windows.Forms.CheckBox();
            this.Console = new System.Windows.Forms.Label();
            this.ThemeConsolePanel = new System.Windows.Forms.Label();
            this.themeListConsolePanel = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.VersionPanel.SuspendLayout();
            this.StartupPanel.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.applicationLbl);
            this.panel1.Controls.Add(this.appearanceLbl);
            this.panel1.Controls.Add(this.VersionPanel);
            this.panel1.Controls.Add(this.StartupPanel);
            this.panel1.Controls.Add(this.ConsolePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 531);
            this.panel1.TabIndex = 14;
            // 
            // applicationLbl
            // 
            this.applicationLbl.AutoSize = true;
            this.applicationLbl.Font = new System.Drawing.Font("Consolas", 20F);
            this.applicationLbl.Location = new System.Drawing.Point(3, 450);
            this.applicationLbl.Name = "applicationLbl";
            this.applicationLbl.Size = new System.Drawing.Size(226, 40);
            this.applicationLbl.TabIndex = 14;
            this.applicationLbl.Text = "Application";
            // 
            // appearanceLbl
            // 
            this.appearanceLbl.AutoSize = true;
            this.appearanceLbl.Font = new System.Drawing.Font("Consolas", 20F);
            this.appearanceLbl.Location = new System.Drawing.Point(3, 3);
            this.appearanceLbl.Name = "appearanceLbl";
            this.appearanceLbl.Size = new System.Drawing.Size(207, 40);
            this.appearanceLbl.TabIndex = 13;
            this.appearanceLbl.Text = "Appearance";
            // 
            // VersionPanel
            // 
            this.VersionPanel.Controls.Add(this.AutoUpdateAppPanel);
            this.VersionPanel.Controls.Add(this.Version);
            this.VersionPanel.Controls.Add(this.TypeVersionPanel);
            this.VersionPanel.Controls.Add(this.TypeListAppPanel);
            this.VersionPanel.Location = new System.Drawing.Point(25, 492);
            this.VersionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VersionPanel.Name = "VersionPanel";
            this.VersionPanel.Size = new System.Drawing.Size(1072, 160);
            this.VersionPanel.TabIndex = 12;
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
            // StartupPanel
            // 
            this.StartupPanel.Controls.Add(this.AutoCloseStartupPanel);
            this.StartupPanel.Controls.Add(this.SpecificationsStartupPanel);
            this.StartupPanel.Controls.Add(this.MaximizeStartupPanel);
            this.StartupPanel.Controls.Add(this.Startup);
            this.StartupPanel.Location = new System.Drawing.Point(25, 280);
            this.StartupPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartupPanel.Name = "StartupPanel";
            this.StartupPanel.Size = new System.Drawing.Size(1072, 164);
            this.StartupPanel.TabIndex = 11;
            // 
            // AutoCloseStartupPanel
            // 
            this.AutoCloseStartupPanel.AutoSize = true;
            this.AutoCloseStartupPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AutoCloseStartupPanel.Location = new System.Drawing.Point(18, 32);
            this.AutoCloseStartupPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AutoCloseStartupPanel.Name = "AutoCloseStartupPanel";
            this.AutoCloseStartupPanel.Size = new System.Drawing.Size(226, 29);
            this.AutoCloseStartupPanel.TabIndex = 18;
            this.AutoCloseStartupPanel.Text = "Close On Server Start";
            this.AutoCloseStartupPanel.UseVisualStyleBackColor = true;
            this.AutoCloseStartupPanel.CheckedChanged += new System.EventHandler(this.AutoCloseStartupPanel_CheckedChanged);
            // 
            // SpecificationsStartupPanel
            // 
            this.SpecificationsStartupPanel.AutoSize = true;
            this.SpecificationsStartupPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SpecificationsStartupPanel.Location = new System.Drawing.Point(18, 112);
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
            this.MaximizeStartupPanel.Location = new System.Drawing.Point(18, 72);
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
            this.ConsolePanel.Controls.Add(this.warnStopServerConsolePanel);
            this.ConsolePanel.Controls.Add(this.customThemeBtn);
            this.ConsolePanel.Controls.Add(this.ConsoleConsolePanel);
            this.ConsolePanel.Controls.Add(this.autoScrollConsolePanel);
            this.ConsolePanel.Controls.Add(this.AutoStartConsolePanel);
            this.ConsolePanel.Controls.Add(this.Console);
            this.ConsolePanel.Controls.Add(this.ThemeConsolePanel);
            this.ConsolePanel.Controls.Add(this.themeListConsolePanel);
            this.ConsolePanel.Location = new System.Drawing.Point(25, 45);
            this.ConsolePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(1072, 235);
            this.ConsolePanel.TabIndex = 10;
            // 
            // warnStopServerConsolePanel
            // 
            this.warnStopServerConsolePanel.AutoSize = true;
            this.warnStopServerConsolePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.warnStopServerConsolePanel.Location = new System.Drawing.Point(18, 200);
            this.warnStopServerConsolePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.warnStopServerConsolePanel.Name = "warnStopServerConsolePanel";
            this.warnStopServerConsolePanel.Size = new System.Drawing.Size(368, 29);
            this.warnStopServerConsolePanel.TabIndex = 19;
            this.warnStopServerConsolePanel.Text = "Warning Popup when Stopping Server";
            this.warnStopServerConsolePanel.UseVisualStyleBackColor = true;
            this.warnStopServerConsolePanel.CheckedChanged += new System.EventHandler(this.warnStopServer_CheckedChanged);
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
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 531);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1136, 578);
            this.MinimumSize = new System.Drawing.Size(1136, 578);
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.VersionPanel.ResumeLayout(false);
            this.VersionPanel.PerformLayout();
            this.StartupPanel.ResumeLayout(false);
            this.StartupPanel.PerformLayout();
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel VersionPanel;
        private System.Windows.Forms.CheckBox AutoUpdateAppPanel;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label TypeVersionPanel;
        private System.Windows.Forms.ComboBox TypeListAppPanel;
        private System.Windows.Forms.Panel StartupPanel;
        private System.Windows.Forms.CheckBox AutoCloseStartupPanel;
        private System.Windows.Forms.CheckBox SpecificationsStartupPanel;
        private System.Windows.Forms.CheckBox MaximizeStartupPanel;
        private System.Windows.Forms.Label Startup;
        private System.Windows.Forms.Panel ConsolePanel;
        private System.Windows.Forms.CheckBox warnStopServerConsolePanel;
        private System.Windows.Forms.Button customThemeBtn;
        private System.Windows.Forms.Label ConsoleConsolePanel;
        private System.Windows.Forms.CheckBox autoScrollConsolePanel;
        private System.Windows.Forms.CheckBox AutoStartConsolePanel;
        private System.Windows.Forms.Label Console;
        private System.Windows.Forms.Label ThemeConsolePanel;
        private System.Windows.Forms.ComboBox themeListConsolePanel;
        private System.Windows.Forms.Label applicationLbl;
        private System.Windows.Forms.Label appearanceLbl;
    }
}