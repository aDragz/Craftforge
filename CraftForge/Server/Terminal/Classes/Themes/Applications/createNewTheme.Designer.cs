namespace CraftForge.Server.Classes.Themes.Applications
{
    partial class CreateNewTheme
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
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.mainLbl = new System.Windows.Forms.Label();
            this.themeNameTxt = new System.Windows.Forms.TextBox();
            this.copyFromList = new System.Windows.Forms.ComboBox();
            this.copyFromLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Consolas", 12F);
            this.okBtn.Location = new System.Drawing.Point(616, 100);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(108, 39);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Font = new System.Drawing.Font("Consolas", 12F);
            this.cancelBtn.Location = new System.Drawing.Point(502, 100);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(108, 39);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // mainLbl
            // 
            this.mainLbl.AutoSize = true;
            this.mainLbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.mainLbl.Location = new System.Drawing.Point(12, 9);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(131, 23);
            this.mainLbl.TabIndex = 2;
            this.mainLbl.Text = "Theme Name:";
            // 
            // themeNameTxt
            // 
            this.themeNameTxt.Location = new System.Drawing.Point(149, 9);
            this.themeNameTxt.Name = "themeNameTxt";
            this.themeNameTxt.Size = new System.Drawing.Size(575, 22);
            this.themeNameTxt.TabIndex = 3;
            // 
            // copyFromList
            // 
            this.copyFromList.FormattingEnabled = true;
            this.copyFromList.Location = new System.Drawing.Point(149, 40);
            this.copyFromList.Name = "copyFromList";
            this.copyFromList.Size = new System.Drawing.Size(270, 24);
            this.copyFromList.TabIndex = 4;
            // 
            // copyFromLbl
            // 
            this.copyFromLbl.AutoSize = true;
            this.copyFromLbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.copyFromLbl.Location = new System.Drawing.Point(12, 40);
            this.copyFromLbl.Name = "copyFromLbl";
            this.copyFromLbl.Size = new System.Drawing.Size(120, 23);
            this.copyFromLbl.TabIndex = 5;
            this.copyFromLbl.Text = "Copy From:";
            // 
            // CreateNewTheme
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(736, 151);
            this.Controls.Add(this.copyFromLbl);
            this.Controls.Add(this.copyFromList);
            this.Controls.Add(this.themeNameTxt);
            this.Controls.Add(this.mainLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateNewTheme";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "createNewTheme";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.createNewTheme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label mainLbl;
        private System.Windows.Forms.TextBox themeNameTxt;
        private System.Windows.Forms.ComboBox copyFromList;
        private System.Windows.Forms.Label copyFromLbl;
    }
}