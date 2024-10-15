using Minecraft_Multiplayer_Host.Server.GUI.Console;
using Minecraft_Multiplayer_Host.Server.Setup;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.GUI.Setup
{
    public partial class CreateNewServer : Form
    {
        public CreateNewServer()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            // Main Strings
            string serverName = nameTextBox.Text;
            string serverIP = IpTextBox.Text;
            string serverPort = portTextBox.Text;
            string serverMOTD = motdTextBox.Text;

            // Url Strings
            string type = typeSelector.SelectedItem.ToString().ToLower();
            string url = null;

            if (!type.Equals("custom"))
            {
                // Url Strings
                string version = versionSelector.SelectedItem.ToString();
                string build = buildSelector.SelectedItem.ToString();

                if (type.Equals("paper") || type.Equals("waterfall") || type.Equals("velocity"))
                {
                    url = String.Format("https://api.papermc.io/v2/projects/{0}/versions/{1}/builds/{2}/downloads/{0}-{1}-{2}.jar", type, version, build);
                }
            }

            if (!await generateNewServer.createAsync(serverName, serverIP, serverPort, serverMOTD, url))
            {
                return;
            }

            // Once created, Open terminal
            Terminal terminal = new Terminal
            {
                Text = serverName,
                Name = serverName,
            };

            terminal.Show();
            this.Close();
        }

        private async void typeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serverType = typeSelector.SelectedItem.ToString().ToLower();
            versionSelector.Enabled = true;

            if (serverType.Equals("paper") || serverType.Equals("waterfall") || serverType.Equals("velocity"))
            {
                await getPaperMcVersions();
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
            else
            {
                buildSelector.Enabled = false;
            }
        }

        private void CreateNewServer_Load(object sender, EventArgs e)
        {
            getPaperMcVersions();
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
    }
}