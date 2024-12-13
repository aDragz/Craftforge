using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CraftForge.Server.Classes.Console.Initialize.Files.ContextMenus
{
    internal class openInNotepad
    {
        public static void openFile(FlowLayoutPanel panel, string directory, string serverName, string path)
        {
            try
            {
                // Open the file in notepad
                Process.Start("notepad.exe", path);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No permission");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
