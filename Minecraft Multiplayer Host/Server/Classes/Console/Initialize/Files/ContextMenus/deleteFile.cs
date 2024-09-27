using System;
using System.IO;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.Classes.Console.Initialize.Files.ContextMenus
{
    internal class deleteFile
    {
        public static void deleteFiles(FlowLayoutPanel panel, string directory, string serverName, string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true); // true to delete recursively
                }
                else if (File.Exists(path))
                {
                    File.Delete(path);
                }
                else
                {
                    MessageBox.Show("File or directory does not exist.");
                    return;
                }

                panel.Controls.Clear();
                AddFiles.initializeFiles(panel, directory, serverName);
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
