﻿using CraftForge.Server.GUI.Applications;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CraftForge.Server.Setup
{
    internal class generateNewServer
    {
        public static async Task<bool> createAsync(string serverName, string serverIP, string serverPort, string serverMOTD, string fileUrl)
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + String.Format("/Minecraft-Multiplayer-Host/Servers/{0}", serverName);
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

            File.WriteAllText("server.properties", "server-port=" + serverPort.ToString() + "\n" + "server-ip=" + serverIP.ToString() + "\n" + "level-name=world\n" + "gamemode=survival\n" + "difficulty=easy\n" + "allow-cheats=false\n" + "max-players=20\n" + "online-mode=true\n" + "white-list=false\n" + "server-name=" + serverName.ToString() + "\n" + "motd=" + serverMOTD.ToString() + "\n");

            File.WriteAllText("start.bat", "::Please do not edit this file! Use the app or it may break the server. You have been warned!"
                + "\n" + "::Displays Java Version for debugging inside console"
                + "\n" + "java -version"
                + "\n" + "::Starts server"
                + "\n" + "java -Xmx1024M -Xms1024M -jar server.jar nogui");

            return true;
        }
    }
}