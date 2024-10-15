using Minecraft_Multiplayer_Host.Server.Themes.Themes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.Themes.Classes.Applications
{
    internal class TabControl
    {
        public static void ApplyThemeToTabControl(System.Windows.Forms.TabControl tabControl)
        {
            var theme = defaultTheme.ReadSettings();

            //Get all theme settings
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                // Set the locale to English (United Kingdom)
                CultureInfo.CurrentCulture = new CultureInfo("en-GB");
                CultureInfo.CurrentUICulture = new CultureInfo("en-GB");

                //Set background color
                tabPage.BackColor = ColorTranslator.FromHtml(theme.Terminal_Background_Colour);

                foreach (Control control in tabPage.Controls)
                {
                    try
                    {
                        if (control is Panel)
                        {
                            //Set background colour
                            control.BackColor = ColorTranslator.FromHtml(theme.Terminal_Background_Colour);
                        }
                        else if (control is Button)
                        {

                            control.ForeColor = ColorTranslator.FromHtml(theme.Terminal_Button_Colour_Fore);
                            control.BackColor = ColorTranslator.FromHtml(theme.Terminal_Button_Colour_Back);
                        }
                        else if (control is Label)
                        {
                            control.ForeColor = ColorTranslator.FromHtml(theme.Terminal_Label_Colour_Text);
                        }
                        else if (control is RichTextBox)
                        {
                            //Check if it is the terminal
                            if (control.Name.Contains("console") || control.Name.Equals("secondaryTerminal"))
                            {
                                control.ForeColor = ColorTranslator.FromHtml(theme.Terminal_Terminal_Colour_Fore);

                                var backColor = ColorTranslator.FromHtml(theme.Terminal_Terminal_Colour_Back);
                                if (backColor.A == 255) // Ensure the color is not transparent
                                {
                                    control.BackColor = backColor;
                                }
                                else
                                {
                                    MessageBox.Show($"TerminalTerminalColourBack cannot be transparent. It has to be 255, it is currently {backColor.A}");
                                    control.BackColor = Color.FromArgb(255, 255, 255, 255); //Colour is transparent, so set it to white
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Invalid color format: {ex.Message}");
                    }
                }
            }
        }
    }
}