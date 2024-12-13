using CraftForge.Server.GUI.Applications;
using System.Windows.Forms;

namespace CraftForge.Server.Classes.Console.Applications
{
    internal class openSettings
    {
        public static void runSettingsApp()
        {
            foreach (Form form in Application.OpenForms) //Grab each open window, and if settings is open, focus on it
            {
                if (form.Name == "settings")
                {
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal; // Restore the form if it is minimized

                    form.Focus();
                    return;
                }
            }

            settings settings = new settings(); //Run the settings application
            settings.Show(); //If settings is not open, open it
        }
    }
}
