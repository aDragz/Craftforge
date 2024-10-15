namespace Minecraft_Multiplayer_Host.Server.GUI.Setup
{
    partial class CreateNewServer
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.motdTextBox = new System.Windows.Forms.TextBox();
            this.IpTextBox = new System.Windows.Forms.TextBox();
            this.versionSelector = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeSelector = new System.Windows.Forms.ComboBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildSelector = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(581, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "MOTD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(596, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(554, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "IP Address";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameLbl.Location = new System.Drawing.Point(540, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(179, 32);
            this.nameLbl.TabIndex = 18;
            this.nameLbl.Text = "Server Name";
            // 
            // motdTextBox
            // 
            this.motdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.motdTextBox.Location = new System.Drawing.Point(106, 290);
            this.motdTextBox.Name = "motdTextBox";
            this.motdTextBox.Size = new System.Drawing.Size(1046, 39);
            this.motdTextBox.TabIndex = 16;
            this.motdTextBox.Text = "motd";
            this.motdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IpTextBox
            // 
            this.IpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.IpTextBox.Location = new System.Drawing.Point(494, 126);
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(271, 39);
            this.IpTextBox.TabIndex = 15;
            this.IpTextBox.Text = "localhost";
            this.IpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // versionSelector
            // 
            this.versionSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.versionSelector.FormattingEnabled = true;
            this.versionSelector.Items.AddRange(new object[] {
            "1.10",
            "1.11",
            "1.12.2",
            "1.13",
            "1.14",
            "1.15",
            "1.16.5",
            "1.17",
            "1.18",
            "1.19.2",
            "1.19.4",
            "1.20",
            "1.20.6",
            "1.21",
            "1.21.1",
            "1.8.9",
            "1.9"});
            this.versionSelector.Location = new System.Drawing.Point(972, 463);
            this.versionSelector.Name = "versionSelector";
            this.versionSelector.Size = new System.Drawing.Size(273, 37);
            this.versionSelector.TabIndex = 13;
            this.versionSelector.SelectedIndexChanged += new System.EventHandler(this.versionSelector_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameTextBox.Location = new System.Drawing.Point(492, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(275, 39);
            this.nameTextBox.TabIndex = 17;
            this.nameTextBox.Text = "Server";
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // typeSelector
            // 
            this.typeSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typeSelector.FormattingEnabled = true;
            this.typeSelector.Items.AddRange(new object[] {
            "Paper",
            "Velocity",
            "Waterfall",
            "Custom"});
            this.typeSelector.Location = new System.Drawing.Point(972, 420);
            this.typeSelector.Name = "typeSelector";
            this.typeSelector.Size = new System.Drawing.Size(273, 37);
            this.typeSelector.TabIndex = 12;
            this.typeSelector.Text = "Paper";
            this.typeSelector.SelectedIndexChanged += new System.EventHandler(this.typeSelector_SelectedIndexChanged);
            // 
            // portTextBox
            // 
            this.portTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.portTextBox.Location = new System.Drawing.Point(579, 208);
            this.portTextBox.MaxLength = 5;
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 39);
            this.portTextBox.TabIndex = 14;
            this.portTextBox.Text = "25565";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createButton.Location = new System.Drawing.Point(1054, 551);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(191, 74);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "Download Server Jar";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 36);
            this.contextMenuStrip1.Text = "Exit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buildSelector
            // 
            this.buildSelector.Enabled = false;
            this.buildSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buildSelector.FormattingEnabled = true;
            this.buildSelector.Location = new System.Drawing.Point(972, 508);
            this.buildSelector.Name = "buildSelector";
            this.buildSelector.Size = new System.Drawing.Size(273, 37);
            this.buildSelector.TabIndex = 23;
            // 
            // CreateNewServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.buildSelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.motdTextBox);
            this.Controls.Add(this.IpTextBox);
            this.Controls.Add(this.versionSelector);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.typeSelector);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.createButton);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "CreateNewServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewServer";
            this.Load += new System.EventHandler(this.CreateNewServer_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox motdTextBox;
        private System.Windows.Forms.TextBox IpTextBox;
        private System.Windows.Forms.ComboBox versionSelector;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox typeSelector;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox buildSelector;
    }
}