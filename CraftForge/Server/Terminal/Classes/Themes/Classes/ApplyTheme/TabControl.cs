using CraftForge.Server.Classes.Themes.Classes;
using CraftForge.Server.Themes.Themes;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CraftForge.Server.Themes.Classes.Applications
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
                tabPage.BackColor = ColorTranslator.FromHtml(theme.Terminal_Window_BackColour);

                foreach (Control control in tabPage.Controls)
                {
                    try
                    {
                        if (control is Panel)
                        {
                            //Set background colour
                            control.BackColor = ColorTranslator.FromHtml(theme.Terminal_Window_BackColour);
                        }
                        else if (control is Button)
                        {
                            if (control.Name == "stopBtn")
                            {
                                control.BackColor = ColorTranslator.FromHtml(theme.Terminal_stopBtn_BackColour);
                                control.Font = FontReconstructor.convertFromString(theme.Terminal_stopBtn_Font);
                            } else if (control.Name == "startBtn") {
                                control.BackColor = ColorTranslator.FromHtml(theme.Terminal_startBtn_BackColour);
                                control.Font = FontReconstructor.convertFromString(theme.Terminal_startBtn_Font);
                            } else {
                                control.ForeColor = ColorTranslator.FromHtml(theme.Global_Btn_TextColour);
                                control.BackColor = ColorTranslator.FromHtml(theme.Global_Btn_BackColour);
                            }
                        }
                        else if (control is Label)
                        {
                            control.ForeColor = ColorTranslator.FromHtml(theme.Global_Lbl_TextColour);
                        }
                        else if (control is RichTextBox)
                        {
                            //Check if it is the terminal (main terminal is controlled in createConsole.cs)
                            if (control.Name.Equals("secondaryTerminal"))
                            {
                                control.ForeColor = ColorTranslator.FromHtml(theme.Terminal_Console_ForeColour);
                                //control.BackColor down below
                                control.Font = FontReconstructor.convertFromString(theme.Terminal_Console_Font);

                                var backColor = ColorTranslator.FromHtml(theme.Terminal_Console_BackColour);
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
                        else if (control is Chart)
                        {
                            Chart chart = (Chart)control;

                            chart.BackColor = ColorTranslator.FromHtml(theme.Terminal_Chart_BackColour);
                            chart.BackSecondaryColor = ColorTranslator.FromHtml(theme.Terminal_Chart_BackColourSecondary);

                            //Set the chart area colours
                            foreach (ChartArea chartArea in chart.ChartAreas)
                            {
                                chartArea.BackColor = ColorTranslator.FromHtml(theme.Terminal_Chart_BackColour);
                                chartArea.BackSecondaryColor = ColorTranslator.FromHtml(theme.Terminal_Chart_BackColour);
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