﻿using CraftForge.Server.Classes.Themes.Classes;
using CraftForge.Server.GUI.Console;
using CraftForge.Server.Themes.Themes;
using System;
using System.Drawing;
using System.IO;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace CraftForge.Server.Classes.Themes.Applications
{
    public partial class customizeTheme : Form
    {
        private readonly string themeLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Themes\\");

        string currentTheme;
        bool hasChanged = false;

        string selectedItem = "";

        string Terminal_Window_BackColour; // Done
        string Terminal_Console_ForeColour; // Done
        string Terminal_Console_BackColour; // Done
        string Terminal_Console_Font; // Done

        string Terminal_Chart_BackColour; //Done
        string Terminal_Chart_BackColourSecondary; //NA

        string Terminal_startBtn_TextColour; // Done
        string Terminal_startBtn_BackColour; // Done
        string Terminal_startBtn_Font; // Done

        string Terminal_stopBtn_TextColour; // Done
        string Terminal_stopBtn_BackColour; // Done
        string Terminal_stopBtn_Font; // Done

        string Terminal_sideBar_BackColour; // Doing

        string Global_Btn_TextColour; //NA
        string Global_Btn_BackColour; //NA
        string Global_Btn_Font; //NA

        string Global_Lbl_TextColour; //NA
        string Global_Lbl_BackColour; //NA

        /*
          
         How to add a feature?

        1. Add to customizeTheme_Load
        2. Add to itemClicked (If it's linked to multiple values, like statusPanel)
        3. Add to updateItems
        4. Add to updateColour (If it's a text/back colour)
        5. Add to updateFont (If it's a font)
        */

        public customizeTheme()
        {
            InitializeComponent();
        }

        private void customizeTheme_Load(object sender, EventArgs e)
        {
            //Set serverJarCombo as readonly
            serverJarCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            //Add items to selectedItemBox
            selectedItemBox.Items.Add("startBtn");
            selectedItemBox.Items.Add("stopBtn");
            selectedItemBox.Items.Add(""); //Add spacer
            selectedItemBox.Items.Add("terminalBackground");
            selectedItemBox.Items.Add("secondaryTerminal");
            //selectedItemBox.Items.Add("secondaryTerminalInput"); //Needs working on
            selectedItemBox.Items.Add("ramUsageChart");
            selectedItemBox.Items.Add(""); //Add spacer
            //selectedItemBox.Items.Add("serverJarCombo"); //Needs working on
            //selectedItemBox.Items.Add("serverStatusPnl"); //Needs working on
            //selectedItemBox.Items.Add(""); //Add spacer
            selectedItemBox.Items.Add("statusBar");

            loadThemesList();
            loadGUIValues();
            readThemeSettings();
            updateItems();

            terminalBackground.Click += itemClicked;
            secondaryTerminal.Click += itemClicked;
            secondaryTerminalInput.Click += itemClicked;

            //Buttons
            startBtn.Click += itemClicked;
            stopBtn.Click += itemClicked;

            serverJarCombo.Click += itemClicked;
            serverStatusLbl.Click += itemClicked;
            ServerStatusIPLbl.Click += itemClicked;
            ServerStatusIPInfoLbl.Click += itemClicked;
            ServerStatusPortLbl.Click += itemClicked;
            ServerStatusPortInfoLbl.Click += itemClicked;

            ramUsageChart.Click += itemClicked;
            cpuUsageChart.Click += itemClicked;

            statusBar.Click += itemClicked;

            hasChanged = false; //Just loaded, so no changes
        }

        private void loadThemesList()
        {
            themeList.Text = Properties.Settings.Default.Theme;
            //Check if default theme exists
            if (!File.Exists(themeLocation + "Default"))
            {
                //Create the default theme
                themeList.Items.Add("Default");
                //Add a spacer
                themeList.Items.Add("");
            }

            //Grab all files from location and add to list
            foreach (string file in Directory.GetFiles(themeLocation))
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);

                //Skip the default theme, as it already exists in the list
                if (fileNameWithoutExtension.Equals("default", StringComparison.OrdinalIgnoreCase))
                    continue;

                //Add the file to the list

                //Make the first character Upper Case
                fileNameWithoutExtension = char.ToUpper(fileNameWithoutExtension[0]) + fileNameWithoutExtension.Substring(1);

                themeList.Items.Add(fileNameWithoutExtension);
            }
        }

        private void loadGUIValues()
        {
            string currentTheme = themeList.Text;
        }

        private void itemClicked(object sender, EventArgs e)
        {
            //Get the selected item name

            selectedItem = ((Control)sender).Name;

            //Check names to see if I need to update them automatically, like it's it should be a panel (Like the server status area)

            if (selectedItem == "serverStatusLbl" || selectedItem == "ServerStatusIPLbl" || selectedItem == "ServerStatusIPInfoLbl"
                || selectedItem == "ServerStatusPortLbl" || selectedItem == "ServerStatusPortInfoLbl")
            {
                selectedItem = "serverStatusPnl";
            }

            selectedItemBox.Text = selectedItem;

            updateItems();
        }

        private void updateItems()
        {
            itemNameLbl.Text = "Name: " + selectedItem;

            if (string.IsNullOrEmpty(selectedItem))
                itemNameLbl.Text = "Name: None";

            switch (selectedItem)
            {
                case "startBtn":
                    itemColourLbl.Text = "Text Colour: " + Terminal_startBtn_TextColour;
                    itemBackColourLbl.Text = "Back Colour: " + Terminal_startBtn_BackColour;
                    itemFontLbl.Text = "Font: " + Terminal_startBtn_Font;

                    itemTextColourBtn.Enabled = true;
                    itemBackColourBtn.Enabled = true;
                    itemFontBtn.Enabled = true;

                    if (string.IsNullOrEmpty(Terminal_startBtn_TextColour))
                        itemColourLbl.Text = "Text Colour: None";

                    break;
                case "stopBtn":
                    itemColourLbl.Text = "Text Colour: " + Terminal_stopBtn_TextColour;
                    itemBackColourLbl.Text = "Back Colour: " + Terminal_stopBtn_BackColour;
                    itemFontLbl.Text = "Font: " + Terminal_stopBtn_Font;

                    itemTextColourBtn.Enabled = true;
                    itemBackColourBtn.Enabled = true;
                    itemFontBtn.Enabled = true;

                    if (string.IsNullOrEmpty(Terminal_stopBtn_TextColour))
                        itemColourLbl.Text = "Text Colour: None";

                    break;
                case "secondaryTerminal":
                    itemColourLbl.Text = "Text Colour: " + Terminal_Console_ForeColour;
                    itemBackColourLbl.Text = "Back Colour: " + Terminal_Console_BackColour;
                    itemFontLbl.Text = "Font: " + Terminal_Console_Font;

                    itemTextColourBtn.Enabled = true;
                    itemBackColourBtn.Enabled = true;
                    itemFontBtn.Enabled = true;

                    if (string.IsNullOrEmpty(Terminal_Console_ForeColour))
                        itemColourLbl.Text = "Text Colour: None";

                    break;
                case "terminalBackground":
                    itemColourLbl.Text = "Text Colour: None";
                    itemBackColourLbl.Text = "Back Colour: " + Terminal_Window_BackColour;
                    itemFontLbl.Text = "Font: None";

                    itemTextColourBtn.Enabled = false;
                    itemBackColourBtn.Enabled = true;
                    itemFontBtn.Enabled = false;

                    if (string.IsNullOrEmpty(Terminal_Window_BackColour))
                        itemColourLbl.Text = "Text Colour: None";

                    break;
                case "ramUsageChart":
                    itemColourLbl.Text = "Text Colour: None";
                    itemBackColourLbl.Text = "Back Colour: " + Terminal_Chart_BackColour;
                    itemFontLbl.Text = "Font: None";

                    itemTextColourBtn.Enabled = false;
                    itemBackColourBtn.Enabled = true;
                    itemFontBtn.Enabled = false;

                    break;
                case "statusBar":
                    itemColourLbl.Text = "Text Colour: None";
                    itemBackColourLbl.Text = "Back Colour: " + Terminal_sideBar_BackColour;
                    itemFontLbl.Text = "Font: None";
                    itemTextColourBtn.Enabled = false;
                    itemBackColourBtn.Enabled = true;
                    itemFontBtn.Enabled = false;

                    break;
                default:
                    selectedItemBox.Text = "";
                    itemColourLbl.Text = "Text Colour: None";
                    itemBackColourLbl.Text = "Back Colour: None";
                    itemFontLbl.Text = "Font: None";

                    itemTextColourBtn.Enabled = false;
                    itemBackColourBtn.Enabled = false;
                    itemFontBtn.Enabled = false;

                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    string argbColor = $"{selectedColor.A},{selectedColor.R},{selectedColor.G},{selectedColor.B}";
                    itemColourLbl.Text = $"Text Colour: {argbColor}";
                    updateColour(argbColor, "null", false);

                    hasChanged = true;
                }
            }
        }

        private void itemBackColourBtn_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    string argbColor = $"{selectedColor.A},{selectedColor.R},{selectedColor.G},{selectedColor.B}";
                    itemBackColourLbl.Text = $"Back Colour: {argbColor}";
                    updateColour(argbColor, "null", true);

                    hasChanged = true;
                }
            }
        }

        private void itemFontBtn_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                //Disable special fonts
                fontDialog.AllowScriptChange = false;
                fontDialog.AllowSimulations = false;
                fontDialog.AllowVectorFonts = false;

                //Show current font
                try
                {
                    fontDialog.Font = FontReconstructor.convertFromString(itemFontLbl.Text.Replace("Font: ", ""));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    Font selectedFont = fontDialog.Font;

                    string fontFormatted = $"{selectedFont.Name}, {selectedFont.Size}, {selectedFont.Style}";

                    itemFontLbl.Text = $"Font: " + fontFormatted;
                    updateFont(fontFormatted, "null");

                    hasChanged = true;
                }
            }
        }

        private void updateColour(string colour, string forceSelectedItem, bool isBackColour)
        {
            string[] argbValues = colour.Split(',');

            int a = 255;
            int r = 0;
            int g = 0;
            int b = 0;

            if (argbValues.Length == 3)
            {

                r = int.Parse(argbValues[0]);
                g = int.Parse(argbValues[1]);
                b = int.Parse(argbValues[2]);

            }
            if (argbValues.Length == 4)
            {
                a = int.Parse(argbValues[0]);
                r = int.Parse(argbValues[1]);
                g = int.Parse(argbValues[2]);
                b = int.Parse(argbValues[3]);
            }

            if (forceSelectedItem == "startBtn" || selectedItem == "startBtn")
            {
                if (isBackColour)
                {
                    startBtn.BackColor = Color.FromArgb(a, r, g, b);
                    Terminal_startBtn_BackColour = colour;
                }
                else
                {
                    startBtn.ForeColor = Color.FromArgb(a, r, g, b);
                    Terminal_startBtn_TextColour = colour;
                }
            }
            else if (forceSelectedItem == "stopBtn" || selectedItem == "stopBtn")
            {
                if (isBackColour)
                {
                    stopBtn.BackColor = Color.FromArgb(a, r, g, b);
                    Terminal_stopBtn_BackColour = colour;
                }
                else
                {
                    stopBtn.ForeColor = Color.FromArgb(a, r, g, b);
                    Terminal_stopBtn_TextColour = colour;
                }
            }
            else if (forceSelectedItem == "serverStatusPnl" || selectedItem == "serverStatusPnl") //TODO: work on this on the selection bit
            {
                serverStatusLbl.BackColor = Color.FromArgb(a, r, g, b);
                ServerStatusIPLbl.BackColor = Color.FromArgb(a, r, g, b);
                ServerStatusIPInfoLbl.BackColor = Color.FromArgb(a, r, g, b);
                ServerStatusPortLbl.BackColor = Color.FromArgb(a, r, g, b);
                ServerStatusPortInfoLbl.BackColor = Color.FromArgb(a, r, g, b);
            }
            else if (forceSelectedItem == "secondaryTerminal" || selectedItem == "secondaryTerminal")
            {
                if (isBackColour)
                {
                    secondaryTerminal.BackColor = Color.FromArgb(a, r, g, b);
                    Terminal_Console_BackColour = colour;
                }
                else
                {
                    secondaryTerminal.ForeColor = Color.FromArgb(a, r, g, b);
                    Terminal_Console_ForeColour = colour;
                }
            }
            else if (forceSelectedItem == "terminalBackground" || selectedItem == "terminalBackground")
            {
                if (isBackColour)
                {
                    terminalBackground.BackColor = Color.FromArgb(a, r, g, b);
                    Terminal_Window_BackColour = colour;
                }
            }
            else if (forceSelectedItem == "ramUsageChart" || selectedItem == "ramUsageChart")
            {
                if (isBackColour)
                {
                    ramUsageChart.BackColor = Color.FromArgb(a, r, g, b);
                    Terminal_Chart_BackColour = colour;
                }
            }
            else if (forceSelectedItem == "statusBar" || selectedItem == "statusBar")
            {
                if (isBackColour)
                {
                    statusBar.BackColor = Color.FromArgb(a, r, g, b);
                    Terminal_sideBar_BackColour = colour;
                }
            }
        }

        private void updateFont(string fontUnstructured, string forceSelectedItem)
        {
            if (string.IsNullOrEmpty(fontUnstructured))
                return;

            Font font = FontReconstructor.convertFromString(fontUnstructured);

            if (forceSelectedItem == "startBtn" || selectedItem == "startBtn")
            {
                Terminal_startBtn_Font = fontUnstructured;
                startBtn.Font = font;
            }
            else if (forceSelectedItem == "stopBtn" || selectedItem == "stopBtn")
            {
                Terminal_stopBtn_Font = fontUnstructured;
                stopBtn.Font = font;
            }
            else if (forceSelectedItem == "secondaryTerminal" || selectedItem == "secondaryTerminal")
            {
                Terminal_Console_Font = fontUnstructured;
                secondaryTerminal.Font = font;
            }
        }


        private void readThemeSettings()
        {
            if (!File.Exists(($"{themeLocation}\\{themeList.Text}.yaml")))
            {
                MessageBox.Show("Theme does not exist");
                return;
            }

            if (hasChanged)
            {
                //Ask if they want to save changes
                DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //doing
                    //Save changes
                    //saveChanges();
                }
                else
                {
                    themeList.SelectedIndexChanged -= themeList_SelectedIndexChanged; // Remove the event handler temporarily
                    themeList.Text = currentTheme;
                    themeList.SelectedIndexChanged += themeList_SelectedIndexChanged; // Add the event handler back
                    return;
                }
            }

            currentTheme = themeList.Text;
            hasChanged = false;

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            using (var reader = new StreamReader($"{themeLocation}\\{themeList.Text}.yaml"))
            {
                var settings = deserializer.Deserialize<defaultTheme>(reader);
                var defaultSettings = new defaultTheme();

                Terminal_Window_BackColour = settings.Terminal_Window_BackColour;
                updateColour(Terminal_Window_BackColour, "terminalBackground", true);

                Terminal_Chart_BackColour = settings.Terminal_Chart_BackColour;
                updateColour(Terminal_Chart_BackColour, "ramUsageChart", true);


                Terminal_startBtn_TextColour = settings.Terminal_startBtn_TextColour;
                Terminal_startBtn_BackColour = settings.Terminal_startBtn_BackColour;
                Terminal_startBtn_Font = settings.Terminal_startBtn_Font;
                updateColour(Terminal_startBtn_TextColour, "startBtn", false);
                updateColour(Terminal_startBtn_BackColour, "startBtn", true);
                updateFont(Terminal_startBtn_Font, "startBtn");

                Terminal_stopBtn_TextColour = settings.Terminal_stopBtn_TextColour;
                Terminal_stopBtn_BackColour = settings.Terminal_stopBtn_BackColour;
                Terminal_stopBtn_Font = settings.Terminal_stopBtn_Font;
                updateColour(Terminal_stopBtn_TextColour, "stopBtn", false);
                updateColour(Terminal_stopBtn_BackColour, "stopBtn", true);
                updateFont(Terminal_stopBtn_Font, "stopBtn");

                Terminal_Console_ForeColour = settings.Terminal_Console_ForeColour;
                Terminal_Console_BackColour = settings.Terminal_Console_BackColour;
                Terminal_Console_Font = settings.Terminal_Console_Font;
                updateColour(Terminal_Console_ForeColour, "secondaryTerminal", false);
                updateColour(Terminal_Console_BackColour, "secondaryTerminal", true);
                updateFont(Terminal_Console_Font, "secondaryTerminal");

                Terminal_sideBar_BackColour = settings.Terminal_sideBar_BackColour;
                updateColour(Terminal_sideBar_BackColour, "statusBar", true);

                //Add all NA
                Terminal_Chart_BackColourSecondary = settings.Terminal_Chart_BackColourSecondary;
                Global_Btn_TextColour = settings.Global_Btn_TextColour;
                Global_Btn_BackColour = settings.Global_Btn_BackColour;
                Global_Btn_Font = settings.Global_Btn_Font;
                Global_Lbl_TextColour = settings.Global_Lbl_TextColour;
                Global_Lbl_BackColour = settings.Global_Lbl_BackColour;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void themeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = "";
            updateItems();
            readThemeSettings();
        }

        private void selectedItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedItemBox.Text == currentTheme)
                return;
            selectedItemBox.Name = selectedItemBox.Text;
            itemClicked(selectedItemBox, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            applyThemeToFile();
        }

        private void applyThemeToFile()
        {
            saveCustomTheme themeSettings = new saveCustomTheme
            {
                TerminalWindowBackColour = Terminal_Window_BackColour,
                TerminalConsoleForeColour = Terminal_Console_ForeColour,
                TerminalConsoleBackColour = Terminal_Console_BackColour,
                TerminalConsoleFont = Terminal_Console_Font,
                TerminalChartBackColour = Terminal_Chart_BackColour,
                TerminalChartBackColourSecondary = Terminal_Chart_BackColourSecondary,
                TerminalStartBtnTextColour = Terminal_startBtn_TextColour,
                TerminalStartBtnBackColour = Terminal_startBtn_BackColour,
                TerminalStartBtnFont = Terminal_startBtn_Font,
                TerminalStopBtnTextColour = Terminal_stopBtn_TextColour,
                TerminalStopBtnBackColour = Terminal_stopBtn_BackColour,
                TerminalStopBtnFont = Terminal_stopBtn_Font,
                TerminalSideBarBackColour = Terminal_sideBar_BackColour,
                GlobalBtnTextColour = Global_Btn_TextColour,
                GlobalBtnBackColour = Global_Btn_BackColour,
                GlobalBtnFont = Global_Btn_Font,
                GlobalLblTextColour = Global_Lbl_TextColour,
                GlobalLblBackColour = Global_Lbl_BackColour
            };

            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            using (var writer = new StreamWriter($"{themeLocation}\\{themeList.Text}.yaml"))
            {
                serializer.Serialize(writer, themeSettings);
            }

            //Change the theme

                //Change the theme
                Properties.Settings.Default.Theme = themeList.Text;
                Properties.Settings.Default.Save();

                //Update the theme
                foreach (Form form in global::System.Windows.Forms.Application.OpenForms)
                {
                    if (form is Terminal)
                    {
                        Terminal terminal = (Terminal)form;
                        Terminal.InitializeThemeStatic(terminal); // Changed to access the static method directly from the class
                    }
                }
            
            MessageBox.Show("Applied Theme. Please restart the app to apply the full effect. Or some aspects may be broken!", "Applied Theme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void saveChanges()
        {
            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            using (var writer = new StreamWriter($"{themeLocation}\\{themeList.Text}-1.yaml"))
            {
                serializer.Serialize(writer, this);
            }
        }
    }
}
