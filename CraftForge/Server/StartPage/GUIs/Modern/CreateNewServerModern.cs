using CraftForge.Server.Classes.Console.Yaml;
using CraftForge.Server.GUI.Console;
using CraftForge.Server.Setup;
using CraftForge.Server.StartPage.Classes;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CraftForge.Server.StartPage.GUIs.Modern
{
    public partial class CreateNewServerModern : TitleBar
    {

        /*
         Design Specifications:

           - The labels have a spacing of 45px
             For example, serverNameLbl is at 24, 125, and serverIPAddressLbl is at 24, 170.

           - The label Font is: Arial, 16px
        */
        private int threadCount = Environment.ProcessorCount; // The number of CPU cores available on the system

        public CreateNewServerModern()
        {
            InitializeComponent();

            this.TitleText = "Create New Server";
            this.TitleMinimizeButtonEnabled = true;
            this.TitleMaximizeButtonEnabled = false;
            this.TitleCloseButtonEnabled = true;
        }

        private void CreateNewServerModern_Load(object sender, System.EventArgs e)
        {
            ipAddressTextBox.Text = getIPv4Address();

            CPUCoresNumber.Maximum = threadCount;

            //Get maximum amount of memory (in mb)

            ComputerInfo computerInfo = new ComputerInfo();
            ulong totalPhysicalMemory = computerInfo.TotalPhysicalMemory;
            int totalMemoryMB = (int)(totalPhysicalMemory / (1024 * 1024));

            ramNumber.Maximum = totalMemoryMB;
        }

        private string getIPv4Address()
        {
            if (Properties.Settings.Default.grabIPv4Address == 0)
                return string.Empty;
            else if (Properties.Settings.Default.grabIPv4Address == 2)
            {
                //Ask user if they want to enable this setting
                DialogResult dialogResult = MessageBox.Show("Would you like to automatically grab your IPv4 address?", "Grab IPv4 Address", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Properties.Settings.Default.grabIPv4Address = 1;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.grabIPv4Address = 0;
                    Properties.Settings.Default.Save();
                    return "localhost";
                }
            }

            string localIP = string.Empty;
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up &&
                    (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet || ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211))
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            localIP = ip.Address.ToString();
                            break;
                        }
                    }
                }
                if (string.IsNullOrEmpty(localIP))
                {
                    localIP = "localhost";
                }
            }
            return localIP;
        }

        private async void typeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serverType = typeSelector.SelectedItem.ToString().ToLower();
            versionSelector.Enabled = true;

            if (serverType.Equals("paper") || serverType.Equals("waterfall") || serverType.Equals("velocity"))
            {
                await getPaperMcVersions();
            }
            else if (serverType.Equals("spigot"))
            {
                await getSpigotVersions();
            }
            else if (serverType.Equals("custom"))
            {
                // Tell the user to add their own jar
                MessageBox.Show("Please add your own jar file to the server folder and select it in the terminal");
                buildSelector.Text = "";
                buildSelector.Items.Clear();
                buildSelector.Enabled = false;
                versionSelector.Text = "";
                versionSelector.Items.Clear();
                versionSelector.Enabled = false;
            }
            else
            {
                buildSelector.Text = "";
                buildSelector.Items.Clear();
                buildSelector.Enabled = false;
            }
        }

        private async void versionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serverVersion = versionSelector.SelectedItem.ToString();
            string serverType = typeSelector.SelectedItem.ToString().ToLower();

            if (serverType.Equals("paper") || serverType.Equals("waterfall") || serverType.Equals("velocity"))
            {
                await getPaperMcBuilds();
            }
            else if (serverType.Equals("spigot"))
            {
                buildSelector.Text = "Disabled";
                buildSelector.Items.Clear();
                buildSelector.Enabled = false;
            }
            else
            {
                buildSelector.Enabled = false;
            }
        }

        private async Task getPaperMcVersions()
        {
            string serverType = typeSelector.SelectedItem.ToString().ToLower();

            string versionUrl = string.Format("https://api.papermc.io/v2/projects/{0}", serverType);

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(versionUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(responseBody);
                    JArray versions = (JArray)json["versions"];
                    string latestVersion = versions.Last.ToString();

                    versionSelector.Items.Clear();
                    // Add all builds to the "build" selector
                    foreach (var version in versions)
                    {
                        versionSelector.Items.Add(version);
                    }

                    // Though, set text to the most recent one
                    versionSelector.Text = latestVersion;
                }
                catch { }
            }
        }

        private async Task getPaperMcBuilds()
        {
            string serverVersion = versionSelector.SelectedItem.ToString();
            string serverType = typeSelector.SelectedItem.ToString().ToLower();

            string url = string.Format("https://api.papermc.io/v2/projects/{0}/versions/{1}/", serverType, serverVersion);

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(responseBody);
                    JArray versions = (JArray)json["builds"];
                    string latestVersion = versions.Last.ToString();

                    buildSelector.Items.Clear();
                    // Add all builds to the "build" selector
                    foreach (var version in versions)
                    {
                        buildSelector.Items.Add(version);
                    }

                    // Though, set text to the most recent one
                    buildSelector.Text = latestVersion;
                    buildSelector.Enabled = true;
                }
                catch { }
            }
        }

        private async Task getSpigotVersions()
        {
            string serverType = typeSelector.SelectedItem.ToString().ToLower();

            string versionUrl = string.Format("https://craftforge.dev/api/CraftForge/Server/Spigot/versions.json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(versionUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(responseBody);
                    JArray versions = (JArray)json["versions"];
                    string latestVersion = versions.Last.ToString();

                    versionSelector.Items.Clear();
                    // Add all builds to the "build" selector
                    foreach (var version in versions)
                    {
                        versionSelector.Items.Add(version);
                    }

                    // Though, set text to the most recent one
                    versionSelector.Text = latestVersion;
                }
                catch { }
            }
        }

        private async void createServerBtn_Click(object sender, EventArgs e)
        {
            // Main Strings
            string serverName = serverNameTextBox.Text;
            string serverIP = ipAddressTextBox.Text;
            string serverPort = portTextBox.Text;
            string serverMOTD = motdTextBox.Text;

            if (serverName.Equals("") || serverIP.Equals("") || serverPort.Equals("") || serverMOTD.Equals(""))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            if (serverName.Contains("!"))
            {
                MessageBox.Show("Server name cannot contain '!' character");
                return;
            }

            // Url Strings
            string type = typeSelector.SelectedItem.ToString().ToLower();
            string url = null;

            if (!type.Equals("custom"))
            {
                // Url Strings
                string version = versionSelector.SelectedItem.ToString();

                if (type.Equals("paper") || type.Equals("waterfall") || type.Equals("velocity"))
                {
                    string build = buildSelector.SelectedItem.ToString();
                    url = string.Format("https://api.papermc.io/v2/projects/{0}/versions/{1}/builds/{2}/downloads/{0}-{1}-{2}.jar", type, version, build);
                }
                if (type.Equals("spigot"))
                {
                    url = null; //To create the directory (Does not need to download as it uses buildTools.jar (runBuildTool.runTool())
                }
            }

            int player = (int)playerCountNumber.Value;
            int ram = (int)ramNumber.Value;
            if (!await generateNewServer.createAsync(serverName, serverIP, serverPort, serverMOTD, url, player, ram))
            {
                return;
            }

            if (type.Equals("spigot")) //Run here so it can create the files/folders without buildTools.jar crashing
                runBuildTool.runTool(Path.Combine("servers", serverName), versionSelector.SelectedItem.ToString()); //Run Build tool

            // Once created, Open terminal
            Terminal terminal = new Terminal
            {
                Text = serverName,
                Name = serverName,
            };

            serverSettings.writeSettingsToFile(serverName, CPUCoresNumber.Value.ToString());


            terminal.Show();
            this.Close();
        }
    }
}
