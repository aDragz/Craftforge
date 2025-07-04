﻿using CraftForge.Properties;
using CraftForge.Server.Classes;
using CraftForge.Server.Classes.Console.Applications;
using CraftForge.Server.Classes.Console.CreateConsole;
using CraftForge.Server.Classes.Console.Initialize.Files;
using CraftForge.Server.Classes.Console.Initialize.JarSelection;
using CraftForge.Server.Classes.Console.Yaml;
using CraftForge.Server.Classes.Console.Yaml.UpdateSettings;
using CraftForge.Server.Classes.Logs;
using CraftForge.Server.Classes.OpenApplications;
using CraftForge.Server.Classes.Player.Classes;
using CraftForge.Server.Classes.Themes.Applications.Charts;
using CraftForge.Server.Events;
using CraftForge.Server.GUI.Classes;
using CraftForge.Server.GUI.Console.Components;
using CraftForge.Server.GUI.Console.Messages.ERROR;
using CraftForge.Server.GUI.Console.Messages.INFO;
using CraftForge.Server.GUI.Console.Messages.WARN;
using CraftForge.Server.GUI.Setup;
using CraftForge.Server.Setup;
using CraftForge.Server.StartPage.Classes;
using CraftForge.Server.Themes.Classes.Applications;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CraftForge.Server.GUI.Console
{
    public partial class Terminal : Form
    {
        /* 
        Dimensions:

        Settings:

        Between Normal Items: 53px
        Normal to textbox: -1px
        Between Labels/Header: 93px
        */
        public static Dictionary<int, Process> serverProcesses = new Dictionary<int, Process>();
        bool isRunning = false; //If the server is running & user tries to open console, it will offer to open a new tab or replace the current one
        bool jarSelectionChanged = false; //If the user has changed the jar selection

        bool formClosing = false; //If the form is closing, alongside the stop button

        int ramAmount = 0; //Default amount of RAM checked when you save the settings, and it is not changed it won't update the start.bat file
        int threadAmount = 0; //Default amount of threads checked when you save the settings, and it is not changed it won't update the serverSettings.yaml file

        static string theme = Settings.Default.Theme;
        static string style = Settings.Default.Style;

        private static NotifyIcon notifications;

        static Dictionary<Process, string> serverProcessesToName = new Dictionary<Process, string>();

        int cmdID = 0;
        int childProcessID = 0; //Name of the child process created by the batch file (start.bat) when you start the server. Used for CPU usage

        public Terminal()
        {
            InitializeComponent();
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            System.Console.WriteLine("Terminal Loaded");
            this.Text = this.Name + $" | CraftForge {Startup.release} - v{Startup.applicationVersion}"; //Change this if I change title again (ctrl+f)
            settingsNameTextBox.Text = this.Name;

            InitializeSettings(); //Load settings
            InitializeJar(); //Load jar selection text
            InitializeTheme(); //Load theme
            InitializeFiles(); //Load files
            InitializeBackupFiles(); //Load backup files
            InitializeNotifications(); //Load notifications
            InitializeTerminalContextMenu(); //Load terminal's context menu
            updateChart.updateCharts(ramUsageChart, cpuUsageChart); //Load chart

            serverTabs.ItemSize = new Size(0, 1); //Hide the tabs

            tabButtons.resetSideBarButtons(serverTabsPanel, serverTabs); //Generate the side bar buttons

            if (Settings.Default.terminal_autoStart)
                startBtn_Click(sender, e);

            //Grab maximum amount of cores
            int maxCores = Environment.ProcessorCount;

            //Check if settings file exists
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Servers\\");
            if (!File.Exists(($"{location}\\{this.Name}\\serverSettings.yaml")))
            {
                serverSettings.writeSettingsToFile(this.Name, "0");
            }
            var settings = serverSettings.ReadSettings(this.Name);
            int cores = Int16.Parse(settings.threadAmount);

            threadCount.Minimum = 0;
            threadCount.Maximum = maxCores;

            threadCount.Value = cores;

            threadAmount = cores;
        }

        private void Terminal_Closing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.isRunning == false)
                {
                    Terminal_Closed(sender, e);
                }

                if (!this.formClosing && this.cmdID != 0)
                {
                    //If the server is running, stop it (and wait for it to stop
                    e.Cancel = true;
                    this.formClosing = true;
                    stopBtn_Click(sender, e);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + "\n\nYou need to manually close the server!"); //Cannot close for some reason
            }
        }

        private async void Terminal_Closed(object sender, EventArgs e)
        {
            // Unsubscribe from the FormClosed event
            this.FormClosed -= Terminal_Closed;

            //Remove from startup.instancesRunning
            Startup.instancesRunning.Remove(this.Name);

            //If instancesRunning is empty, close the form
            if (Startup.instancesRunning.Count == 0)
            {
                Application.Exit(); //Don't want people to think this is running in the background
            }

            await Task.Delay(1);
            this.Visible = false; //Hides the form
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Terminal_Closed(sender, e);
        }

        private void InitializeSettings()
        {
            //Read server.properties file
            string[] name = this.Name.Split(':');

            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Servers\\" + name[0]);
            string[] serverProperties = null;

            if (File.Exists(location + "\\server.properties"))
                serverProperties = File.ReadAllLines(location + "\\server.properties");

            //Set the text boxes
            //Read each line and set the text box
            if (serverProperties != null && serverProperties.Length > 0)
            {
                foreach (string str in serverProperties)
                {
                    if (str.Contains("server-port="))
                    {
                        settingsPortTextBox.Text = str.Replace("server-port=", "");
                        mainPortLabel.Text = str.Replace("server-port=", "");
                    }
                    else if (str.Contains("server-ip="))
                    {
                        settingsIpTextBox.Text = str.Replace("server-ip=", "");
                        mainIpLabel.Text = str.Replace("server-ip=", "");
                    }
                    else if (str.Contains("level-name="))
                    {
                        settingsWorldTextBox.Text = str.Replace("level-name=", "");
                    }
                    else if (str.Contains("gamemode="))
                    {
                        settingsGamemodeComboBox.Text = str.Replace("gamemode=", "");
                    }
                    else if (str.Contains("max-players="))
                    {
                        settingsPlayersTextBox.Text = str.Replace("max-players=", "");
                    }
                    else if (str.Contains("server-name="))
                    {
                        settingsNameTextBox.Text = str.Replace("server-name=", "");
                    }
                    else if (str.Contains("motd="))
                    {
                        settingsMotdTextBox.Text = str.Replace("motd=", "");
                    }
                }
            }

            //Get maximum amount of RAM in the system
            ComputerInfo computerInfo = new ComputerInfo();
            ulong totalPhysicalMemory = computerInfo.TotalPhysicalMemory;
            int maxRamInMB = (int)(totalPhysicalMemory / (1024 * 1024));

            ramSlider.Maximum = maxRamInMB;
            ramNumber.Maximum = maxRamInMB;

            string startBat = File.ReadAllText(location + "\\start.bat"); //Read start.bat file

            if (startBat.Contains("-Xmx") || startBat.Contains("-Xms")) //Check if the server has "-Xmx" or "-Xms"
            {
                string[] words = startBat.Split(' '); //Grab each word
                string xmx = ""; //The xmx/xms value

                foreach (string word in words)
                {
                    if (word.Contains("-Xmx"))
                    {
                        xmx = word;
                        break;
                    }
                    else if (word.Contains("-Xms"))
                    {
                        xmx = word;
                    }
                }

                int ram = int.Parse(xmx.Replace("-Xmx", "").Replace("-Xms", "").Replace("M", ""));
                ramSlider.Value = ram;
                ramNumber.Value = ram;

                this.ramAmount = ram;
            }
            else
            {
                ramSlider.Value = 512;
                ramNumber.Value = 512;
            }
        }

        private void InitializeJar()
        {
            if (loadJarSelection.initializeJar(this, serverJarCombo))
            {
                jarSelectionChanged = true;
            }
        }

        private void InitializeTheme()
        {
            Theme.initializeTheme(this, serverTabsPanel, menuStrip1);

            //Make CPU/Ram labels invisible
            cpuUsageLabel.Visible = false;
            ramUsageLabel.Visible = false;
        }

        public static void InitializeThemeStatic(Terminal instance)
        {
            instance.InitializeTheme();
        }

        private void InitializeFiles()
        {
            string name = this.Name;
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ($"\\CraftForge\\Servers\\{name}\\");

            AddFiles.initializeFiles(folderList, location, name);
        }

        private void InitializeBackupFiles()
        {
            //Send the backup label to the back
            backupLabel.SendToBack();

            string name = this.Name;
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ($"\\CraftForge\\Backups\\{name}\\");

            //Check if location exists
            if (Directory.Exists(location))
            {
                AddFiles.initializeFiles(backupFolderList, location, name);
            }
        }

        private void InitializeNotifications()
        {
            notifications = new NotifyIcon
            {
                Icon = SystemIcons.Application,
                Text = "CraftForge",
                Visible = false //Don't show the icon
            };
        }

        private void InitializeTerminalContextMenu()
        {
            if (Settings.Default.terminal_autoScroll)
            {
                autoScrollToolStripMenuItem.Checked = true;
            }
            else
            {
                autoScrollToolStripMenuItem.Checked = false;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            generateNewServer createNewServer = new generateNewServer();

            //generateNewServer.create(nameTextBox.Text, IpTextBox.Text, portTextBox.Text, motdTextBox.Text, statusLabel);
        }

        private void serverStatusNetwork_Tick(object sender, EventArgs e)
        {
            //childProcessID = Java Process
            try
            {
                //Check to see if the Process ID is running
                Process process = Process.GetProcessById(childProcessID); //If the process is not running, it will throw an exception "ArgumentException"

                isRunning = true;
            }
            catch (ArgumentException)
            {
                isRunning = false; //Process has exited
            }

            if (!isRunning)
            {
                cpuRamUsage.Enabled = false;
            }
            else
            {
                if (!cpuRamUsage.Enabled)
                {
                    cpuRamUsage.Enabled = true;
                }
            }

            resetButtons();
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            if (jarSelectionChanged)
            {
                createNewLog.sendMessage(this, "[Settings] Updating Jar");
                //Grab this.name and remove anything after :
                string[] name = this.Name.Split(':');

                string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("/CraftForge/Servers/" + name[0]);

                //Read start.bat file
                string text = File.ReadAllText(location + "\\start.bat");

                //Check if the server contains ".jar", and if it matches the serverJarCombo
                string[] words = text.Split(' ');
                string textJar = "";

                foreach (string word in words)
                {
                    if (word.Contains(".jar"))
                    {
                        textJar = word;
                        break; // Exit the loop once the word is found
                    }
                }

                string runFile = string.Join(" ", words);
                if (!string.IsNullOrEmpty(textJar))
                {
                    runFile = string.Join(" ", words).Replace(textJar, serverJarCombo.Text);
                }
                else
                {
                    //User has not added the jar file to the start.bat file (Broken File)
                    runFile = string.Join(" ", words).Replace("-jar", "-jar " + serverJarCombo.Text);
                }

                //Check if it matches the serverJarCombo
                if (textJar != serverJarCombo.Text)
                {
                    //Rewrite the start.bat file
                    File.WriteAllText(location + "\\start.bat", runFile);
                    createNewLog.sendMessage(this, "[Settings] Updated Jar");
                }
                jarSelectionChanged = false; //Reset the variable to false incase the user reboots the server
            }

            createNewLog.sendMessage(this, "[Server] Server is starting");

            Process serverProcess = new Process();
            object processLock = new object();
            int consoleID = 0;

            //Start the server
            createOutput(serverProcess, processLock, consoleID);

            this.startBtn.Enabled = false;
            this.stopBtn.Enabled = false;

            //Make CPU/Ram labels visible
            cpuUsageLabel.Visible = true;
            ramUsageLabel.Visible = true;
            serverStatusNetwork.Start();
            createNewLog.sendMessage(this, "[Server] Server has started");
        }

        //Use async (another thread) - will be multiple instances of the server, and maybe different windows (in the future)
        public async void createOutput(Process serverProcess, object processLock, int consoleID)
        {
            try
            {
                //Grab this.name and remove anything after :
                string[] name = this.Name.Split(':');

                // Set the working directory to the location of the start.bat file
                string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Servers\\" + name[0]);

                cpuRamUsage.Enabled = true;

                //Run the task in a new thread (uses 1 thread to maximize performance for server instance)
                //This also makes the console load faster, and the form does not freeze
                await Task.Run(() =>
                {
                    lock (processLock) //Use 1 thread to maximize performance for server instance
                    {
                        serverProcess.StartInfo = new ProcessStartInfo //Generate the process info
                        {
                            FileName = "cmd.exe",
                            WorkingDirectory = directory,
                            Arguments = "/c title Minecraft Server && start.bat",
                            WindowStyle = ProcessWindowStyle.Normal,
                            CreateNoWindow = false,
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            RedirectStandardInput = true,
                            RedirectStandardError = true,
                        };

                        serverProcess.OutputDataReceived += async (sender, e) => //When the server outputs something
                        {
                            if (!string.IsNullOrEmpty(e.Data)) //Check if the output is not empty
                            {
                                //Check each richTextBox and append the output to the correct one
                                for (int i = 0; i < serverTabs.TabPages.Count; i++)
                                {
                                    if (serverTabs.TabPages[i].Name == "consoleTab " + consoleID)
                                    {
                                        try
                                        {
                                            RichTextBox console = (RichTextBox)serverTabs.TabPages[i].Controls[0];
                                            secondaryTerminal.Name = "console " + consoleID;

                                            AppendTextToCommandOutput(e.Data, console, secondaryTerminal, false, this);

                                            if (Properties.Settings.Default.terminal_autoScroll)
                                            {

                                                if (console.InvokeRequired)
                                                {
                                                    console.Invoke(new Action(() => console.ScrollToCaret()));
                                                    secondaryTerminal.Invoke(new Action(() => secondaryTerminal.ScrollToCaret()));

                                                }
                                                else
                                                {
                                                    console.ScrollToCaret();
                                                    secondaryTerminal.ScrollToCaret();
                                                }
                                            }

                                            switch (e.Data)
                                            {
                                                //Check if /stop command has been run
                                                case string data when data.Contains("Stopping the server"):
                                                    //Grab player name
                                                    string[] words = e.Data.Split(' ');
                                                    //grab the first word
                                                    string playerName = words[2].Replace("[", "").Replace(":", "");

                                                    if (playerName.Equals("Stopping"))
                                                    {
                                                        playerName = "Console";
                                                    }
                                                    //Check if player name is empty
                                                    if (string.IsNullOrEmpty(playerName))
                                                    {
                                                        playerName = "Unknown";
                                                    }

                                                    //Send message to console
                                                    createNewLog.sendMessage(this, $"[Server] Server has been stopped by {playerName}");
                                                    break;
                                                case string data when data.Contains("INFO]: UUID of player "):
                                                    playerAddPanel.playerJoined(e.Data, this, playerList, serverProcess, serverTabs, consoleID);
                                                    break;
                                                case string data when data.Contains(" lost connection: "):
                                                    playerRemovePanel.playerLeft(e.Data, this, playerList, serverProcess, serverTabs, consoleID);
                                                    break;
                                                case string data when data.Contains("Disconnecting "):
                                                    playerRemovePanel.playerBanned(e.Data, this, playerList, serverProcess, serverTabs, consoleID);
                                                    break;
                                            }
                                        }
                                        catch (ArgumentOutOfRangeException)
                                        {
                                            continue; //Ignore the error (Probably closed)
                                        }
                                    }
                                }
                            }
                        };

                        serverProcess.ErrorDataReceived += (sender, e) =>
                        {
                            if (!string.IsNullOrEmpty(e.Data))
                            {
                                //Check each richTextBox and append the output to the correct one
                                for (int i = 0; i < serverTabs.TabPages.Count; i++)
                                {
                                    if (serverTabs.TabPages[i].Name == "consoleTab " + consoleID)
                                    {
                                        RichTextBox console = (RichTextBox)serverTabs.TabPages[i].Controls[0];

                                        //Check if Error contains "openjdk"
                                        if (e.Data.ToLower().Contains("openjdk"))
                                        {
                                            AppendTextToCommandOutput("[CraftForge JAVA] " + e.Data, console, secondaryTerminal, false, this);
                                        }
                                        else
                                        {

                                            ErrorMessage errorMessage = new ErrorMessage();
                                            if (errorMessage.grabErrorMessage(e.Data, console, secondaryTerminal))
                                            {
                                                // Stop process, to optimize performance because there is no point keeping it running
                                                if (serverProcesses.TryGetValue(consoleID, out Process process))
                                                {
                                                    if (!process.HasExited)
                                                    {
                                                        process.Kill();
                                                        serverProcesses.Remove(consoleID);
                                                    }
                                                }
                                            };
                                        }
                                    }
                                }
                            }
                        };

                        serverProcess.Start(); //Start the process

                        // Get the child process named java.exe started by the batch file

                        Process javaProcess = null;

                        Task.Delay(1000).Wait(); // Wait for 1 second before I start due to slower computers not opening instantly

                        while (javaProcess == null)
                        {
                            javaProcess = GetChildProcesses(serverProcess.Id).FirstOrDefault(p => string.Equals(p.ProcessName, "java", StringComparison.OrdinalIgnoreCase));
                            if (javaProcess == null)
                            {
                                Task.Delay(1000).Wait(); // Wait for 1 second before the next attempt
                            }
                        }

                        int javaProcessId = javaProcess.Id;
                        childProcessID = javaProcess.Id;

                        serverProcess.BeginErrorReadLine(); //Start reading the errors
                        serverProcess.BeginOutputReadLine(); //Start reading the output

                        //Multi-threading:

                        //Read serverSettings and grab the thread count
                        serverSettings settings = serverSettings.ReadSettings(this.Name);

                        int threadsCount = Int16.Parse(settings.threadAmount);

                        //Check if threadCount is more than 0, or it uses all cores
                        if (threadsCount > 0)
                        {
                            //Set the affinity
                            setAffinity.SetProcessAffinity(serverProcess, Process.GetProcessById(childProcessID), threadsCount, this);
                        }

                        consoleID = serverProcess.Id; //Get the console ID, so we can close it later

                        //Set stop button name as the console ID
                        this.cmdID = consoleID;
                        serverProcesses.Add(this.cmdID, serverProcess); //Add the process to the dictionary
                        serverProcessesToName.Add(serverProcess, this.Name); //Add the process name to the dictionary

                        //Add to tab
                        createConsole createConsole = new createConsole();
                        createConsole.createConsoleInTab(this, serverProcess, consoleID, this);

                        tabButtons.resetSideBarButtons(serverTabsPanel, serverTabs);

                        serverProcess.WaitForExit(); //Wait for the process to exit
                                                     //Make sure it inputs a space so it fully exits
                        serverProcesses.Remove(consoleID); //Remove the process from the dictionary after it has exited
                    }
                }).ConfigureAwait(false); //Improves performance (Seems to load console faster)
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        public void resetButtons()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(resetButtons));
            }

            Terminal terminal = this;

            if (this.isRunning)
            {
                terminal.stopBtn.Enabled = true;
                terminal.startBtn.Enabled = false;
            }
            else
            {
                terminal.stopBtn.Enabled = false;
                terminal.startBtn.Enabled = true;
            }
        }

        public static void AppendTextToCommandOutput(string text, RichTextBox consoleOutput, RichTextBox secondaryOutput, bool isSecondary, Terminal terminal)
        {
            //Check to see if it contains "! For help, type "help"
            if (text.Contains("! For help, type \"help\"") || text.Contains("Done ("))
            {
                //Server is running
                //Append to console
                consoleOutput.Invoke((MethodInvoker)delegate
                {
                    consoleOutput.AppendText("\n");
                    consoleOutput.AppendText("[CraftForge INFO] Server has started!\n");

                    secondaryOutput.AppendText("\n");
                    secondaryOutput.AppendText("[CraftForge INFO] Server has started!\n");
                });
                return;
            }
            if (!isSecondary)
            {
                if (text.Contains("ERROR]"))
                {
                    //Instance already running
                    //Parse Error Message
                    ErrorMessage errorMessage = new ErrorMessage();
                    if (errorMessage.grabErrorMessage(text, consoleOutput, secondaryOutput))
                    {
                        // Stop process, to optimize performance because there is no point keeping it running
                        int consoleID = Convert.ToInt32(consoleOutput.Name.Replace("console ", ""));
                        if (serverProcesses.TryGetValue(consoleID, out Process serverProcess))
                        {
                            if (!serverProcess.HasExited)
                                serverProcess.Kill();
                            serverProcesses.Remove(consoleID);
                        }
                    };
                }

                if (text.Contains("INFO]"))
                {
                    //Grab Process ID
                    int consoleID = Convert.ToInt32(consoleOutput.Name.Replace("console ", ""));

                    string serverName = null;
                    string location = null;
                    try
                    {
                        serverName = serverProcessesToName[serverProcesses[consoleID]];
                        location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Servers\\" + serverName);
                    }
                    catch { }

                    InfoMessage infoMessage = new InfoMessage();

                    if (infoMessage.grabInfoMessage(text, consoleOutput, secondaryOutput, location))
                    {
                        // Stop process, to optimize performance because there is no point keeping it running

                        if (serverProcesses.TryGetValue(consoleID, out Process serverProcess))
                        {
                            if (!serverProcess.HasExited)
                                serverProcess.Kill();
                            serverProcesses.Remove(consoleID);
                        }
                    };
                }

                if (text.Contains("WARN]"))
                {
                    WarnMessage warnMessage = new WarnMessage();
                    if (warnMessage.grabWarnMessage(text, consoleOutput, secondaryOutput))
                    {
                        // Stop process, to optimize performance because there is no point keeping it running
                        int consoleID = Convert.ToInt32(consoleOutput.Name.Replace("console ", ""));
                        if (serverProcesses.TryGetValue(consoleID, out Process serverProcess))
                        {
                            serverProcess.Kill();
                            serverProcesses.Remove(consoleID);
                        }
                    };
                }
            }

            try
            {
                if (consoleOutput.InvokeRequired)
                {
                    consoleOutput.Invoke((MethodInvoker)delegate
                    {
                        consoleOutput.AppendText(Environment.NewLine + text);

                        secondaryOutput.AppendText(Environment.NewLine + text);
                    });
                }
                else
                {
                    consoleOutput.AppendText(Environment.NewLine + text);

                    secondaryOutput.AppendText(Environment.NewLine + text);
                }
            }
            catch { }
        }

        private static Process[] GetChildProcesses(int parentId)
        {
            var query = $"SELECT * FROM Win32_Process WHERE ParentProcessId={parentId}";
            var searcher = new ManagementObjectSearcher(query);
            var results = searcher.Get();

            var returnProcess = results.Cast<ManagementObject>().Select(p => Process.GetProcessById(Convert.ToInt32(p["ProcessId"]))).ToArray();

            //Check if returnProcess is running

            return returnProcess;
        }

        private void startupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Startup startup = new Startup();
            startup.Show();
        }

        private async void stopBtn_Click(object sender, EventArgs e)
        {
            if (Settings.Default.stopBtnWarning)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to stop the server?", "CraftForge", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            createNewLog.sendMessage(this, "[Server] Server is stopping...");
            try
            {
                //Grab name of button
                int consoleID = Convert.ToInt32(this.cmdID); //Name is process ID
                Process serverProcess = serverProcesses[consoleID];

                //Run /stop command
                //Grab serverInstance
                enterCommand.runCommand("/stop", serverProcess, this.serverTabs, consoleID, this);
                enterCommand.runCommand("stop", serverProcess, this.serverTabs, consoleID, this);

                createNewLog.sendMessage(this, "[Server] Server is stopping");
                //Wait for the server to stop
                while (this.isRunning)
                {
                    // Wait 0.5 second
                    await Task.Run(async () => await Task.Delay(500));
                }

                //add to terminal the server has stopped
                secondaryTerminal.AppendText("\n[CraftForge INFO] Server has stopped\n");
                createNewLog.sendMessage(this, "[Server] Server has stopped");

                if (this.formClosing)
                    this.Close();
            }
            catch (Exception ex)
            {
                createNewLog.sendMessage(this, $"[Server] An error has occurred: {ex}");
            }
        }

        private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open location
            string[] name = this.Name.Split(':');
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Servers\\" + name[0]);

            Process.Start("explorer.exe", location);
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            createNewLog.sendMessage(this, "[Settings] Updating settings");
            //Grab old server name
            string oldName = this.Name;
            string oldDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + string.Format("\\CraftForge\\Servers\\{0}", oldName);

            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + string.Format("\\CraftForge\\Servers\\{0}", settingsNameTextBox.Text);
            bool moveServer = false;

            //Check if directory and oldDirectory has changed
            //No need to move if they are the same
            if (!oldDirectory.Equals(directory))
            {
                moveServer = true;
            }

            if (moveServer)
            {
                try
                {
                    //Check if directory and oldDirectory has changed
                    //No need to move if they are the same
                    if (oldDirectory != directory)
                    {
                        //Check if directory exists
                        if (Directory.Exists(directory))
                        {
                            SettingsStatusLabel.Text = "Error moving server! Server already exists!";
                            return;
                        }
                    }

                    //Check if server is open
                    try
                    {
                        if (serverProcesses.ContainsKey(this.cmdID))
                        {

                            SettingsStatusLabel.Text = "Error moving server! Server is open!";
                            return;
                        }
                    }
                    catch (FormatException) { }
                }
                catch (Exception IOException)
                {
                    if (IOException.Message.Contains("The process cannot access the file because it is being used by another process"))
                    {
                        SettingsStatusLabel.Text = "Error moving server! Server is open!";
                        return;
                    }
                    else if (IOException.Message.Contains("The directory is not empty"))
                    {
                        SettingsStatusLabel.Text = "Error moving server! Server already exists!";
                        return;
                    }

                    SettingsStatusLabel.Text = "Error moving server! " + IOException.Message;
                    return;
                }

                createNewLog.sendMessage(this, "[Settings] Updating Directory");
                createNewLog.sendMessage(this, $"[Settings] {oldDirectory} --> {directory}");

                //Move the directory
                await CopyDirectoryWithProgressBar(oldDirectory, directory, SettingsStatusLabel, true, SettingsProgressBar, "move");
                InitializeFiles();
                InitializeBackupFiles();
                createNewLog.sendMessage(this, "[Settings] Updated Directory");
            }

            if (!moveServer)
            {
                File.WriteAllText(directory + "\\server.properties", "server-port=" + settingsPortTextBox.Text + "\n" + "server-ip=" + settingsIpTextBox.Text + "\n" + "level-name=" + settingsWorldTextBox.Text + "\n" + "gamemode=" + settingsGamemodeComboBox.Text + "\n" + "difficulty=easy\n" + "allow-cheats=false\n" + "max-players=" + settingsPlayersTextBox.Text + "\n" + "online-mode=true\n" + "white-list=false\n" + "server-name=" + settingsNameTextBox.Text + "\n" + "motd=" + settingsMotdTextBox.Text + "\n");
            }

            if (threadCount.Value != threadAmount)
            {
                updateThreads.UpdateThreads(this.Name, (int)threadCount.Value);
                createNewLog.sendMessage(this, $"[Settings] Updated Threads from {threadAmount} to {threadCount.Value}");
                threadAmount = (int)threadCount.Value;
            }

            //Reset the main text
            mainIpLabel.Text = settingsIpTextBox.Text;
            mainPortLabel.Text = settingsPortTextBox.Text;

            updateRam();

            createNewLog.sendMessage(this, "[Settings] Server updated!");
            SettingsStatusLabel.Text = "Server updated!";
        }

        private void updateRam()
        {
            if (ramSlider.Value == ramAmount) return; //The ram value has not changed

            createNewLog.sendMessage(this, $"[Settings] Updated Ram from {ramAmount}MB to {ramSlider.Value}MB");

            ramAmount = ramSlider.Value;

            //Read server.properties file
            string[] name = this.Name.Split(':');

            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Servers\\" + name[0]);

            //Grab start.bat file
            string startBat = File.ReadAllText(location + "\\start.bat"); //Read start.bat file

            if (startBat.Contains("-Xmx")) //Check if the server has "-Xmx" or "-Xms"
            {
                string[] words = startBat.Split(' '); //Grab each word
                string xmx = ""; //The xmx/xms value

                foreach (string word in words)
                {
                    if (word.Contains("-Xmx"))
                    {
                        xmx = word;
                        break;
                    }
                    else if (word.Contains("-Xms"))
                    {
                        xmx = word;
                    }
                }

                string newRam = $"-Xmx{ramAmount}M";
                string newStartBat = startBat.Replace(xmx, newRam);

                //Rewrite the start.bat file
                File.WriteAllText(location + "\\start.bat", newStartBat);
            }
            else
            {
                //Reset the start.bat file
                startBatFile.resetFile(this, location, ramAmount, serverJarCombo.Text.Replace(".jar", ""));
            }
        }

        //First time setup is for when the server is first created, and needs to create the necessary files
        private async Task<bool> CopyDirectoryWithProgressBar(string sourceDir, string destDir, Label label, bool firstTimeSetup, ProgressBar progressBar, string type)
        {

            label.BringToFront();

            Directory.CreateDirectory(destDir);

            string[] files = Directory.GetFiles(sourceDir, "*", SearchOption.AllDirectories);
            int totalFiles = files.Length;
            int copiedFiles = 0;
            int couldNotCopyFiles = 0;

            foreach (string file in files)
            {
                string destFile = file.Replace(sourceDir, destDir);
                string destFileDir = Path.GetDirectoryName(destFile);
                Directory.CreateDirectory(destFileDir);
                try
                {
                    using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        await Task.Run(() => File.Copy(file, destFile));
                    }
                }
                catch (IOException ioEx) when (ioEx.Message.Contains("already exists"))
                {
                    // If the file already exists, continue to the next file
                    createNewLog.sendMessage(this, $"[Settings] Could not copy {file}: {ioEx.Message}");
                    couldNotCopyFiles++;
                }
                catch (DirectoryNotFoundException)
                {
                    //Add to logs that the directory was not found
                    createNewLog.sendMessage(this, $"[Settings] Directory not found: {file}");
                    couldNotCopyFiles++;
                }
                catch (Exception e)
                {
                    createNewLog.sendMessage(this, $"[Settings] Could not copy {file}: {e.Message}");
                    couldNotCopyFiles++;
                }
                copiedFiles++;
                int progress = (int)((double)copiedFiles / totalFiles * 100);
                progressBar.Value = progress;

                //Set status label
                if (label.IsHandleCreated)
                {
                    label.Invoke((MethodInvoker)delegate
                {
                    //Check if type is "move"
                    if (type == "move")
                    {
                        label.Text = string.Format("Please do not touch the application!\nMoving server - {0}\n{1}% ({2}/{3}/{4})", file, progress, copiedFiles, totalFiles, couldNotCopyFiles);
                    }
                    else if (type == "backup")
                    {
                        label.Text = string.Format("Please do not touch the application!\nCreating backup - {0}\n{1}% ({2}/{3}/{4})", file, progress, copiedFiles, totalFiles, couldNotCopyFiles);
                    }
                });
                }

                //Wait for it to finish, and then reset the progress bar
                if (progressBar.Value == 100)
                {
                    //Wait 1 second
                    await Task.Delay(1000); // Bugs out on smaller servers without sleeping for 1 second
                    progressBar.Value = 0; //Reset progress bar

                    //Reload the files to display them in the flowLayoutPanel
                    InitializeBackupFiles();

                    //Send label to back
                    label.SendToBack();

                    if (type == "backup")
                    {
                        copiedFiles -= couldNotCopyFiles;
                        createNewLog.sendMessage(this, $"[Backup] {copiedFiles} has been copied");
                        createNewLog.sendMessage(this, $"[Backup] {couldNotCopyFiles} could not be copied");
                    }
                }
            }

            if (firstTimeSetup)
            {
                await Task.Delay(1000); // Add a delay before deleting the directory
                if (Directory.Exists(sourceDir))
                {
                    await deleteDirectory(sourceDir);
                }

                copiedFiles -= couldNotCopyFiles;
                createNewLog.sendMessage(this, $"[Settings] {copiedFiles} has been copied");
                createNewLog.sendMessage(this, $"[Settings] {couldNotCopyFiles} could not be copied");

                label.Text = "Server moved!";
                this.Name = settingsNameTextBox.Text;
                this.Text = this.Name + $" | CraftForge {Startup.release} - v{Startup.applicationVersion}"; //Change this if I change title again (ctrl+f)

                updateThreads.UpdateThreads(this.Name, (int)threadCount.Value);

                //Check if server.properties exists
                if (!File.Exists(destDir + "\\server.properties"))
                {
                    File.WriteAllText(destDir + "\\server.properties", "server-port=" + settingsPortTextBox.Text + "\n" + "server-ip=" + settingsIpTextBox.Text + "\n" + "level-name=world\n" + "gamemode=survival\n" + "difficulty=easy\n" + "allow-cheats=false\n" + "max-players=" + settingsPlayersTextBox.Text + "\n" + "online-mode=true\n" + "white-list=false\n" + "server-name=" + settingsNameTextBox.Text + "\n" + "motd=" + settingsMotdTextBox.Text + "\n");
                }
                else
                {
                    //Update server.properties
                    string[] serverProperties = File.ReadAllLines(destDir + "\\server.properties");
                    List<string> doesNotContain = new List<string> { "server-port=", "server-ip=", "level-name=", "gamemode=", "max-players=", "server-name=", "motd=" };

                    foreach (string str in serverProperties)
                    {

                        if (str.Contains("server-port="))
                        {
                            serverProperties[Array.IndexOf(serverProperties, str)] = "server-port=" + settingsPortTextBox.Text;
                            doesNotContain.Remove("server-port=");
                        }
                        else if (str.Contains("server-ip="))
                        {
                            serverProperties[Array.IndexOf(serverProperties, str)] = "server-ip=" + settingsIpTextBox.Text;
                            doesNotContain.Remove("server-ip=");
                        }
                        else if (str.Contains("level-name="))
                        {
                            serverProperties[Array.IndexOf(serverProperties, str)] = "level-name=" + settingsWorldTextBox.Text;
                            doesNotContain.Remove("level-name=");
                        }
                        else if (str.Contains("gamemode="))
                        {
                            serverProperties[Array.IndexOf(serverProperties, str)] = "gamemode=" + settingsGamemodeComboBox.Text;
                            doesNotContain.Remove("gamemode=");
                        }
                        else if (str.Contains("max-players="))
                        {
                            serverProperties[Array.IndexOf(serverProperties, str)] = "max-players=" + settingsPlayersTextBox.Text;
                            doesNotContain.Remove("max-players=");
                        }
                        else if (str.Contains("server-name="))
                        {
                            serverProperties[Array.IndexOf(serverProperties, str)] = "server-name=" + settingsNameTextBox.Text;
                            doesNotContain.Remove("server-name=");
                        }
                        else if (str.Contains("motd="))
                        {
                            serverProperties[Array.IndexOf(serverProperties, str)] = "motd=" + settingsMotdTextBox.Text;
                            doesNotContain.Remove("motd=");
                        }
                    }

                    foreach (string str in doesNotContain)
                    {
                        if (str.Equals("server-port="))
                        {
                            Array.Resize(ref serverProperties, serverProperties.Length + 1);
                            serverProperties[serverProperties.Length - 1] = "server-port=" + settingsPortTextBox.Text;
                            createNewLog.sendMessage(this, "[Properties] Created new Server Port");
                        }
                        else if (str.Equals("server-ip="))
                        {
                            Array.Resize(ref serverProperties, serverProperties.Length + 1);
                            serverProperties[serverProperties.Length - 1] = "server-ip=" + settingsIpTextBox.Text;
                            createNewLog.sendMessage(this, "[Properties] Created new IP Address");
                        }
                        else if (str.Equals("level-name="))
                        {
                            Array.Resize(ref serverProperties, serverProperties.Length + 1);
                            serverProperties[serverProperties.Length - 1] = "level-name=" + settingsWorldTextBox.Text;
                            createNewLog.sendMessage(this, "[Properties] Created new World Name");
                        }
                        else if (str.Equals("gamemode="))
                        {
                            Array.Resize(ref serverProperties, serverProperties.Length + 1);
                            serverProperties[serverProperties.Length - 1] = "gamemode=" + settingsGamemodeComboBox.Text;
                            createNewLog.sendMessage(this, "[Properties] Created new GameMode");
                        }
                        else if (str.Equals("max-players="))
                        {
                            Array.Resize(ref serverProperties, serverProperties.Length + 1);
                            serverProperties[serverProperties.Length - 1] = "max-players=" + settingsPlayersTextBox.Text;
                            createNewLog.sendMessage(this, "[Properties] Created new Max Players");
                        }
                        else if (str.Equals("server-name="))
                        {
                            Array.Resize(ref serverProperties, serverProperties.Length + 1);
                            serverProperties[serverProperties.Length - 1] = "server-name=" + settingsNameTextBox.Text;
                            createNewLog.sendMessage(this, "[Properties] Created new Server Name");
                        }
                        else if (str.Equals("motd="))
                        {
                            Array.Resize(ref serverProperties, serverProperties.Length + 1);
                            serverProperties[serverProperties.Length - 1] = "motd=" + settingsMotdTextBox.Text;
                            createNewLog.sendMessage(this, "[Properties] Created new MOTD");
                        }
                    }

                    //save file
                    File.WriteAllLines(destDir + "\\server.properties", serverProperties);
                }
            }
            return true;
        }

        private async Task<bool> deleteDirectory(string path)
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Directory.Delete(path, true);
                    return true;
                }
                catch (IOException)
                {
                    await Task.Delay(1000);
                }
            }
            return false;
        }
        private void openLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Most recent logs
            string[] name = this.Name.Split(':');
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Servers\\" + name[0] + "\\logs\\latest.log");

            Process.Start("notepad.exe", location);
        }

        private void serverJarCombo_Click(object sender, EventArgs e)
        {
            //Grab location
            string[] name = this.Name.Split(':');
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Servers\\" + name[0]);

            //Grab all files in the directory, with the extension .jar
            string[] files = Directory.GetFiles(location, "*.jar");
            serverJarCombo.Items.Clear();

            // Add just the name of the file
            foreach (string file in files)
            {
                serverJarCombo.Items.Add(Path.GetFileName(file));
            }
        }

        private void serverJarCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            jarSelectionChanged = true;
        }

        private void secondaryTerminalInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressEventArgs keyPress = (KeyPressEventArgs)e;
            
            //Clear the text
            if (keyPress.KeyChar == (char) Keys.Escape)
            {
                secondaryTerminalInput.Text = string.Empty;
                keyPress.Handled = true;
                return;
            }

            //Enter command
            if (keyPress.KeyChar == (char)Keys.Enter)
            {
                // Grab consoleID
                string consoleIDString = secondaryTerminal.Name.Replace("console ", "");
                if (int.TryParse(consoleIDString, out int consoleID))
                {
                    // Grab serverProcess
                    if (serverProcesses.TryGetValue(consoleID, out Process serverProcess))
                    {
                        // Run command
                        enterCommand.runCommand(secondaryTerminalInput.Text, serverProcess, this.serverTabs, consoleID, this);

                        // Clear text
                        secondaryTerminalInput.Text = string.Empty;
                        keyPress.Handled = true; //Remove the beeping sound when hitting enter
                        return;
                    }
                }

                // Clear Text
                secondaryTerminalInput.Text = string.Empty;

                //Display console is not running in main console
                secondaryTerminal.AppendText("Server is not running!\n");
                keyPress.Handled = true;
            }
        }

        private async void createBackupBtn_Click(object sender, EventArgs e)
        {
            createNewLog.sendMessage(this, "[Backup] Creating backup");
            //Bring backupLabel to top 
            backupLabel.BringToFront();
            //Copy files to ../BackUp/ServerName/BakcupDate-dd-mm-yyyy-hh-mm-ss

            //Grab this.name and remove anything after :
            string[] name = this.Name.Split(':');
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Servers\\" + name[0]);

            //Grab day
            string time = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");

            //Check if directory exists
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Backups\\" + name[0] + "\\" + time)))
            {
                //Create directory
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Backups\\" + name[0] + "\\" + time));
            }
            else
            {
                return; //Backup already exists
            }

            //Copy files
            await CopyDirectoryWithProgressBar(location, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Backups\\" + name[0] + "\\" + time), backupLabel, false, backupProgressBar, "backup");
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            notifyIcon.showClosedWindows();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openSettings.runSettingsApp();
        }

        private void customizeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openThemesEditor.runThemesEditorApp();
        }

        private int cpuUsageCounter = 0;
        private void cpuUsage_Tick(object sender, EventArgs e)
        {
            //Grab the process name from stopbtn
            try
            {
                Process process = Process.GetProcessById(childProcessID);
                this.cpuUsageLabel.Text = GetCurrentProcessCpuUsage(process).ToString() + "%";

                //Grab ram amount from process
                this.ramUsageLabel.Text = (process.WorkingSet64 / 1024 / 1024).ToString() + " MB"; //Convert to MB
            }
            catch (ArgumentException)
            {
                this.cpuUsageLabel.Text = "0%"; //Set to 0% if it runs into an exception
                this.ramUsageLabel.Text = "0 MB"; //Set to 0 MB if it runs into an exception
            }

            //CPU Usage Chart

            Series cpuSeries = cpuUsageChart.Series["CPU Usage"];

            if (cpuSeries.Points.Count >= 6) //Keep 6 points, which shows all of the points without scrolling / changing the size of the chart
            {
                //Set minimum value
                this.cpuUsageChart.ChartAreas[0].AxisX.Minimum = cpuUsageCounter - 6; //Grab the counter and subtract 6, so it shows the last 6 points
                //Set maximum value
                this.cpuUsageChart.ChartAreas[0].AxisX.Maximum = cpuUsageCounter; //Grab the counter, so it shows the current point, without an empty space at the end
            }

            //Remove % from the Label or it will not count as a nubmer properly
            cpuSeries.Points.AddXY(cpuUsageCounter, cpuUsageLabel.Text.Replace("%", "")); //Add the point to the chart

            //Ram Usage Chart
            Series ramSeries = ramUsageChart.Series["Ram Usage"];

            if (ramSeries.Points.Count >= 6) //Keep 6 points, which shows all of the points without scrolling / changing the size of the chart
            {
                //Set minimum value
                this.ramUsageChart.ChartAreas[0].AxisX.Minimum = cpuUsageCounter - 6; //Use the same counter as the CPU usage because it runs at the same time
                //Set maximum value
                this.ramUsageChart.ChartAreas[0].AxisX.Maximum = cpuUsageCounter;
            }

            ramSeries.Points.AddXY(cpuUsageCounter, ramUsageLabel.Text.Replace(" MB", "")); //Add the point to the chart

            this.cpuUsageCounter += 1;
        }

        public double totalCpuUsage = 0;
        private DateTime lastTime;
        private TimeSpan lastTotalProcessorTime;
        private DateTime curTime;
        private TimeSpan curTotalProcessorTime;

        public double GetCurrentProcessCpuUsage(Process process)
        {
            try
            {
                if (this.lastTime == default(DateTime))
                {
                    this.lastTime = DateTime.Now;
                    this.lastTotalProcessorTime = process.TotalProcessorTime;
                    return 0;
                }

                this.curTime = DateTime.Now;
                this.curTotalProcessorTime = process.TotalProcessorTime;

                double cpuUsedMs = (this.curTotalProcessorTime - this.lastTotalProcessorTime).TotalMilliseconds;
                double totalMsPassed = (curTime - lastTime).TotalMilliseconds;

                ProcessThreadCollection threads = process.Threads;


                double cpuUsageTotal = cpuUsedMs / (threads.Count * totalMsPassed) * 1000;

                // Add to the total CPU usage
                this.totalCpuUsage += cpuUsageTotal;

                // Update the last recorded time and processor time
                this.lastTime = this.curTime;
                this.lastTotalProcessorTime = this.curTotalProcessorTime;

                if (cpuUsageTotal > 100)
                {
                    return 100;
                }

                if (cpuUsageTotal < 0)
                {
                    return 0;
                }

                return Math.Round(cpuUsageTotal, 2);
            }
            catch
            {
                return 0;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutPage = new about();
            aboutPage.Show();
        }

        private void ramSlider_Scroll(object sender, EventArgs e)
        {
            ramNumber.Value = ramSlider.Value;
        }

        private void ramNumber_ValueChanged(object sender, EventArgs e)
        {
            ramSlider.Value = (int)ramNumber.Value;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Servers\\" + this.Name.Split(':')[0] + "\\server.properties");

            Process.Start("notepad.exe", fileLocation);
        }

        private void secondaryTerminalInput_Enter(object sender, EventArgs e)
        {
            if (secondaryTerminalInput.Text == "Enter Command")
            {
                secondaryTerminalInput.Text = string.Empty;
                secondaryTerminalInput.ForeColor = Color.Black;
            }
        }

        private void secondaryTerminalInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(secondaryTerminalInput.Text))
            {
                secondaryTerminalInput.ForeColor = Color.DimGray;
                secondaryTerminalInput.Text = "Enter Command";
            }
        }

        private void openThemesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open themes
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CraftForge\\Themes";

            Process.Start("explorer.exe", location);
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://craftforge.dev/index.php/category/help/"); //Open the help website
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show message box to confirm
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all themes?", "CraftForge", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                //Delete all themes
                string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CraftForge\\Themes";

                if (Directory.Exists(location))
                {
                    Directory.Delete(location, true);
                }

                Directory.CreateDirectory(location);
                Theme.createThemes();

                //Set theme to default
                Settings.Default.Theme = "Default";
                Settings.Default.Save();

                InitializeTheme();
            }
        }

        private void deleteAllTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox console = (RichTextBox)serverTabs.SelectedTab.Controls[0];
                console.Clear();
            }
            catch
            {
                //Assume it's selecting the chart, and using secondaryTerminal
                secondaryTerminal.Clear();
            }
        }

        private void autoScrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Revert the check
            if (autoScrollToolStripMenuItem.Checked == true)
                autoScrollToolStripMenuItem.Checked = false;
            else
                autoScrollToolStripMenuItem.Checked = true;

            //Grab the value
            bool autoScroll = autoScrollToolStripMenuItem.Checked;

            //Save the value
            Properties.Settings.Default.terminal_autoScroll = autoScroll;
            Properties.Settings.Default.Save();
        }

        private void saveTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save the text to /Documents/CraftForge/Logs/ServerName/Date-Time.txt
            string[] name = this.Name.Split(':');
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Logs\\" + name[0]);

            string fileName = ("\\" +DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".txt"); //Sets the date of the file

            if (!Directory.Exists(location))
                Directory.CreateDirectory(location);

            //Save the file in the main console
            try
            {
                RichTextBox console = (RichTextBox)serverTabs.SelectedTab.Controls[0];

                console.SaveFile(location + fileName, RichTextBoxStreamType.PlainText);
            }
            catch
            {
                //Save the file in the general(secondary) console
                secondaryTerminal.SaveFile(location + fileName, RichTextBoxStreamType.PlainText);
            }

            Process.Start(location + fileName); //Open the file
        }

        private void openLogsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] name = this.Name.Split(':');
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\CraftForge\\Logs\\" + name[0]);

            try
            {
                Process.Start(location); //Open the folder
            }
            catch { }
        }
    }
}
