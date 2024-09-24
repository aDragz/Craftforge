using Minecraft_Multiplayer_Host.Server.Classes;
using Minecraft_Multiplayer_Host.Server.GUI.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Create notify icon
            notifyIcon.InitializeTrayIcon();

            Application.Run(new Startup());
        }
    }
}
