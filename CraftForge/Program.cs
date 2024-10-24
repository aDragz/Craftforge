using CraftForge.Server.Classes;
using CraftForge.Server.GUI.Setup;
using System;
using System.Windows.Forms;

namespace CraftForge
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