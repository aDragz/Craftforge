namespace CraftForge.Server.GUI.Setup
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
            this.typeLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buildLbl = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(516, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "MOTD";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(530, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(492, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "IP Address";
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameLbl.Location = new System.Drawing.Point(480, 7);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(155, 29);
            this.nameLbl.TabIndex = 18;
            this.nameLbl.Text = "Server Name";
            // 
            // motdTextBox
            // 
            this.motdTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.motdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.motdTextBox.Location = new System.Drawing.Point(94, 240);
            this.motdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.motdTextBox.Name = "motdTextBox";
            this.motdTextBox.Size = new System.Drawing.Size(930, 34);
            this.motdTextBox.TabIndex = 16;
            this.motdTextBox.Text = "My Minecraft Server";
            this.motdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IpTextBox
            // 
            this.IpTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.IpTextBox.Location = new System.Drawing.Point(439, 105);
            this.IpTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(241, 34);
            this.IpTextBox.TabIndex = 15;
            this.IpTextBox.Text = "localhost";
            this.IpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // versionSelector
            // 
            this.versionSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.versionSelector.Font = new System.Drawing.Font("Consolas", 12F);
            this.versionSelector.FormattingEnabled = true;
            this.versionSelector.Location = new System.Drawing.Point(864, 370);
            this.versionSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.versionSelector.Name = "versionSelector";
            this.versionSelector.Size = new System.Drawing.Size(243, 31);
            this.versionSelector.TabIndex = 13;
            this.versionSelector.SelectedIndexChanged += new System.EventHandler(this.versionSelector_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameTextBox.Location = new System.Drawing.Point(437, 37);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.MaxLength = 150;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(245, 34);
            this.nameTextBox.TabIndex = 17;
            this.nameTextBox.Text = "Server";
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // typeSelector
            // 
            this.typeSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.typeSelector.Font = new System.Drawing.Font("Consolas", 12F);
            this.typeSelector.FormattingEnabled = true;
            this.typeSelector.Items.AddRange(new object[] {
            "Paper",
            "Velocity",
            "Waterfall",
            "Custom"});
            this.typeSelector.Location = new System.Drawing.Point(864, 336);
            this.typeSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeSelector.Name = "typeSelector";
            this.typeSelector.Size = new System.Drawing.Size(243, 31);
            this.typeSelector.TabIndex = 12;
            this.typeSelector.Text = "Paper";
            this.typeSelector.SelectedIndexChanged += new System.EventHandler(this.typeSelector_SelectedIndexChanged);
            // 
            // portTextBox
            // 
            this.portTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.portTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.portTextBox.Location = new System.Drawing.Point(515, 172);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portTextBox.MaxLength = 5;
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(89, 34);
            this.portTextBox.TabIndex = 14;
            this.portTextBox.Text = "25565";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createButton.Location = new System.Drawing.Point(937, 441);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(170, 59);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 28);
            this.contextMenuStrip1.Text = "Exit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buildSelector
            // 
            this.buildSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buildSelector.Enabled = false;
            this.buildSelector.Font = new System.Drawing.Font("Consolas", 12F);
            this.buildSelector.FormattingEnabled = true;
            this.buildSelector.Location = new System.Drawing.Point(864, 406);
            this.buildSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buildSelector.Name = "buildSelector";
            this.buildSelector.Size = new System.Drawing.Size(243, 31);
            this.buildSelector.TabIndex = 23;
            // 
            // typeLbl
            // 
            this.typeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.typeLbl.Location = new System.Drawing.Point(788, 339);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(65, 23);
            this.typeLbl.TabIndex = 24;
            this.typeLbl.Text = "Type:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F);
            this.label4.Location = new System.Drawing.Point(755, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Version:";
            // 
            // buildLbl
            // 
            this.buildLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buildLbl.AutoSize = true;
            this.buildLbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.buildLbl.Location = new System.Drawing.Point(777, 409);
            this.buildLbl.Name = "buildLbl";
            this.buildLbl.Size = new System.Drawing.Size(76, 23);
            this.buildLbl.TabIndex = 26;
            this.buildLbl.Text = "Build:";
            // 
            // CreateNewServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 538);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.buildLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeLbl);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1140, 585);
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
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label buildLbl;
    }
}