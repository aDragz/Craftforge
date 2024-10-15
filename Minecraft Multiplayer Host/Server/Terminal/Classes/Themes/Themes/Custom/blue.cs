using Minecraft_Multiplayer_Host.Server.Themes.Themes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;

namespace Minecraft_Multiplayer_Host.Server.Classes.Themes.Themes.Custom
{
    internal class blue
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
        
        public static readonly string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Themes");

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
                Terminal_Button_Colour_Fore = "0, 0, 0, 0",
                Terminal_Button_Colour_Back = "82, 149, 250",

                Terminal_Label_Colour_Text = "82, 149, 250",

                Terminal_SideBar_Colour_Text = "82, 149, 250",

                Terminal_Terminal_Colour_Fore = "82, 149, 250",
                Terminal_Terminal_Colour_Back = "42, 42, 42",
                
                Terminal_Background_Colour = "42, 42, 50",
                Terminal_SideBar_Colour = "42, 42, 55",

                Terminal_StatusBar_Colour = "42, 42, 55"
            };

            blue.writeFile();
        }
    }
}
