using CraftForge.Server.Themes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;

namespace CraftForge.Server.Classes.Themes.Themes.Custom
{
    internal class blue
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
        public string Terminal_menuStrip_BackColour { get; set; }

        //Global variables
        public string Global_Btn_TextColour { get; set; }
        public string Global_Btn_BackColour { get; set; }
        public string Global_Btn_Font { get; set; }

        public string Global_Lbl_TextColour { get; set; }
        public string Global_Lbl_BackColour { get; set; }

        public static readonly string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Themes");

        public void writeFile()
        {
            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            using (var writer = new StreamWriter($"{location}\\blue.yaml"))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static void writeSettingsToFile()
        {
            blue blue = new blue
            {
                /*Terminal_Button_Colour_Fore = "0, 0, 0, 0",
                Terminal_Button_Colour_Back = "82, 149, 250",

                Terminal_Label_Colour_Text = "82, 149, 250",

                Terminal_SideBar_Colour_Text = "82, 149, 250",

                Terminal_Terminal_Colour_Fore = "82, 149, 250",
                Terminal_Terminal_Colour_Back = "42, 42, 42",
                
                Terminal_Background_Colour = "42, 42, 50",
                Terminal_SideBar_Colour = "42, 42, 55",

                Terminal_StatusBar_Colour = "42, 42, 55",

                Terminal_Chart_Colour_Back = "42, 42, 50",
                Terminal_Chart_Colour_BackSecondary = "42, 42, 50",
                Terminal_Chart_Colour_BackPoints = "42, 42, 50"*/

                Terminal_Window_BackColour = "42, 42, 50",
                Terminal_Console_ForeColour = "82, 149, 250",
                Terminal_Console_BackColour = "42, 42, 50",
                Terminal_Console_Font = "Consolas, 10",

                Terminal_Chart_BackColour = "42, 42, 50",
                Terminal_Chart_BackColourSecondary = "42, 42, 50",

                Terminal_startBtn_TextColour = "0, 0, 0, 0",
                Terminal_startBtn_BackColour = "82, 149, 250",
                Terminal_startBtn_Font = "Arial, 12",

                Terminal_stopBtn_TextColour = "0, 0, 0, 0",
                Terminal_stopBtn_BackColour = "82, 149, 250",
                Terminal_stopBtn_Font = "Arial, 12",

                Terminal_sideBar_BackColour = "42, 42, 55",
                Terminal_menuStrip_BackColour = "42, 42, 55",

                Global_Btn_TextColour = "0, 0, 0, 0",
                Global_Btn_BackColour = "82, 149, 250",
                Global_Btn_Font = "Arial, 12",

                Global_Lbl_BackColour = "255, 255, 255, 255",
                Global_Lbl_TextColour = "0, 0, 0, 0"
            };

            blue.writeFile();
        }
    }
}
