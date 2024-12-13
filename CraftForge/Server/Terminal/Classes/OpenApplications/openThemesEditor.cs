using CraftForge.Server.Classes.Themes.Applications;
using System.Windows.Forms;

namespace CraftForge.Server.Classes.OpenApplications
{
    internal class openThemesEditor
    {
        public static void runThemesEditorApp()
        {
            foreach (Form form in Application.OpenForms) //Grab each open window, and if themes is open, focus on it
            {
                if (form.Name == "customizeTheme")
                {
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal; // Restore the form if it is minimized

                    form.Focus();
                    return;
                }
            }

            customizeTheme themeEditor = new customizeTheme(); //Run the theme application
            themeEditor.Show(); //If themes is not open, open it
        }
    }
}
