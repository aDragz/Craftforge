﻿namespace CraftForge
{
    partial class debugTerminal
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
            this.terminalOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // terminalOutput
            // 
            this.terminalOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terminalOutput.Location = new System.Drawing.Point(0, 0);
            this.terminalOutput.Name = "terminalOutput";
            this.terminalOutput.Size = new System.Drawing.Size(800, 450);
            this.terminalOutput.TabIndex = 0;
            this.terminalOutput.Text = "";
            // 
            // debugTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.terminalOutput);
            this.Name = "debugTerminal";
            this.Text = "debugTerminal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox terminalOutput;
    }
}