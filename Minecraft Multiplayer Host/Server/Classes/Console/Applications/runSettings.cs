using Minecraft_Multiplayer_Host.Server.GUI.Applications;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.Classes.Console.Applications
{
    internal class runSettings
    {
        public static void runSettingsApp()
        {
            //Run the settings application
            settings Settings = new settings();

            //Grab each open window, and if settings is ing, focus on it
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.Name == "settings")
                {
                    // Restore the form if it is minimized
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    
                    form.Focus();
                    return;
                }
            }

            //If settings is not open, open it
            Settings.Show();
        }
    }
}
