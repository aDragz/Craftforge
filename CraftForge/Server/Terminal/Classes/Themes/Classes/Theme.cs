﻿using CraftForge.Server.Classes.Themes.Themes.Custom;
using CraftForge.Server.GUI.Console;
using CraftForge.Server.Themes.Themes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CraftForge.Server.Themes.Classes.Applications
{
    internal class Theme
    {
        public static void initializeTheme(Terminal terminal, Panel serverTabsPanel, MenuStrip menuStrip)
        {
            //Check if themes location exists
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CraftForge\\Themes"))
            {
                //Create the directory
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CraftForge\\Themes");

                createThemes();
            }
            //Set the theme

            //Grab each button inside serverTabs
            TabControl.ApplyThemeToTabControl(terminal.serverTabs);

            var theme = defaultTheme.ReadSettings();

            foreach (Control control in serverTabsPanel.Controls) // Fixed: Added 'terminal.' to access serverTabsPanel
            {
                if (control is Label)
                {
                    control.ForeColor = ColorTranslator.FromHtml(theme.Global_Btn_TextColour);
                }
            }

            //terminal.statusStrip.BackColor = ColorTranslator.FromHtml(theme.Terminal_StatusBar_Colour);

            serverTabsPanel.BackColor = ColorTranslator.FromHtml(theme.Terminal_sideBar_BackColour); // Fixed: Added 'terminal.' to access serverTabsPanel
            menuStrip.BackColor = ColorTranslator.FromHtml(theme.Terminal_menuStrip_BackColour);
        }

        public static void createThemes()
        {
            defaultTheme.writeSettingsToFile();
            blue.writeSettingsToFile();
            red.writeSettingsToFile();
        }
    }
}