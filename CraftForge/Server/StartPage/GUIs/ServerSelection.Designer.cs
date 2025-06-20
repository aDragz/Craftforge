namespace CraftForge.Server.GUI.Setup
{
    partial class Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.createNewServerLbl = new System.Windows.Forms.Label();
            this.systemSpecsLbl = new System.Windows.Forms.Label();
            this.settingsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.Size = new System.Drawing.Size(1286, 75);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLbl.Font = new System.Drawing.Font("Consolas", 24F);
            this.welcomeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.welcomeLbl.Location = new System.Drawing.Point(654, 79);
            this.welcomeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(603, 108);
            this.welcomeLbl.TabIndex = 1;
            this.welcomeLbl.Text = "CraftForge";
            this.welcomeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createNewServerLbl
            // 
            this.createNewServerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createNewServerLbl.AutoSize = true;
            this.createNewServerLbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.createNewServerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.createNewServerLbl.Location = new System.Drawing.Point(1102, 683);
            this.createNewServerLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createNewServerLbl.Name = "createNewServerLbl";
            this.createNewServerLbl.Size = new System.Drawing.Size(162, 19);
            this.createNewServerLbl.TabIndex = 2;
            this.createNewServerLbl.Text = "Create New Server";
            this.createNewServerLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // systemSpecsLbl
            // 
            this.systemSpecsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.systemSpecsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.systemSpecsLbl.Location = new System.Drawing.Point(660, 600);
            this.systemSpecsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.systemSpecsLbl.Name = "systemSpecsLbl";
            this.systemSpecsLbl.Size = new System.Drawing.Size(442, 110);
            this.systemSpecsLbl.TabIndex = 3;
            this.systemSpecsLbl.Text = "System Specifications";
            this.systemSpecsLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // settingsLbl
            // 
            this.settingsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsLbl.AutoSize = true;
            this.settingsLbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.settingsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.settingsLbl.Location = new System.Drawing.Point(1176, 660);
            this.settingsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.settingsLbl.Name = "settingsLbl";
            this.settingsLbl.Size = new System.Drawing.Size(81, 19);
            this.settingsLbl.TabIndex = 4;
            this.settingsLbl.Text = "Settings";
            this.settingsLbl.Click += new System.EventHandler(this.settingsLbl_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1286, 717);
            this.Controls.Add(this.settingsLbl);
            this.Controls.Add(this.systemSpecsLbl);
            this.Controls.Add(this.createNewServerLbl);
            this.Controls.Add(this.welcomeLbl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1286, 717);
            this.Name = "Startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Selection | CraftForge {release} - v{applicationVersion}";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Startup_Close);
            this.Load += new System.EventHandler(this.Startup_Load);
            this.Controls.SetChildIndex(this.welcomeLbl, 0);
            this.Controls.SetChildIndex(this.createNewServerLbl, 0);
            this.Controls.SetChildIndex(this.systemSpecsLbl, 0);
            this.Controls.SetChildIndex(this.settingsLbl, 0);
            this.Controls.SetChildIndex(this.titleBarPanel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label createNewServerLbl;
        private System.Windows.Forms.Label systemSpecsLbl;
        private System.Windows.Forms.Label settingsLbl;
    }
}