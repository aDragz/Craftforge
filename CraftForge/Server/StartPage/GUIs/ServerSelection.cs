﻿using CraftForge.Server.Classes.Console.Applications;
using CraftForge.Server.GUI.Console;
using CraftForge.Server.StartPage.Classes;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CraftForge.Server.GUI.Setup
{
    public partial class Startup : Form
    {
        public static List<string> instancesRunning = new List<string>();
        public static string applicationVersion = Application.ProductVersion.Substring(0, Application.ProductVersion.Length - 2);
        public static string release = "Unknown"; //Default release

        public Startup()
        {
            InitializeComponent();

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

            // Perform the loading operations asynchronously
            // Invoke the LoadServers method on the form thread
            await Task.Run(() => this.Invoke((MethodInvoker)delegate { LoadServers(); }));

            //Adding down here maxed a "cool" effect, showing it's getting maximized
            //Check to see if the form needs to be maximized
            if (Properties.Settings.Default.startMenu_startMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            // Set the title of the form
            this.Text = $"Server Selection | CraftForge {release} - v{applicationVersion}";
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
            // Create FlowLayoutPanel where 4 items are displayed per line
            /*FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                AutoScroll = false,
                BackColor = Color.Transparent,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom,
            };*/


            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
            };

            //Add flowLayoutPanel to tableLayoutPanel
            tableLayoutPanel.Controls.Add(flowLayoutPanel);


            // Add the FlowLayoutPanel to the form
            this.Invoke((MethodInvoker)delegate
            {
                this.Controls.Add(tableLayoutPanel);
            });

            // Grab amount of files in Documents/Minecraft Multiplayer Host/Servers
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("/CraftForge/Servers/");

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Grab the amount of servers
            int serverCount = Directory.GetDirectories(directory).Length;

            // Grab the name of the servers
            string[] serverNames = Directory.GetDirectories(directory);

            List<string> serverPorts = new List<string>(); // List of used server ports
            List<string> serversRunning = new List<string>();

            //Grab each open Terminal windows, and add the server name to the list
            foreach (Form form in Application.OpenForms)
            {
                if (form is Terminal)
                {
                    string name = (form.Name);
                    serversRunning.Add(name);
                }
            }

            // Add items to the FlowLayoutPanel
            for (int i = 0; i < serverCount; i++)
            {
                string serverName = Path.GetFileName(serverNames[i]);
                bool norunbat = false;

                //Check if start.bat exists in the server directory
                if (!File.Exists(serverNames[i] + "\\start.bat"))
                {
                    norunbat = true;
                }

                //Main panel
                Panel panel = new Panel
                {
                    Name = "Server " + serverName,
                    Width = 600,
                    Height = 100,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                };

                //Start button
                Button button = new Button
                {
                    Text = "Open Server",
                    Name = "Button " + serverName,
                    Width = 125,
                    Height = 60,
                    Margin = new Padding(10),
                    Location = new Point(450, 20),
                    Font = new Font("Consolas", 10),
                };

                Button noRunButton = new Button
                {
                    Text = "Fix Server",
                    Name = "NoRunButton " + serverName,
                    Width = 125,
                    Height = 60,
                    Margin = new Padding(10),
                    Location = new Point(300, 20),
                    Font = new Font("Consolas", 10),
                };

                //Location Text
                RichTextBox label = new RichTextBox
                {
                    Text = serverName,
                    Name = "RichTextBox " + serverName,
                    Width = 300,
                    Height = 60,
                    Margin = new Padding(10),
                    Location = new Point(10, 20),
                    Font = new Font("Consolas", 10),
                    ReadOnly = true,
                    BorderStyle = BorderStyle.None,
                    BackColor = this.BackColor,
                    ScrollBars = RichTextBoxScrollBars.None,
                };

                Label fixServerLabel = new Label
                {
                    Text = serverName + " - Server is missing start.bat",
                    Name = "FixServerLabel " + serverName,
                    Width = 300,
                    Height = 60,
                    Margin = new Padding(10),
                    Location = new Point(0, 20),
                    Font = new Font("Consolas", 10),
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
                                // Set the label colour to the previous color
                                this.Invoke((MethodInvoker)delegate
                                {
                                    label.Select(0, serverName.Length);
                                    label.SelectionColor = label.ForeColor;
                                });

                                label.Text = label.Text + $"\n{serverPort}";

                                foreach (string port in serverPorts)
                                {
                                    if (port == serverPort)
                                    {
                                        label.Select(label.Text.IndexOf(serverPort), serverPort.Length);
                                        label.SelectionColor = Color.Red;
                                    }
                                }

                                serverPorts.Add(serverPort);
                            });
                        }
                    }

                    //Check if the server is running
                    if (serversRunning.Contains(serverName))
                    {
                        //Set the label colour to green
                        this.Invoke((MethodInvoker)delegate
                        {
                            label.Select(0, serverName.Length);
                            label.SelectionColor = Color.Green;
                        });
                    }
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
                instancesRunning.Remove(this.Name);
                terminal.Show();

                this.Hide();
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
            CreateNewServer createNewServer = new CreateNewServer();
            createNewServer.Size = this.Size;
            createNewServer.StartPosition = FormStartPosition.Manual;
            createNewServer.Location = this.Location;
            createNewServer.WindowState = this.WindowState;
            createNewServer.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Show the settings Application
            openSettings.runSettingsApp();
        }
    }
}