using CraftForge.Server.GUI.Applications;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CraftForge.Server.StartPage.Classes;

namespace CraftForge.Server.Setup
{
    internal class generateNewServer
    {
        public static async Task<bool> createAsync(string serverName, string serverIP, string serverPort, string serverMOTD, string fileUrl, int playerMax, int ram)
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + String.Format("/CraftForge/Servers/{0}", serverName);
            if (Directory.Exists(directory))
            {
                MessageBox.Show("Server already exists!");
                return false;
            }

            Directory.CreateDirectory(directory);
            Directory.SetCurrentDirectory(directory);

            if (fileUrl != null)
            {
                // Await the asynchronous download
                await downloadFile.downloadUrlFileAsync(fileUrl, "server.jar");
            }

            File.WriteAllText("eula.txt", "eula=false");

            File.WriteAllText("server.properties", "server-port=" + serverPort.ToString() + "\n" + "server-ip=" + serverIP.ToString() + "\n" + "level-name=world\n" + "gamemode=survival\n" + "difficulty=easy\n" + "allow-cheats=false\n" + "max-players=" + playerMax + "\n" + "online-mode=true\n" + "white-list=false\n" + "server-name=" + serverName.ToString() + "\n" + "motd=" + serverMOTD.ToString() + "\n");

            startBatFile.createNewFile(directory, ram, "server"); //Create the start.bat file

            return true;
        }
    }
}