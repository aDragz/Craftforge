namespace CraftForge.Server.StartPage.GUIs.Modern
{
    partial class CreateNewServerModern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewServerModern));
            this.panel2 = new System.Windows.Forms.Panel();
            this.motdTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.motdLbl = new System.Windows.Forms.Label();
            this.portLbl = new System.Windows.Forms.Label();
            this.IPAddressLbl = new System.Windows.Forms.Label();
            this.serverNameLbl = new System.Windows.Forms.Label();
            this.serverInformationLbl = new System.Windows.Forms.Label();
            this.playerCountLbl = new System.Windows.Forms.Label();
            this.cpuCoresLbl = new System.Windows.Forms.Label();
            this.playerCountNumber = new System.Windows.Forms.NumericUpDown();
            this.CPUCoresNumber = new System.Windows.Forms.NumericUpDown();
            this.ramNumber = new System.Windows.Forms.NumericUpDown();
            this.ramLbl = new System.Windows.Forms.Label();
            this.mbLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeSelector = new System.Windows.Forms.ComboBox();
            this.versionSelector = new System.Windows.Forms.ComboBox();
            this.buildSelector = new System.Windows.Forms.ComboBox();
            this.createServerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerCountNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUCoresNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.Location = new System.Drawing.Point(0, 1);
            this.titleBarPanel.Size = new System.Drawing.Size(800, 75);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 1);
            this.panel2.TabIndex = 11;
            // 
            // motdTextBox
            // 
            this.motdTextBox.Font = new System.Drawing.Font("Arial", 16F);
            this.motdTextBox.Location = new System.Drawing.Point(226, 257);
            this.motdTextBox.Name = "motdTextBox";
            this.motdTextBox.Size = new System.Drawing.Size(535, 32);
            this.motdTextBox.TabIndex = 30;
            this.motdTextBox.Text = "Created with CraftForge";
            // 
            // portTextBox
            // 
            this.portTextBox.Font = new System.Drawing.Font("Arial", 16F);
            this.portTextBox.Location = new System.Drawing.Point(226, 212);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(535, 32);
            this.portTextBox.TabIndex = 29;
            this.portTextBox.Text = "25565";
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Font = new System.Drawing.Font("Arial", 16F);
            this.ipAddressTextBox.Location = new System.Drawing.Point(226, 167);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(535, 32);
            this.ipAddressTextBox.TabIndex = 28;
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Font = new System.Drawing.Font("Arial", 16F);
            this.serverNameTextBox.Location = new System.Drawing.Point(226, 122);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(535, 32);
            this.serverNameTextBox.TabIndex = 27;
            this.serverNameTextBox.Text = "My Minecraft Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 22F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 35);
            this.label3.TabIndex = 26;
            this.label3.Text = "Resource Allocation";
            // 
            // motdLbl
            // 
            this.motdLbl.AutoSize = true;
            this.motdLbl.Font = new System.Drawing.Font("Arial", 16F);
            this.motdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(178)))));
            this.motdLbl.Location = new System.Drawing.Point(24, 259);
            this.motdLbl.Name = "motdLbl";
            this.motdLbl.Size = new System.Drawing.Size(90, 25);
            this.motdLbl.TabIndex = 25;
            this.motdLbl.Text = "MOTD: ";
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Font = new System.Drawing.Font("Arial", 16F);
            this.portLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(178)))));
            this.portLbl.Location = new System.Drawing.Point(24, 214);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(59, 25);
            this.portLbl.TabIndex = 24;
            this.portLbl.Text = "Port:";
            // 
            // IPAddressLbl
            // 
            this.IPAddressLbl.AutoSize = true;
            this.IPAddressLbl.Font = new System.Drawing.Font("Arial", 16F);
            this.IPAddressLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(178)))));
            this.IPAddressLbl.Location = new System.Drawing.Point(24, 169);
            this.IPAddressLbl.Name = "IPAddressLbl";
            this.IPAddressLbl.Size = new System.Drawing.Size(124, 25);
            this.IPAddressLbl.TabIndex = 23;
            this.IPAddressLbl.Text = "IP Address:";
            // 
            // serverNameLbl
            // 
            this.serverNameLbl.AutoSize = true;
            this.serverNameLbl.Font = new System.Drawing.Font("Arial", 16F);
            this.serverNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(178)))));
            this.serverNameLbl.Location = new System.Drawing.Point(24, 124);
            this.serverNameLbl.Name = "serverNameLbl";
            this.serverNameLbl.Size = new System.Drawing.Size(146, 25);
            this.serverNameLbl.TabIndex = 22;
            this.serverNameLbl.Text = "Server Name:";
            // 
            // serverInformationLbl
            // 
            this.serverInformationLbl.AutoSize = true;
            this.serverInformationLbl.Font = new System.Drawing.Font("Arial", 22F);
            this.serverInformationLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.serverInformationLbl.Location = new System.Drawing.Point(12, 79);
            this.serverInformationLbl.Name = "serverInformationLbl";
            this.serverInformationLbl.Size = new System.Drawing.Size(257, 35);
            this.serverInformationLbl.TabIndex = 21;
            this.serverInformationLbl.Text = "Server Information";
            // 
            // playerCountLbl
            // 
            this.playerCountLbl.AutoSize = true;
            this.playerCountLbl.Font = new System.Drawing.Font("Arial", 16F);
            this.playerCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(178)))));
            this.playerCountLbl.Location = new System.Drawing.Point(24, 349);
            this.playerCountLbl.Name = "playerCountLbl";
            this.playerCountLbl.Size = new System.Drawing.Size(142, 25);
            this.playerCountLbl.TabIndex = 31;
            this.playerCountLbl.Text = "Player Count:";
            // 
            // cpuCoresLbl
            // 
            this.cpuCoresLbl.AutoSize = true;
            this.cpuCoresLbl.Font = new System.Drawing.Font("Arial", 16F);
            this.cpuCoresLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(178)))));
            this.cpuCoresLbl.Location = new System.Drawing.Point(24, 394);
            this.cpuCoresLbl.Name = "cpuCoresLbl";
            this.cpuCoresLbl.Size = new System.Drawing.Size(130, 25);
            this.cpuCoresLbl.TabIndex = 32;
            this.cpuCoresLbl.Text = "CPU Cores:";
            // 
            // playerCountNumber
            // 
            this.playerCountNumber.Font = new System.Drawing.Font("Arial", 16F);
            this.playerCountNumber.Location = new System.Drawing.Point(226, 347);
            this.playerCountNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.playerCountNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playerCountNumber.Name = "playerCountNumber";
            this.playerCountNumber.Size = new System.Drawing.Size(77, 32);
            this.playerCountNumber.TabIndex = 34;
            this.playerCountNumber.ThousandsSeparator = true;
            this.playerCountNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // CPUCoresNumber
            // 
            this.CPUCoresNumber.Font = new System.Drawing.Font("Arial", 16F);
            this.CPUCoresNumber.Location = new System.Drawing.Point(226, 394);
            this.CPUCoresNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CPUCoresNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CPUCoresNumber.Name = "CPUCoresNumber";
            this.CPUCoresNumber.Size = new System.Drawing.Size(77, 32);
            this.CPUCoresNumber.TabIndex = 35;
            this.CPUCoresNumber.ThousandsSeparator = true;
            this.CPUCoresNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ramNumber
            // 
            this.ramNumber.Font = new System.Drawing.Font("Arial", 16F);
            this.ramNumber.Increment = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.ramNumber.Location = new System.Drawing.Point(529, 394);
            this.ramNumber.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ramNumber.Minimum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.ramNumber.Name = "ramNumber";
            this.ramNumber.Size = new System.Drawing.Size(89, 32);
            this.ramNumber.TabIndex = 37;
            this.ramNumber.ThousandsSeparator = true;
            this.ramNumber.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // ramLbl
            // 
            this.ramLbl.AutoSize = true;
            this.ramLbl.Font = new System.Drawing.Font("Arial", 16F);
            this.ramLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(178)))));
            this.ramLbl.Location = new System.Drawing.Point(327, 394);
            this.ramLbl.Name = "ramLbl";
            this.ramLbl.Size = new System.Drawing.Size(197, 50);
            this.ramLbl.TabIndex = 36;
            this.ramLbl.Text = "Memory Allocation:\n\n";
            // 
            // mbLabel
            // 
            this.mbLabel.AutoSize = true;
            this.mbLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.mbLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(178)))));
            this.mbLabel.Location = new System.Drawing.Point(620, 400);
            this.mbLabel.Name = "mbLabel";
            this.mbLabel.Size = new System.Drawing.Size(46, 25);
            this.mbLabel.TabIndex = 38;
            this.mbLabel.Text = "MB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 22F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label7.Location = new System.Drawing.Point(12, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(306, 35);
            this.label7.TabIndex = 39;
            this.label7.Text = "Server Jar Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(24, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Build:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(24, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(178)))));
            this.label4.Location = new System.Drawing.Point(24, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Software:";
            // 
            // typeSelector
            // 
            this.typeSelector.Font = new System.Drawing.Font("Arial", 16F);
            this.typeSelector.FormattingEnabled = true;
            this.typeSelector.Items.AddRange(new object[] {
            "Custom",
            "Paper",
            "Spigot",
            "Velocity",
            "Waterfall"});
            this.typeSelector.Location = new System.Drawing.Point(226, 482);
            this.typeSelector.Name = "typeSelector";
            this.typeSelector.Size = new System.Drawing.Size(230, 32);
            this.typeSelector.TabIndex = 46;
            this.typeSelector.Text = "Custom";
            this.typeSelector.SelectedIndexChanged += new System.EventHandler(this.typeSelector_SelectedIndexChanged);
            // 
            // versionSelector
            // 
            this.versionSelector.Font = new System.Drawing.Font("Arial", 16F);
            this.versionSelector.FormattingEnabled = true;
            this.versionSelector.Location = new System.Drawing.Point(226, 527);
            this.versionSelector.Name = "versionSelector";
            this.versionSelector.Size = new System.Drawing.Size(230, 32);
            this.versionSelector.TabIndex = 47;
            this.versionSelector.SelectedIndexChanged += new System.EventHandler(this.versionSelector_SelectedIndexChanged);
            // 
            // buildSelector
            // 
            this.buildSelector.Font = new System.Drawing.Font("Arial", 16F);
            this.buildSelector.FormattingEnabled = true;
            this.buildSelector.Location = new System.Drawing.Point(226, 572);
            this.buildSelector.Name = "buildSelector";
            this.buildSelector.Size = new System.Drawing.Size(230, 32);
            this.buildSelector.TabIndex = 48;
            // 
            // createServerBtn
            // 
            this.createServerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.createServerBtn.Font = new System.Drawing.Font("Arial", 16F);
            this.createServerBtn.Location = new System.Drawing.Point(587, 545);
            this.createServerBtn.Name = "createServerBtn";
            this.createServerBtn.Size = new System.Drawing.Size(174, 59);
            this.createServerBtn.TabIndex = 49;
            this.createServerBtn.Text = "Create New Server";
            this.createServerBtn.UseVisualStyleBackColor = false;
            this.createServerBtn.Click += new System.EventHandler(this.createServerBtn_Click);
            // 
            // CreateNewServerModern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.createServerBtn);
            this.Controls.Add(this.buildSelector);
            this.Controls.Add(this.versionSelector);
            this.Controls.Add(this.typeSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mbLabel);
            this.Controls.Add(this.ramNumber);
            this.Controls.Add(this.ramLbl);
            this.Controls.Add(this.CPUCoresNumber);
            this.Controls.Add(this.playerCountNumber);
            this.Controls.Add(this.cpuCoresLbl);
            this.Controls.Add(this.playerCountLbl);
            this.Controls.Add(this.motdTextBox);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.ipAddressTextBox);
            this.Controls.Add(this.serverNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.motdLbl);
            this.Controls.Add(this.portLbl);
            this.Controls.Add(this.IPAddressLbl);
            this.Controls.Add(this.serverNameLbl);
            this.Controls.Add(this.serverInformationLbl);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewServerModern";
            this.Text = "CreateNewServerModern";
            this.Load += new System.EventHandler(this.CreateNewServerModern_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.serverInformationLbl, 0);
            this.Controls.SetChildIndex(this.serverNameLbl, 0);
            this.Controls.SetChildIndex(this.IPAddressLbl, 0);
            this.Controls.SetChildIndex(this.portLbl, 0);
            this.Controls.SetChildIndex(this.motdLbl, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.serverNameTextBox, 0);
            this.Controls.SetChildIndex(this.ipAddressTextBox, 0);
            this.Controls.SetChildIndex(this.portTextBox, 0);
            this.Controls.SetChildIndex(this.motdTextBox, 0);
            this.Controls.SetChildIndex(this.playerCountLbl, 0);
            this.Controls.SetChildIndex(this.cpuCoresLbl, 0);
            this.Controls.SetChildIndex(this.playerCountNumber, 0);
            this.Controls.SetChildIndex(this.titleBarPanel, 0);
            this.Controls.SetChildIndex(this.CPUCoresNumber, 0);
            this.Controls.SetChildIndex(this.ramLbl, 0);
            this.Controls.SetChildIndex(this.ramNumber, 0);
            this.Controls.SetChildIndex(this.mbLabel, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.typeSelector, 0);
            this.Controls.SetChildIndex(this.versionSelector, 0);
            this.Controls.SetChildIndex(this.buildSelector, 0);
            this.Controls.SetChildIndex(this.createServerBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.playerCountNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUCoresNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox motdTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label motdLbl;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.Label IPAddressLbl;
        private System.Windows.Forms.Label serverNameLbl;
        private System.Windows.Forms.Label serverInformationLbl;
        private System.Windows.Forms.Label playerCountLbl;
        private System.Windows.Forms.Label cpuCoresLbl;
        private System.Windows.Forms.NumericUpDown playerCountNumber;
        private System.Windows.Forms.NumericUpDown CPUCoresNumber;
        private System.Windows.Forms.NumericUpDown ramNumber;
        private System.Windows.Forms.Label ramLbl;
        private System.Windows.Forms.Label mbLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typeSelector;
        private System.Windows.Forms.ComboBox versionSelector;
        private System.Windows.Forms.ComboBox buildSelector;
        private System.Windows.Forms.Button createServerBtn;
    }
}