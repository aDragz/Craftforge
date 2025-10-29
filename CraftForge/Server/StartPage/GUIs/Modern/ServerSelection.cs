using CraftForge.NewGUI;
using CraftForge.Server.Classes.Console.Applications;
using CraftForge.Server.GUI.Console;
using CraftForge.Server.StartPage.Classes;
using CraftForge.Server.StartPage.GUIs.Modern;
using CraftForge.Server.Themes.Classes.Applications;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Management;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CraftForge.Server.GUI.Setup
{
    public partial class Startup : TitleBar
    {
        public static List<string> instancesRunning = new List<string>();
        public static string applicationVersion = Application.ProductVersion.Substring(0, Application.ProductVersion.Length - 2);
        public static string release = "Unknown"; //Default release

        public Startup()
        {
            InitializeComponent();

            this.TitleText = $"Server Selection";

            this.TitleMinimizeButtonEnabled = true;
            this.TitleMaximizeButtonEnabled = true;
            this.TitleCloseButtonEnabled = true;

            try
            {

                //Load the configuration file
                XmlDocument configDoc = new XmlDocument();
                string mainLocation = Assembly.GetExecutingAssembly().Location;
                string configLocation = mainLocation.Substring(0, mainLocation.Length - 4).Replace("Craft Forge", "") + "CraftForge Updater.exe.config";

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
                            release = valueNode.InnerText;
                            release = char.ToUpper(release[0]) + release.Substring(1);
                        }
                    }
                }
            }
            catch { }
        }

        private async void Startup_Load(object sender, EventArgs e)
        {
            this.Hide();

            instancesRunning.Add(this.Name);

            this.MinimizeBox = false;

            //Check to see if the default folder exists
            checkDefaultFolders();

            // Perform the loading operations asynchronously
            // Invoke the LoadServers method on the form thread
            await Task.Run(() => this.Invoke((MethodInvoker)delegate { LoadServers(); }));

            //Adding down here maxed a "cool" effect, showing it's getting maximized
            //Check to see if the form needs to be maximized
            if (Properties.Settings.Default.startMenu_startMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            welcomeLbl.Text = $"CraftForge\nv{applicationVersion} | {release}";
            if (Properties.Settings.Default.displaySystemSpecifications)
            {
                loadSystemSpecs();
            } else
            {
                systemSpecsLbl.Text = "System Specifications are disabled in settings";
            }

            // Show the form after loading is complete
            this.Show();
        }

        //Check to see if the default folders exist, like Documents/CraftForge/Themes. This is because the Application breaks in certain scenarios. Like settings doesn't work
        //unless Themes folder exists. (Found out when testing Linux)
        private void checkDefaultFolders()
        {
            //Check if themes location exists
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CraftForge\\Themes"))
            {
                //Create the directory
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CraftForge\\Themes");

                Theme.createThemes();
            }
        }

        private void loadSystemSpecs()
        {
            ComputerInfo computerInfo = new ComputerInfo();
            ulong totalPhysicalMemory = computerInfo.TotalPhysicalMemory;

            // Convert bytes to gigabytes
            double totalMemoryInGB = totalPhysicalMemory / (1024.0 * 1024.0 * 1024.0);

            // Round up to the nearest whole number
            int roundedMemoryInGB = (int)Math.Ceiling(totalMemoryInGB);

            string cpuName = string.Empty;
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select Name from Win32_Processor"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    cpuName = obj["Name"].ToString();
                    break; // Assuming there's only one CPU
                }
            }

            int threadCount = Environment.ProcessorCount;

            systemSpecsLbl.Text = ($"CPU: {cpuName}\nThreads: {threadCount}\nTotal RAM: {roundedMemoryInGB}GB");
        }

        private void Startup_Close(object sender, FormClosingEventArgs e)
        {
            instancesRunning.Remove(this.Name);
        }

        private async void LoadServers()
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                Location = new Point(1, 80),
                Size = new Size(655, 638),
                AutoScroll = false,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left,
            };

            //Add flowLayoutPanel to tableLayoutPanel
            tableLayoutPanel.Controls.Add(flowLayoutPanel);


            // Add the FlowLayoutPanel to the form
            this.Invoke((MethodInvoker)delegate
            {
                this.Controls.Add(tableLayoutPanel);
            });

            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("/CraftForge/Servers/"); //Set Directory

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            int serverCount = Directory.GetDirectories(directory).Length; //Grab amount of servers / folders there are

            string[] serverNames = Directory.GetDirectories(directory); //Grab the names of the folder

            List<string> serverPorts = new List<string>(); // List of used server ports
            List<string> serversRunning = new List<string>(); //List of servers which are open

            //Grab each open Terminal windows, and add the server name to the list
            foreach (Form form in Application.OpenForms)
            {
                if (form is Terminal)
                    serversRunning.Add(form.Name);
            }

            // Add items to the FlowLayoutPanel
            for (int i = 0; i < serverCount; i++)
            {
                string serverName = Path.GetFileName(serverNames[i]);
                string serverNameShort = serverName.Length > 33 ? serverName.Substring(0, 33) + "..." : serverName;
                bool norunbat = false;

                if (!File.Exists(serverNames[i] + "\\start.bat")) //Check to see if start.bat exists, else it will show a "fix" button
                    norunbat = true;

                //Main panel
                Panel panel = new Panel
                {
                    Name = "Server " + serverName,
                    Width = 600,
                    Height = 100,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.FromArgb(42, 42, 55), //55 to make it slightly darker than the background
                };

                //Start button
                Button button = new Button
                {
                    Text = "Open Server",
                    Name = "Button " + serverName,
                    Width = 125,
                    Height = 60,
                    Location = new Point(450, 20),
                    Font = new Font("Consolas", 10),
                    ForeColor = Color.FromArgb(240, 240, 240), //Set the text color to white
                    BackColor = Color.FromArgb(42, 42, 55), //55 to make it slightly darker than the background
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 1, BorderColor = Color.FromArgb(240, 240, 240) },
                };

                //Fix if there is no start.bat (norunbat)
                Button noRunButton = new Button
                {
                    Text = "Fix Server",
                    Name = "NoRunButton " + serverName,
                    Width = 125,
                    Height = 60,
                    Location = new Point(300, 20),
                    Font = new Font("Consolas", 10),
                    ForeColor = Color.FromArgb(240, 240, 240), //Set the text color to white
                    BackColor = Color.FromArgb(42, 42, 55), //55 to make it slightly darker than the background
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 1, BorderColor=Color.FromArgb(240, 240, 240)}, 
                };

                //Location Text
                Label label = new Label
                {
                    Text = serverNameShort,
                    Name = "Label " + serverName,
                    Width = 300,
                    Height = 20,
                    Margin = new Padding(10),
                    Location = new Point(10, 20),
                    Font = new Font("Consolas", 10),
                    BorderStyle = BorderStyle.None,
                    ForeColor = Color.FromArgb(240, 240, 240), //Set the text color to white
                    BackColor = Color.FromArgb(42, 42, 55), //55 to make it slightly darker than the background
                };

                //Port Label
                Label labelPort = new Label
                {
                    Text = "Unknown", //If it cannot find port, it will display 'Unknown'
                    Name = "Port " + serverName,
                    Width = 300,
                    Height = 20,
                    Margin = new Padding(10),
                    Location = new Point(10, 45),
                    Font = new Font("Consolas", 10),
                    BorderStyle = BorderStyle.None,
                    ForeColor = Color.FromArgb(240, 240, 240), //Set the text color to white
                    BackColor = Color.FromArgb(42, 42, 55), //55 to make it slightly darker than the background
                };


                Label fixServerLabel = new Label
                {
                    Text = serverNameShort + " - Server is missing start.bat",
                    Name = "FixServerLabel " + serverName,
                    Width = 300,
                    Height = 60,
                    Margin = new Padding(10),
                    Location = new Point(0, 20),
                    Font = new Font("Consolas", 10),
                    ForeColor = Color.FromArgb(240, 240, 240), //Set the text color to white
                    BackColor = Color.FromArgb(42, 42, 55), //55 to make it slightly darker than the background
                };

                // Display the full name on hover
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(button, serverName);

                //Add the controls to the panel
                panel.Controls.Add(button);

                if (norunbat)
                {
                    panel.Controls.Add(fixServerLabel);
                    panel.Controls.Add(noRunButton);

                    button.Enabled = false; //Disable the button if start.bat is missing, so the user can't open the server until they fix it
                }
                else
                {
                    panel.Controls.Add(label);
                    panel.Controls.Add(labelPort);
                }

                //Grab server.properties file and read server-port
                string serverPropertiesPath = Path.Combine(serverNames[i], "server.properties");

                if (File.Exists(serverPropertiesPath))
                {
                    // Read all lines from the server.properties file
                    string[] lines = File.ReadAllLines(serverPropertiesPath);

                    // Search for the line that contains the server-port value
                    foreach (string line in lines)
                    {
                        if (line.StartsWith("server-port="))
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                // Extract the server-port value
                                string serverPort = line.Substring("server-port=".Length);
                                labelPort.Text = serverPort;

                                if (string.IsNullOrEmpty(serverPort))
                                    labelPort.Text = "Empty";

                                foreach (string port in serverPorts)
                                {
                                    if (port == serverPort)
                                    {
                                        labelPort.ForeColor = Color.Red;
                                    }
                                }

                                serverPorts.Add(serverPort);
                            });
                        }
                    }
                }

                //If the serverName is open in a Terminal Application, it will set the label to green.
                //This displays to the user that the server is running. Does not mean that it is Online.
                if (serversRunning.Contains(serverName))
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        label.ForeColor = Color.Green; //Set the text to green to display the server is running in the Terminal Application.
                    });
                }

                // Add event handler to the button
                button.Click += new EventHandler((s, ev) => button_Click(s, ev, serverName));

                //Check if it contains "Server is missing start.bat"
                if (fixServerLabel.Text.Contains("Server is missing start.bat"))
                {
                    noRunButton.Click += new EventHandler((s, ev) => fixServer_Click(s, ev, serverName));
                }

                this.Invoke((MethodInvoker)delegate
                {
                    flowLayoutPanel.Controls.Add(panel);
                });
            }
        }

        private void button_Click(object sender, EventArgs e, string serverName)
        {
            // Create a new instance of the CreateNewServer form

            //Grab amount of Terminal processes are running

            //If the server is already running, do not open another terminal
            if (instancesRunning.Contains(serverName))
            {
                MessageBox.Show("Server is already running!");
                return;
            }

            Terminal terminal = new Terminal
            {
                Name = serverName,
                Size = this.Size,
                StartPosition = FormStartPosition.Manual,
                Location = this.Location,
                WindowState = this.WindowState,
            };

            try
            {
                instancesRunning.Add(serverName);
                terminal.Show();

                if (Properties.Settings.Default.terminal_closeOnServerOpen)
                {
                    instancesRunning.Remove(this.Name);

                    this.Hide();
                }
            }
            catch { }
        }

        private void fixServer_Click(object sender, EventArgs e, string serverName)
        {
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("/CraftForge/Servers/" + serverName);
            startBatFile.createNewFile(location, 1024, "server"); //Create the start.bat file

            //Hide button
            Button button = (Button)sender;
            button.Hide();

            //Enable the start button
            Button startButton = (Button)this.Controls.Find("Button " + serverName, true)[0];
            startButton.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CreateNewServerModern createNewServer = new CreateNewServerModern()
            {
                StartPosition = FormStartPosition.CenterScreen,

            };
            createNewServer.Show();
        }

        private void settingsLbl_Click(object sender, EventArgs e)
        {
            openSettings.runSettingsApp(); //Show the settings Application
        }

        private void createNewServerLbl_Click(object sender, EventArgs e)
        {
            CreateNewServerModern modern = new CreateNewServerModern
            {
                StartPosition = FormStartPosition.CenterScreen,
            };

            modern.Show();
        }
    }
}