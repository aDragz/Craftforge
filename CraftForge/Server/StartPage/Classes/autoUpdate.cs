using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Reflection;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;
using System.Xml;

namespace CraftForge.Server.StartPage.Classes
{
    internal class autoUpdate
    {
        public async static void checkForUpdates()
        {
            //Grab current version
            string currentApplicationVersion = Application.ProductVersion.Substring(0, Application.ProductVersion.Length - 2);
            string newApplicationVersion = "";

            string url = "https://craftforge.dev/api/latest.json";
            string version = grabType(); //TODO : Add a way to change this

            if (!string.IsNullOrEmpty(version))
            {
                using (HttpClient client = new HttpClient())
                {
                    //Grab Data
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(url);
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();

                        JObject json = JObject.Parse(responseBody);
                        JArray versions = (JArray)json[version.ToString()];

                        // Add all builds to the "build" selector
                        foreach (var verNumber in versions)
                        {
                            newApplicationVersion = verNumber.ToString();
                        }

                        //Check if the versions are the same
                        if (currentApplicationVersion != newApplicationVersion)
                        {
                            DialogResult result = MessageBox.Show($"Would you like to update?\n\nType: {version}\nCurrent Version: {currentApplicationVersion}\nNew Version: {newApplicationVersion}", "New Update", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                //Grab main location
                                string mainLocation = Assembly.GetExecutingAssembly().Location;

                                //Open mainLocation/Minecraft Multiplayer Host Updater.exe
                                string updaterLocation = mainLocation.Substring(0, mainLocation.Length - 4).Replace("Craft Forge", "") + "CraftForge Updater.exe";
                                System.Diagnostics.Process.Start(updaterLocation);

                                //Close this
                                Environment.Exit(0);
                            }
                        }
                    }
                    catch { }
                }
            } else
            {
                MessageBox.Show("Cannot update! Please try again later.");
            }
        }

        public static string grabType()
        {
            try
            {
                string mainLocation = Assembly.GetExecutingAssembly().Location;
                string configLocation = mainLocation.Substring(0, mainLocation.Length - 4).Replace("Craft Forge", "") + "CraftForge Updater.exe.config";

                //Load the configuration file
                XmlDocument configDoc = new XmlDocument();
                configDoc.Load(configLocation);

                //Find the userSettings section
                XmlNode userSettingsNode = configDoc.SelectSingleNode("//userSettings/CraftForge_Updater.Properties.Settings");
                if (userSettingsNode != null)
                {
                    XmlNode settingNode = userSettingsNode.SelectSingleNode($"setting[@name='TypeSelected']");
                    if (settingNode != null)
                    {
                        XmlNode valueNode = settingNode.SelectSingleNode("value");
                        if (valueNode != null)
                        {
                            return valueNode.InnerText;
                        }
                    }
                }
            }
            catch{}

            return null;
        }
    }
}
