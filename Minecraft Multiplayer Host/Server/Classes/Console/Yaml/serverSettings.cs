using System;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Minecraft_Multiplayer_Host.Server.Classes.Console.Yaml
{
    internal class serverSettings
    {
        public string threadAmount { get; set; }

        private static readonly string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Servers\\");

        public void writeFile(string serverName)
        {
            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            using (var writer = new StreamWriter($"{location}\\{serverName}\\serverSettings.yaml"))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static void writeSettingsToFile(string serverName)
        {
            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }

            serverSettings settings = new serverSettings()
            {
                threadAmount = "0", //Use all cores
            };

            settings.writeFile(serverName);
        }

        public static serverSettings ReadSettings(string serverName)
        {
            if (!File.Exists($"{location}\\{serverName}\\serverSettings.yaml")) 
            {
                return new serverSettings();
            }

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            using (var reader = new StreamReader($"{location}\\{serverName}\\serverSettings.yaml"))
            {
                var settings = deserializer.Deserialize<serverSettings>(reader);
                var defaultSettings = new serverSettings();

                //Background
                if (settings == null)
                {
                    settings.threadAmount = defaultSettings.threadAmount;
                }

                return settings;
            }
        }
    }
}
