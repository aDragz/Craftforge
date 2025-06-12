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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14F);
            this.label3.Location = new System.Drawing.Point(11, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "MOTD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14F);
            this.label2.Location = new System.Drawing.Point(11, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F);
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "IP Address";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Consolas", 14F);
            this.nameLbl.Location = new System.Drawing.Point(11, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(180, 33);
            this.nameLbl.TabIndex = 18;
            this.nameLbl.Text = "Server Name";
            // 
            // motdTextBox
            // 
            this.motdTextBox.Font = new System.Drawing.Font("Consolas", 14F);
            this.motdTextBox.Location = new System.Drawing.Point(196, 166);
            this.motdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.motdTextBox.Name = "motdTextBox";
            this.motdTextBox.Size = new System.Drawing.Size(526, 40);
            this.motdTextBox.TabIndex = 16;
            this.motdTextBox.Text = "My Minecraft Server";
            this.motdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IpTextBox
            // 
            this.IpTextBox.Font = new System.Drawing.Font("Consolas", 14F);
            this.IpTextBox.Location = new System.Drawing.Point(196, 56);
            this.IpTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(526, 40);
            this.IpTextBox.TabIndex = 15;
            this.IpTextBox.Text = "localhost";
            this.IpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // versionSelector
            // 
            this.versionSelector.Font = new System.Drawing.Font("Consolas", 14F);
            this.versionSelector.FormattingEnabled = true;
            this.versionSelector.Location = new System.Drawing.Point(196, 56);
            this.versionSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.versionSelector.Name = "versionSelector";
            this.versionSelector.Size = new System.Drawing.Size(273, 41);
            this.versionSelector.TabIndex = 13;
            this.versionSelector.SelectedIndexChanged += new System.EventHandler(this.versionSelector_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Consolas", 14F);
            this.nameTextBox.Location = new System.Drawing.Point(196, 6);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.MaxLength = 150;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(526, 40);
            this.nameTextBox.TabIndex = 17;
            this.nameTextBox.Text = "Server";
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // typeSelector
            // 
            this.typeSelector.Font = new System.Drawing.Font("Consolas", 14F);
            this.typeSelector.FormattingEnabled = true;
            this.typeSelector.Items.AddRange(new object[] {
            "Paper",
            "Spigot",
            "Velocity",
            "Waterfall",
            "Custom"});
            this.typeSelector.Location = new System.Drawing.Point(196, 6);
            this.typeSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeSelector.Name = "typeSelector";
            this.typeSelector.Size = new System.Drawing.Size(273, 41);
            this.typeSelector.TabIndex = 12;
            this.typeSelector.Text = "Paper";
            this.typeSelector.SelectedIndexChanged += new System.EventHandler(this.typeSelector_SelectedIndexChanged);
            // 
            // portTextBox
            // 
            this.portTextBox.Font = new System.Drawing.Font("Consolas", 14F);
            this.portTextBox.Location = new System.Drawing.Point(196, 106);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portTextBox.MaxLength = 5;
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 40);
            this.portTextBox.TabIndex = 14;
            this.portTextBox.Text = "25565";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createButton.Location = new System.Drawing.Point(1030, 566);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(220, 95);
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
            this.buildSelector.Font = new System.Drawing.Font("Consolas", 14F);
            this.buildSelector.FormattingEnabled = true;
            this.buildSelector.Location = new System.Drawing.Point(196, 106);
            this.buildSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buildSelector.Name = "buildSelector";
            this.buildSelector.Size = new System.Drawing.Size(273, 41);
            this.buildSelector.TabIndex = 23;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Consolas", 14F);
            this.typeLbl.Location = new System.Drawing.Point(11, 9);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(150, 33);
            this.typeLbl.TabIndex = 24;
            this.typeLbl.Text = "Software:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14F);
            this.label4.Location = new System.Drawing.Point(11, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 33);
            this.label4.TabIndex = 25;
            this.label4.Text = "Version:";
            // 
            // buildLbl
            // 
            this.buildLbl.AutoSize = true;
            this.buildLbl.Font = new System.Drawing.Font("Consolas", 14F);
            this.buildLbl.Location = new System.Drawing.Point(11, 109);
            this.buildLbl.Name = "buildLbl";
            this.buildLbl.Size = new System.Drawing.Size(105, 33);
            this.buildLbl.TabIndex = 26;
            this.buildLbl.Text = "Build:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IpTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.portTextBox);
            this.panel1.Controls.Add(this.motdTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(5, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 219);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 0);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.typeLbl);
            this.panel3.Controls.Add(this.typeSelector);
            this.panel3.Controls.Add(this.versionSelector);
            this.panel3.Controls.Add(this.buildLbl);
            this.panel3.Controls.Add(this.buildSelector);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(6, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 160);
            this.panel3.TabIndex = 28;
            // 
            // CreateNewServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 672);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1284, 728);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1284, 728);
            this.Name = "CreateNewServer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewServer";
            this.Load += new System.EventHandler(this.CreateNewServer_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}