using CraftForge.Server.Themes.Themes;
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
    internal class red
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

        public static readonly string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Themes");

        public void writeFile()
        {
            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            using (var writer = new StreamWriter($"{location}\\red.yaml"))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static void writeSettingsToFile()
        {
            red red = new red
            {
                Terminal_Button_Colour_Fore = "0, 0, 0, 0",
                Terminal_Button_Colour_Back = "250, 82,90",

                Terminal_Label_Colour_Text = "250, 82,90",

                Terminal_SideBar_Colour_Text = "250, 82,90",

                Terminal_Terminal_Colour_Fore = "250, 82,90",
                Terminal_Terminal_Colour_Back = "42, 42, 42",
                
                Terminal_Background_Colour = "42, 42, 50",
                Terminal_SideBar_Colour = "42, 42, 55",

                Terminal_StatusBar_Colour = "42, 42, 55",

                Terminal_Chart_Colour_Back = "42, 42, 50",
                Terminal_Chart_Colour_BackSecondary = "42, 42, 50",
                Terminal_Chart_Colour_BackPoints = "42, 42, 50"
            };

            red.writeFile();
        }
    }
}
