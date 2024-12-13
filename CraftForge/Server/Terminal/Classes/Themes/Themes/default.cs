using System;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace CraftForge.Server.Themes.Themes
{
    internal class defaultTheme
    {
        public string Terminal_Window_BackColour { get; set; }
        public string Terminal_Console_ForeColour { get; set; }
        public string Terminal_Console_BackColour { get; set; }
        public string Terminal_Console_Font { get; set; }

        public string Terminal_Chart_BackColour { get; set; }
        public string Terminal_Chart_BackColourSecondary { get; set; }

        public string Terminal_startBtn_TextColour { get; set; }
        public string Terminal_startBtn_BackColour { get; set; }
        public string Terminal_startBtn_Font { get; set; }

        public string Terminal_stopBtn_TextColour { get; set; }
        public string Terminal_stopBtn_BackColour { get; set; }
        public string Terminal_stopBtn_Font { get; set; }

        public string Terminal_sideBar_BackColour { get; set; }

        //Global variables
        public string Global_Btn_TextColour { get; set; }
        public string Global_Btn_BackColour { get; set; }
        public string Global_Btn_Font { get; set; }

        public string Global_Lbl_TextColour { get; set; }
        public string Global_Lbl_BackColour { get; set; }

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

            defaultTheme theme = new defaultTheme()
            {
                Terminal_Window_BackColour = "255, 255, 255, 255", //White
                Terminal_Console_ForeColour = "0, 0, 0, 0", //Black
                Terminal_Console_BackColour = "255, 255, 255, 255",
                Terminal_Console_Font = "Consolas, 10",

                Terminal_Chart_BackColour = "255, 255, 255, 255",
                Terminal_Chart_BackColourSecondary = "255, 255, 255, 255",

                Terminal_startBtn_TextColour = "0, 0, 0, 0",
                Terminal_startBtn_BackColour = "255, 255, 255, 255",
                Terminal_startBtn_Font = "Consolas, 14",

                Terminal_stopBtn_TextColour = "0, 0, 0, 0",
                Terminal_stopBtn_BackColour = "255, 255, 255, 255",
                Terminal_stopBtn_Font = "Consolas, 14",

                Terminal_sideBar_BackColour = "255, 255, 255, 255",

                Global_Btn_TextColour = "0, 0, 0, 0",
                Global_Btn_BackColour = "255, 255, 255, 255",
                Global_Btn_Font = "Consolas, 14",

                Global_Lbl_BackColour = "255, 255, 255, 255",
                Global_Lbl_TextColour = "0, 0, 0, 0"
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

                return settings;
            }
        }
    }
}