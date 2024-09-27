using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.Classes.Console.Initialize.Files.ContextMenus
{
    internal class openFile
    {
        public static void openFiles(FlowLayoutPanel panel, string directory, string serverName, string path)
        {
            try
            {
                // Open the file
                Process.Start(path);
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
