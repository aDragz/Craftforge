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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.systemSpecsLbl = new System.Windows.Forms.Label();
            this.settingsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(867, 822);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLbl.Font = new System.Drawing.Font("Consolas", 24F);
            this.welcomeLbl.Location = new System.Drawing.Point(872, 7);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(804, 86);
            this.welcomeLbl.TabIndex = 1;
            this.welcomeLbl.Text = "CraftForge";
            this.welcomeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.Location = new System.Drawing.Point(1469, 790);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create New Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // systemSpecsLbl
            // 
            this.systemSpecsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.systemSpecsLbl.Location = new System.Drawing.Point(873, 688);
            this.systemSpecsLbl.Name = "systemSpecsLbl";
            this.systemSpecsLbl.Size = new System.Drawing.Size(590, 136);
            this.systemSpecsLbl.TabIndex = 3;
            this.systemSpecsLbl.Text = "System Specifications";
            this.systemSpecsLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // settingsLbl
            // 
            this.settingsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsLbl.AutoSize = true;
            this.settingsLbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.settingsLbl.Location = new System.Drawing.Point(1568, 762);
            this.settingsLbl.Name = "settingsLbl";
            this.settingsLbl.Size = new System.Drawing.Size(98, 23);
            this.settingsLbl.TabIndex = 4;
            this.settingsLbl.Text = "Settings";
            this.settingsLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1691, 826);
            this.Controls.Add(this.settingsLbl);
            this.Controls.Add(this.systemSpecsLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.flowLayoutPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1709, 873);
            this.Name = "Startup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Startup_Close);
            this.Load += new System.EventHandler(this.Startup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label systemSpecsLbl;
        private System.Windows.Forms.Label settingsLbl;
    }
}