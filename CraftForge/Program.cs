using CraftForge.Properties;
using CraftForge.Server.Classes;
using CraftForge.Server.GUI.Applications;
using CraftForge.Server.GUI.Setup;
using CraftForge.Server.StartPage.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CraftForge
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Create notify icon
            notifyIcon.InitializeTrayIcon();

            //check if args[1] exists
            if (args.Contains("--settings")) // Check if the argument is --settings-<panel>
            {
                //grab args number of --settings
                int index = Array.IndexOf(args, "--settings");
                string release = args[index + 1]; // Get the next argument after --settings

                settings.CraftForgeUpdaterConfig("TypeSelected", release); //If stable is selected, it will be updated as stable as an example.
            }

            Application.Run(new Startup());
        }
    }
}