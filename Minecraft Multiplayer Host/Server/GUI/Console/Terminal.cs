using Minecraft_Multiplayer_Host.Properties;
using Minecraft_Multiplayer_Host.Server.Classes;
using Minecraft_Multiplayer_Host.Server.Classes.Console.Applications;
using Minecraft_Multiplayer_Host.Server.Classes.Console.CreateConsole;
using Minecraft_Multiplayer_Host.Server.Classes.Console.Initialize.Files;
using Minecraft_Multiplayer_Host.Server.Classes.Console.Initialize.JarSelection;
using Minecraft_Multiplayer_Host.Server.Classes.Console.Yaml;
using Minecraft_Multiplayer_Host.Server.Classes.Console.Yaml.UpdateSettings;
using Minecraft_Multiplayer_Host.Server.Events;
using Minecraft_Multiplayer_Host.Server.GUI.Classes;
using Minecraft_Multiplayer_Host.Server.GUI.Console.Components;
using Minecraft_Multiplayer_Host.Server.GUI.Console.Messages.ERROR;
using Minecraft_Multiplayer_Host.Server.GUI.Console.Messages.INFO;
using Minecraft_Multiplayer_Host.Server.GUI.Console.Messages.WARN;
using Minecraft_Multiplayer_Host.Server.GUI.Setup;
using Minecraft_Multiplayer_Host.Server.Setup;
using Minecraft_Multiplayer_Host.Server.Themes.Classes.Applications;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.GUI.Console
{
    public partial class Terminal : Form
    {
        public static Dictionary<int, Process> serverProcesses = new Dictionary<int, Process>();
        bool isRunning = false; //If the server is running & user tries to open console, it will offer to open a new tab or replace the current one
        bool hasStarted = false; //Checks to see if the server is running & started with (! For help, type \"help")
        bool errorOccured = false; //If an error has occured, it will make sure the current form toggles buttons
        bool jarSelectionChanged = false; //If the user has changed the jar selection

        bool formClosing = false; //If the form is closing, alongside the stop button

        static string theme = Settings.Default.Theme;
        static string style = Settings.Default.Style;

        private static NotifyIcon notifications;

        static Dictionary<Process, string> serverProcessesToName = new Dictionary<Process, string>();

        public Terminal()
        {
            InitializeComponent();
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            this.stopBtn.Name = "";
            settingsNameTextBox.Text = this.Name;

            InitializeSettings(); //Load settings
            InitializeJar(); //Load jar selection text
            InitializeTheme(); //Load theme
            InitializeFiles(); //Load files
            InitializeBackupFiles(); //Load backup files
            InitializeNotifications(); //Load notifications

            serverTabs.ItemSize = new Size(0, 1); //Hide the tabs

            tabButtons.resetSideBarButtons(serverTabsPanel, serverTabs); //Generate the side bar buttons

            if (Settings.Default.terminal_autoStart)
                startBtn_Click(sender, e);

            //Grab maximum amount of cores
            int maxCores = Environment.ProcessorCount;

            //Check if settings file exists
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Servers\\");
            if (!File.Exists(($"{location}\\{this.Name}\\serverSettings.yaml"))) {
                serverSettings.writeSettingsToFile(this.Name);
            }
            var settings = serverSettings.ReadSettings(this.Name);
            int cores = Int16.Parse(settings.threadAmount);

            threadCount.Minimum = 0;
            threadCount.Maximum = maxCores;

            threadCount.Value = cores;
        }

        private async void Terminal_Close(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.stopBtn.Enabled == true && isRunning)
                {
                    //If the server is running, stop it (and wait for it to stop
                    e.Cancel = true;
                    formClosing = true;
                    stopBtn_Click(sender, e);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void InitializeSettings()
        {
            //Read server.properties file
            string[] name = this.Name.Split(':');

            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Servers\\" + name[0]);

            //Read server.properties file
            string[] serverProperties = File.ReadAllLines(location + "\\server.properties");

            //Set the text boxes
            //Read each line and set the text box
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

        private void InitializeJar()
        {
            if (loadJarSelection.initializeJar(this, serverJarCombo))
            {
                jarSelectionChanged = true;
            }
        }

        private void InitializeTheme()
        {
            Theme.initializeTheme(this, serverTabsPanel);

            //Check if this needs to be maximized
            if (Settings.Default.terminal_startMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        public static void InitializeThemeStatic(Terminal instance)
        {
            instance.InitializeTheme();
        }

        private void InitializeFiles()
        {
            string name = this.Name;
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ($"\\Minecraft-Multiplayer-Host\\Servers\\{name}\\");

            AddFiles.initializeFiles(folderList, location, name);
        }

        private void InitializeBackupFiles()
        {
            //Send the backup label to the back
            backupLabel.SendToBack();

            string name = this.Name;
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ($"\\Minecraft-Multiplayer-Host\\Backups\\{name}\\");

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
                Text = "Minecraft Multiplayer Host",
                Visible = false //Don't show the icon
            };
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            generateNewServer createNewServer = new generateNewServer();

            //generateNewServer.create(nameTextBox.Text, IpTextBox.Text, portTextBox.Text, motdTextBox.Text, statusLabel);
        }
        /*static bool sentStartNotification = false;
        static bool sentStopNotification = false; - Does not work with multiple windows*/
        private async void serverStatusNetwork_Tick(object sender, EventArgs e)
        {
            //Grab this.name and remove anything after :
            string[] name = this.Name.Split(':');

            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("/Minecraft-Multiplayer-Host/Servers/" + name[0]);

            //Assume the process has only started

            // Check if the server is running

            if (errorOccured)
            {
                isRunning = false;
                resetButtons();

                /*if (!sentStopNotification)
                {
                    notifications.Visible = true;
                    //Create notification
                    string serverName = this.Name.Split(':')[0];

                    notifications.BalloonTipText = $"{serverName} has been stopped!";
                    notifications.BalloonTipTitle = "Server Stopped";
                    notifications.BalloonTipIcon = ToolTipIcon.Info;
                    notifications.ShowBalloonTip(3);

                    sentStartNotification = false;
                    sentStopNotification = true;
                    notifications.Visible = false;
                }*/
                errorOccured = false;
                return;
            }

            if (hasStarted)
            {
                //Check if name is in serverCheckName
                //Grab all values and display them
                using (var client = new System.Net.Sockets.TcpClient())
                {
                    //Check if the server was running before
                    if (statusLabel.Text.Contains("Server is not running") || statusLabel.Text == null)
                    {
                        statusLabel.Text = "Connecting to the Server...";
                    }

                    //Wait until the output displays "! For help, type "help"

                    //Grab output

                    try
                    {
                        await client.ConnectAsync(settingsIpTextBox.Text, int.Parse(settingsPortTextBox.Text));
                        statusLabel.Text = $"Server is running at {location} | {settingsIpTextBox.Text}:{settingsPortTextBox.Text} : {this.Name}";

                        //Grab current process
                        int consoleID = Convert.ToInt32(this.stopBtn.Name);
                        Process serverProcess = serverProcesses[consoleID];

                        isRunning = true;
                        resetButtons();

                        /*if (!sentStartNotification)
                        {
                            notifications.Visible = true;
                            string serverName = this.Name.Split(':')[0];

                            notifications.BalloonTipText = $"{serverName} has started!";
                            notifications.BalloonTipTitle = "Server started";
                            notifications.BalloonTipIcon = ToolTipIcon.Info;
                            notifications.ShowBalloonTip(3);

                            sentStartNotification = true;
                            sentStopNotification = false;
                            notifications.Visible = false;
                        }*/
                    }
                    catch (Exception exception)
                    {
                        if (serverStatusNetwork.Interval != 10000) //Just started process!
                        {
                            statusLabel.Text = $"Server is not running! - {exception.Message}";

                            isRunning = false;
                            resetButtons();

                            /*if (!sentStopNotification)
                            {
                                notifications.Visible = true;
                                //Create notification
                                string serverName = this.Name.Split(':')[0];

                                notifications.BalloonTipText = $"{serverName} has been stopped!";
                                notifications.BalloonTipTitle = "Server Stopped";
                                notifications.BalloonTipIcon = ToolTipIcon.Info;
                                notifications.ShowBalloonTip(3);

                                sentStartNotification = false;
                                sentStopNotification = true;
                                notifications.Visible = false;
                            }*/
                        }
                    }
                    finally
                    {
                        serverStatusNetwork.Interval = 1000; // 10 seconds
                    }
                }
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (jarSelectionChanged)
            {
                //Grab this.name and remove anything after :
                string[] name = this.Name.Split(':');

                string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("/Minecraft-Multiplayer-Host/Servers/" + name[0]);

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
                }
                jarSelectionChanged = false; //Reset the variable to false incase the user reboots the server
            }

            Process serverProcess = new Process();
            object processLock = new object();
            int consoleID = 0;

            //Start the server
            createOutput(serverProcess, processLock, consoleID);

            //Button logic
            isRunning = true;
            hasStarted = false;
            errorOccured = false;

            this.startBtn.Enabled = false;
            this.stopBtn.Enabled = false;

            serverStatusNetwork.Start();
        }

        //Use async (another thread) - will be multiple instances of the server, and maybe different windows (in the future)
        public async void createOutput(Process serverProcess, object processLock, int consoleID)
        {
            //Grab this.name and remove anything after :
            string[] name = this.Name.Split(':');

            // Set the working directory to the location of the start.bat file
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Servers\\" + name[0]);

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
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardInput = true,
                        RedirectStandardError = true,
                    };

                    serverProcess.OutputDataReceived += (sender, e) => //When the server outputs something
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
                                        AppendTextToCommandOutput("[Minecraft-Multiplayer-Host JAVA] " + e.Data, console, secondaryTerminal, false, this);
                                    }
                                    else
                                    {

                                        ErrorMessage errorMessage = new ErrorMessage();
                                        if (errorMessage.grabErrorMessage(e.Data, console, secondaryTerminal))
                                        {
                                            //Kill process

                                            isRunning = false;
                                            errorOccured = true;

                                            //Toggle buttons
                                            resetButtons();

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
                        setAffinity.SetProcessAffinity(serverProcess, threadsCount, this);
                    }

                    consoleID = serverProcess.Id; //Get the console ID, so we can close it later

                    //Set stop button name as the console ID
                    this.stopBtn.Name = consoleID.ToString();
                    serverProcesses.Add(consoleID, serverProcess); //Add the process to the dictionary
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

        public void resetButtons()
        {
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
                    consoleOutput.AppendText("[Minecraft-Multiplayer-Host INFO] Server has started!\n");

                    secondaryOutput.AppendText("\n");
                    secondaryOutput.AppendText("[Minecraft-Multiplayer-Host INFO] Server has started!\n");
                });
                terminal.isRunning = true;
                terminal.hasStarted = true;

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
                        //Kill process

                        terminal.isRunning = false;
                        terminal.errorOccured = true;

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
                        location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Servers\\" + serverName);
                    }
                    catch { }

                    InfoMessage infoMessage = new InfoMessage();

                    if (infoMessage.grabInfoMessage(text, consoleOutput, secondaryOutput, location))
                    {
                        //Kill process

                        terminal.isRunning = false;
                        terminal.errorOccured = true;

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
                        //Kill process

                        terminal.isRunning = false;
                        terminal.errorOccured = true;

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

        private async void terminal_Close(object sender, EventArgs e)
        {
            // Unsubscribe from the FormClosed event
            this.FormClosed -= terminal_Close;

            //Remove from startup.instancesRunning
            Startup.instancesRunning.Remove(this.Name);

            //If instancesRunning is empty, close the form
            if (Startup.instancesRunning.Count == 0)
            {
                Application.Exit(); //Don't want people to think this is running in the background 😂
            }

            this.Visible = false;

            //Grab each tab page, and close the process(es)

            foreach (TabPage tabPage in serverTabs.TabPages)
            {
                try
                {
                    //Grab consoleID from current tab name
                    int consoleID = Convert.ToInt32(tabPage.Name.Replace("consoleTab ", ""));
                    Process serverProcess = serverProcesses[consoleID];

                    //Run /stop command
                    //Grab serverInstance
                    commands.runCommand("/stop", serverProcess, this.serverTabs, consoleID, this);
                    commands.runCommand("stop", serverProcess, this.serverTabs, consoleID, this);

                    //For some reason it does not close the terminal.
                    //Spent like 2 hours trying to fix it, and it turns out it still stops it.
                    //And probably more "safely" than my methods.
                }
                catch { continue; } //Probably not a console tab
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terminal_Close(sender, e);
        }

        private void startupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Startup startup = new Startup();
            startup.Show();
        }

        private async void stopBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Grab name of button
                int consoleID = Convert.ToInt32(this.stopBtn.Name); //Name is process ID
                Process serverProcess = serverProcesses[consoleID];

                //Run /stop command
                //Grab serverInstance
                commands.runCommand("/stop", serverProcess, this.serverTabs, consoleID, this);
                commands.runCommand("stop", serverProcess, this.serverTabs, consoleID, this);

                this.stopBtn.Name = "";

                //Wait for the server to stop
                while (!serverProcess.HasExited)
                {
                    // Wait 1 second
                    await Task.Run(async () => await Task.Delay(500));
                    secondaryTerminal.AppendText("\n[Minecraft-Multiplayer-Host INFO] Server is stopping...\n");
                }

                //add to terminal the server has stopped
                secondaryTerminal.AppendText("\n[Minecraft-Multiplayer-Host INFO] Server has stopped\n");
                isRunning = false;
                resetButtons();
                serverProcess.Close();
                serverProcesses.Remove(consoleID);

                if (formClosing)
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                this.stopBtn.Name = "";
                isRunning = false;
                resetButtons();
            }
        }

        private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open location
            string[] name = this.Name.Split(':');
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Servers\\" + name[0]);

            Process.Start("explorer.exe", location);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Grab old server name
            string oldName = this.Name;
            string oldDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + string.Format("\\Minecraft-Multiplayer-Host\\Servers\\{0}", oldName);

            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + string.Format("\\Minecraft-Multiplayer-Host\\Servers\\{0}", settingsNameTextBox.Text);
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
                        if (serverProcesses.ContainsKey(Convert.ToInt32(this.stopBtn.Name)))
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

                //Move the directory
                CopyDirectoryWithProgressBar(oldDirectory, directory, SettingsStatusLabel, true, SettingsProgressBar, "move");
            }

            if (!moveServer)
            {
                updateThreads.UpdateThreads(this.Name, (int)threadCount.Value);

                File.WriteAllText(directory + "\\server.properties", "server-port=" + settingsPortTextBox.Text + "\n" + "server-ip=" + settingsIpTextBox.Text + "\n" + "level-name=world\n" + "gamemode=survival\n" + "difficulty=easy\n" + "allow-cheats=false\n" + "max-players=" + settingsPlayersTextBox.Text + "\n" + "online-mode=true\n" + "white-list=false\n" + "server-name=" + settingsNameTextBox.Text + "\n" + "motd=" + settingsMotdTextBox.Text + "\n");
                SettingsStatusLabel.Text = "Server updated!";
            }
        }

        //First time setup is for when the server is first created, and needs to create the necessary files
        private async void CopyDirectoryWithProgressBar(string sourceDir, string destDir, Label label, bool firstTimeSetup, ProgressBar progressBar, string type)
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
                    logsOutput.AppendText(ioEx.ToString() + "\n");
                    couldNotCopyFiles++;
                }
                catch (DirectoryNotFoundException)
                {
                    //Add to logs that the directory was not found
                    logsOutput.AppendText("Directory not found: " + file + "\n");
                    couldNotCopyFiles++;
                }
                catch (Exception e)
                {
                    logsOutput.AppendText("Could not copy " + file + ": " + e.Message + "\n");
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
                }
            }

            if (firstTimeSetup)
            {
                await Task.Delay(1000); // Add a delay before deleting the directory
                if (Directory.Exists(sourceDir))
                {
                    await Task.Run(() => Directory.Delete(sourceDir, true));
                }

                label.Text = "Server moved!";
                this.Name = settingsNameTextBox.Text;
                this.Text = this.Name;

                updateThreads.UpdateThreads(this.Name, (int)threadCount.Value);

                File.WriteAllText(destDir + "\\server.properties", "server-port=" + settingsPortTextBox.Text + "\n" + "server-ip=" + settingsIpTextBox.Text + "\n" + "level-name=world\n" + "gamemode=survival\n" + "difficulty=easy\n" + "allow-cheats=false\n" + "max-players=" + settingsPlayersTextBox.Text + "\n" + "online-mode=true\n" + "white-list=false\n" + "server-name=" + settingsNameTextBox.Text + "\n" + "motd=" + settingsMotdTextBox.Text + "\n");
            }
        }

        private void openLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Most recent logs
            string[] name = this.Name.Split(':');
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Servers\\" + name[0] + "\\logs\\latest.log");

            Process.Start("notepad.exe", location);
        }

        private void serverJarCombo_Click(object sender, EventArgs e)
        {
            //Grab location
            string[] name = this.Name.Split(':');
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Servers\\" + name[0]);

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
            if (keyPress.KeyChar == (char)Keys.Enter)
            {
                // Grab consoleID
                string consoleIDString = secondaryTerminal.Name.Replace("console ", "");
                if (int.TryParse(consoleIDString, out int consoleID))
                {
                    // Grab serverProcess
                    Process serverProcess = serverProcesses[consoleID];

                    // Run command
                    commands.runCommand(secondaryTerminalInput.Text, serverProcess, this.serverTabs, consoleID, this);

                    // Clear text
                    secondaryTerminalInput.Clear();
                }
                else
                {
                    // Clear Text
                    secondaryTerminalInput.Clear();

                    //Display console is not running in main console
                    secondaryTerminal.AppendText("Server is not running!\n");
                }
            }
        }

        private void createBackupBtn_Click(object sender, EventArgs e)
        {
            //Bring backupLabel to top 
            backupLabel.BringToFront();
            //Copy files to ../BackUp/ServerName/BakcupDate-dd-mm-yyyy-hh-mm-ss

            //Grab this.name and remove anything after :
            string[] name = this.Name.Split(':');
            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Servers\\" + name[0]);

            //Grab day
            string time = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");

            //Check if directory exists
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Backups\\" + name[0] + "\\" + time)))
            {
                //Create directory
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Backups\\" + name[0] + "\\" + time));
            }
            else
            {
                return; //Backup already exists
            }

            //Copy files
            CopyDirectoryWithProgressBar(location, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Minecraft-Multiplayer-Host\\Backups\\" + name[0] + "\\" + time), backupLabel, false, backupProgressBar, "backup");
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            notifyIcon.showClosedWindows();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            runSettings.runSettingsApp();
        }
    }
}