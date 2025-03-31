using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CraftForge
{
    public class terminalOutputWriter : TextWriter
    {
        private readonly debugTerminal _form;

        public terminalOutputWriter(debugTerminal form)
        {
            _form = form;
        }

        public override void Write(char value)
        {
            _form.AppendText(value.ToString());
        }

        public override void Write(string value)
        {
            _form.AppendText(value);
        }

        public override void WriteLine(string value)
        {
            _form.AppendText(value + Environment.NewLine);
        }

        public override void WriteLine(char value)
        {
            _form.AppendText(value.ToString() + Environment.NewLine);
        }

        public override Encoding Encoding => Encoding.UTF8;
    }
}
