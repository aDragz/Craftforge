using System;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace CraftForge.Server.Themes.Themes
{
    internal class defaultTheme
    {
        public string Terminal_Button_Colour_Fore { get; set; }
        public string Terminal_Button_Colour_Back { get; set; }

        public string Terminal_Label_Colour_Text { get; set; }

        public string Terminal_SideBar_Colour_Text { get; set; }

        public string Terminal_Terminal_Colour_Fore { get; set; }
        public string Terminal_Terminal_Colour_Back { get; set; }

        public string Terminal_Background_Colour { get; set; }
        public string Terminal_SideBar_Colour { get; set; }

        public string Terminal_StatusBar_Colour { get; set; }

        public string Terminal_Chart_Colour_Back { get; set; }
        public string Terminal_Chart_Colour_BackSecondary { get; set; }
        public string Terminal_Chart_Colour_BackPoints { get; set; }

        private static readonly string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Themes");

        public void writeFile()
        {
            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            using (var writer = new StreamWriter($"{location}\\default.yaml"))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static void writeSettingsToFile()
        {
            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }

            defaultTheme theme = new defaultTheme() {
                Terminal_Button_Colour_Fore = "0, 0, 0, 0", //Black
                Terminal_Button_Colour_Back = "255, 255, 255, 255", //White

                Terminal_Label_Colour_Text = "0, 0, 0, 0",

                Terminal_SideBar_Colour_Text = "255, 255, 255, 255",

                Terminal_Terminal_Colour_Fore = "0, 0, 0, 0",
                Terminal_Terminal_Colour_Back = "255, 255, 255, 255",

                Terminal_Background_Colour = "255, 255, 255, 255",
                Terminal_SideBar_Colour = "255, 255, 255, 255",

                Terminal_StatusBar_Colour = "255, 255, 255, 255",

                Terminal_Chart_Colour_Back = "255, 255, 255, 255",
                Terminal_Chart_Colour_BackSecondary = "255, 255, 255, 255",
                Terminal_Chart_Colour_BackPoints = "255, 255, 255, 255"
            };

            theme.writeFile();
        }

        public static defaultTheme ReadSettings()
        {
            string currentTheme = Properties.Settings.Default.Theme;

            if (!File.Exists(($"{location}\\{currentTheme}.yaml")))
            {
                return new defaultTheme();
            }

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            using (var reader = new StreamReader($"{location}\\{currentTheme}.yaml"))
            {
                var settings = deserializer.Deserialize<defaultTheme>(reader);
                var defaultSettings = new defaultTheme();

                //Background
                if (settings.Terminal_Background_Colour == null)
                {
                    settings.Terminal_Background_Colour = defaultSettings.Terminal_Background_Colour;
                }
                if (settings.Terminal_SideBar_Colour == null)
                {
                    settings.Terminal_SideBar_Colour = defaultSettings.Terminal_SideBar_Colour;
                }

                //Buttons
                if (settings.Terminal_Button_Colour_Back == null)
                {
                    settings.Terminal_Button_Colour_Back = defaultSettings.Terminal_Button_Colour_Back;
                }
                if (settings.Terminal_Button_Colour_Fore == null)
                {
                    settings.Terminal_Button_Colour_Fore = defaultSettings.Terminal_Button_Colour_Fore;
                }

                //Labels
                if (settings.Terminal_Label_Colour_Text == null)
                {
                    settings.Terminal_Label_Colour_Text = defaultSettings.Terminal_Label_Colour_Text;
                }

                //SideBar
                if (settings.Terminal_SideBar_Colour_Text == null)
                {
                    settings.Terminal_SideBar_Colour_Text = defaultSettings.Terminal_SideBar_Colour_Text;
                }

                //Terminal
                if (settings.Terminal_Terminal_Colour_Back == null)
                {
                    settings.Terminal_Terminal_Colour_Back = defaultSettings.Terminal_Terminal_Colour_Back;
                }
                if (settings.Terminal_Terminal_Colour_Fore == null)
                {
                    settings.Terminal_Terminal_Colour_Fore = defaultSettings.Terminal_Terminal_Colour_Fore;
                }

                //Status Bar
                if (settings.Terminal_StatusBar_Colour == null)
                {
                    settings.Terminal_StatusBar_Colour = defaultSettings.Terminal_StatusBar_Colour;
                }

                return settings;
            }
        }
    }
}