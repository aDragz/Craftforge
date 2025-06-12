using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraftForge
{
    public partial class debugTerminal : Form
    {
        public debugTerminal()
        {
            InitializeComponent();
        }

        public void AppendText(string text)
        {
            if (this.terminalOutput.InvokeRequired)
            {
                this.terminalOutput.Invoke(new Action<string>(AppendText), text);
            }
            else
            {
                this.terminalOutput.AppendText(text + Environment.NewLine);
            }
        }

        private RichTextBox richTextBox;
    }
}
