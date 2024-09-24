using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.Classes.Console.Initialize.Files.ContextMenus
{
    internal class UploadFolder
    {
        public static void UploadFolders(FlowLayoutPanel panel, string directory, string serverName)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folder = folderBrowserDialog.SelectedPath;

                string[] foldersList = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);

                foreach (string file in foldersList)
                {
                    try
                    {
                        File.Copy(file, directory + System.IO.Path.GetFileName(file));
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("File already exists in the directory");
                    }
                }

                //Clear the panel
                panel.Controls.Clear();

                //Reinitialize the files
                AddFiles.initializeFiles(panel, directory, serverName);
            }
        }
    }
}
