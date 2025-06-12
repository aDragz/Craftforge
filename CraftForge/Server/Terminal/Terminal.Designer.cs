namespace CraftForge.Server.GUI.Console
{
    partial class Terminal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (this.IsHandleCreated)
            {
                base.Dispose(disposing);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminal));
            this.serverStatusNetwork = new System.Windows.Forms.Timer(this.components);
            this.serverTabs = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.secondaryTerminalInput = new System.Windows.Forms.TextBox();
            this.ramUsageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuUsageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ramUsageLabel = new System.Windows.Forms.Label();
            this.cpuUsageLabel = new System.Windows.Forms.Label();
            this.serverStatusPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPortLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainIpLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serverJarPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.serverJarCombo = new System.Windows.Forms.ComboBox();
            this.secondaryTerminal = new System.Windows.Forms.RichTextBox();
            this.terminalContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autoScrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.saveTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.playersPage = new System.Windows.Forms.TabPage();
            this.playerList = new System.Windows.Forms.FlowLayoutPanel();
            this.filesPage = new System.Windows.Forms.TabPage();
            this.folderList = new System.Windows.Forms.FlowLayoutPanel();
            this.logPage = new System.Windows.Forms.TabPage();
            this.logsOutput = new System.Windows.Forms.RichTextBox();
            this.backupPage = new System.Windows.Forms.TabPage();
            this.backupLabel = new System.Windows.Forms.Label();
            this.backupFolderList = new System.Windows.Forms.FlowLayoutPanel();
            this.backupProgressBar = new System.Windows.Forms.ProgressBar();
            this.createBackupBtn = new System.Windows.Forms.Button();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.openServerPropertiesLabel = new System.Windows.Forms.Label();
            this.settingsGamemodeComboBox = new System.Windows.Forms.ComboBox();
            this.GamemodeLbl = new System.Windows.Forms.Label();
            this.settingsWorldTextBox = new System.Windows.Forms.TextBox();
            this.WorldLbl = new System.Windows.Forms.Label();
            this.ramSlider = new System.Windows.Forms.TrackBar();
            this.ramNumber = new System.Windows.Forms.NumericUpDown();
            this.RamLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.threadCount = new System.Windows.Forms.NumericUpDown();
            this.ThreadsLbl = new System.Windows.Forms.Label();
            this.PlayersLbl = new System.Windows.Forms.Label();
            this.settingsPlayersTextBox = new System.Windows.Forms.TextBox();
            this.SettingsProgressBar = new System.Windows.Forms.ProgressBar();
            this.settingsSaveBtn = new System.Windows.Forms.Button();
            this.MOTDLbl = new System.Windows.Forms.Label();
            this.PortLbl = new System.Windows.Forms.Label();
            this.IPAddressLbl = new System.Windows.Forms.Label();
            this.serverNameLbl = new System.Windows.Forms.Label();
            this.settingsMotdTextBox = new System.Windows.Forms.TextBox();
            this.settingsIpTextBox = new System.Windows.Forms.TextBox();
            this.settingsNameTextBox = new System.Windows.Forms.TextBox();
            this.settingsPortTextBox = new System.Windows.Forms.TextBox();
            this.SettingsStatusLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.openLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openThemesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverTabsPanel = new System.Windows.Forms.Panel();
            this.cpuRamUsage = new System.Windows.Forms.Timer(this.components);
            this.serverTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramUsageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuUsageChart)).BeginInit();
            this.serverStatusPanel.SuspendLayout();
            this.serverJarPanel.SuspendLayout();
            this.terminalContextMenu.SuspendLayout();
            this.playersPage.SuspendLayout();
            this.filesPage.SuspendLayout();
            this.logPage.SuspendLayout();
            this.backupPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadCount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverStatusNetwork
            // 
            this.serverStatusNetwork.Interval = 5000;
            this.serverStatusNetwork.Tick += new System.EventHandler(this.serverStatusNetwork_Tick);
            // 
            // serverTabs
            // 
            this.serverTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.serverTabs.Controls.Add(this.generalPage);
            this.serverTabs.Controls.Add(this.playersPage);
            this.serverTabs.Controls.Add(this.filesPage);
            this.serverTabs.Controls.Add(this.logPage);
            this.serverTabs.Controls.Add(this.backupPage);
            this.serverTabs.Controls.Add(this.settingsPage);
            this.serverTabs.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTabs.HotTrack = true;
            this.serverTabs.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.serverTabs.ItemSize = new System.Drawing.Size(100, 10);
            this.serverTabs.Location = new System.Drawing.Point(176, 22);
            this.serverTabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverTabs.Multiline = true;
            this.serverTabs.Name = "serverTabs";
            this.serverTabs.Padding = new System.Drawing.Point(0, 0);
            this.serverTabs.SelectedIndex = 0;
            this.serverTabs.Size = new System.Drawing.Size(1518, 803);
            this.serverTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.serverTabs.TabIndex = 10;
            // 
            // generalPage
            // 
            this.generalPage.Controls.Add(this.secondaryTerminalInput);
            this.generalPage.Controls.Add(this.ramUsageChart);
            this.generalPage.Controls.Add(this.cpuUsageChart);
            this.generalPage.Controls.Add(this.ramUsageLabel);
            this.generalPage.Controls.Add(this.cpuUsageLabel);
            this.generalPage.Controls.Add(this.serverStatusPanel);
            this.generalPage.Controls.Add(this.serverJarPanel);
            this.generalPage.Controls.Add(this.secondaryTerminal);
            this.generalPage.Controls.Add(this.stopBtn);
            this.generalPage.Controls.Add(this.startBtn);
            this.generalPage.Location = new System.Drawing.Point(4, 14);
            this.generalPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generalPage.Size = new System.Drawing.Size(1510, 785);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "General";
            this.generalPage.UseVisualStyleBackColor = true;
            // 
            // secondaryTerminalInput
            // 
            this.secondaryTerminalInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondaryTerminalInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondaryTerminalInput.ForeColor = System.Drawing.Color.DimGray;
            this.secondaryTerminalInput.Location = new System.Drawing.Point(3, 639);
            this.secondaryTerminalInput.Name = "secondaryTerminalInput";
            this.secondaryTerminalInput.Size = new System.Drawing.Size(1147, 28);
            this.secondaryTerminalInput.TabIndex = 42;
            this.secondaryTerminalInput.Text = "Enter Command";
            this.secondaryTerminalInput.Enter += new System.EventHandler(this.secondaryTerminalInput_Enter);
            this.secondaryTerminalInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondaryTerminalInput_KeyPress);
            this.secondaryTerminalInput.Leave += new System.EventHandler(this.secondaryTerminalInput_Leave);
            // 
            // ramUsageChart
            // 
            this.ramUsageChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ramUsageChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ramUsageChart.Legends.Add(legend1);
            this.ramUsageChart.Location = new System.Drawing.Point(1155, 227);
            this.ramUsageChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ramUsageChart.Name = "ramUsageChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ramUsageChart.Series.Add(series1);
            this.ramUsageChart.Size = new System.Drawing.Size(349, 151);
            this.ramUsageChart.TabIndex = 41;
            this.ramUsageChart.Text = "chart2";
            // 
            // cpuUsageChart
            // 
            this.cpuUsageChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.cpuUsageChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cpuUsageChart.Legends.Add(legend2);
            this.cpuUsageChart.Location = new System.Drawing.Point(1155, 383);
            this.cpuUsageChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cpuUsageChart.Name = "cpuUsageChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cpuUsageChart.Series.Add(series2);
            this.cpuUsageChart.Size = new System.Drawing.Size(349, 151);
            this.cpuUsageChart.TabIndex = 40;
            this.cpuUsageChart.Text = "chart1";
            // 
            // ramUsageLabel
            // 
            this.ramUsageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ramUsageLabel.AutoSize = true;
            this.ramUsageLabel.Location = new System.Drawing.Point(1247, 198);
            this.ramUsageLabel.Name = "ramUsageLabel";
            this.ramUsageLabel.Size = new System.Drawing.Size(64, 28);
            this.ramUsageLabel.TabIndex = 39;
            this.ramUsageLabel.Text = "0 MB";
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.Location = new System.Drawing.Point(1157, 198);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(38, 28);
            this.cpuUsageLabel.TabIndex = 37;
            this.cpuUsageLabel.Text = "0%";
            // 
            // serverStatusPanel
            // 
            this.serverStatusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverStatusPanel.Controls.Add(this.label2);
            this.serverStatusPanel.Controls.Add(this.mainPortLabel);
            this.serverStatusPanel.Controls.Add(this.label3);
            this.serverStatusPanel.Controls.Add(this.mainIpLabel);
            this.serverStatusPanel.Controls.Add(this.label1);
            this.serverStatusPanel.Location = new System.Drawing.Point(1155, 5);
            this.serverStatusPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverStatusPanel.Name = "serverStatusPanel";
            this.serverStatusPanel.Size = new System.Drawing.Size(349, 176);
            this.serverStatusPanel.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "Port:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPortLabel
            // 
            this.mainPortLabel.Location = new System.Drawing.Point(3, 141);
            this.mainPortLabel.Name = "mainPortLabel";
            this.mainPortLabel.Size = new System.Drawing.Size(344, 26);
            this.mainPortLabel.TabIndex = 35;
            this.mainPortLabel.Text = "Unknown";
            this.mainPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "IP:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainIpLabel
            // 
            this.mainIpLabel.Location = new System.Drawing.Point(3, 71);
            this.mainIpLabel.Name = "mainIpLabel";
            this.mainIpLabel.Size = new System.Drawing.Size(344, 26);
            this.mainIpLabel.TabIndex = 33;
            this.mainIpLabel.Text = "Unknown";
            this.mainIpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(92, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Server Status";
            // 
            // serverJarPanel
            // 
            this.serverJarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.serverJarPanel.Controls.Add(this.label9);
            this.serverJarPanel.Controls.Add(this.serverJarCombo);
            this.serverJarPanel.Location = new System.Drawing.Point(1155, 578);
            this.serverJarPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverJarPanel.Name = "serverJarPanel";
            this.serverJarPanel.Size = new System.Drawing.Size(349, 213);
            this.serverJarPanel.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(111, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 29);
            this.label9.TabIndex = 32;
            this.label9.Text = "Server Jar";
            // 
            // serverJarCombo
            // 
            this.serverJarCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverJarCombo.FormattingEnabled = true;
            this.serverJarCombo.IntegralHeight = false;
            this.serverJarCombo.Location = new System.Drawing.Point(3, 54);
            this.serverJarCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverJarCombo.Name = "serverJarCombo";
            this.serverJarCombo.Size = new System.Drawing.Size(344, 35);
            this.serverJarCombo.TabIndex = 33;
            this.serverJarCombo.SelectedIndexChanged += new System.EventHandler(this.serverJarCombo_SelectedIndexChanged);
            this.serverJarCombo.Click += new System.EventHandler(this.serverJarCombo_Click);
            // 
            // secondaryTerminal
            // 
            this.secondaryTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondaryTerminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondaryTerminal.ContextMenuStrip = this.terminalContextMenu;
            this.secondaryTerminal.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryTerminal.Location = new System.Drawing.Point(3, 5);
            this.secondaryTerminal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondaryTerminal.Name = "secondaryTerminal";
            this.secondaryTerminal.ReadOnly = true;
            this.secondaryTerminal.Size = new System.Drawing.Size(1147, 633);
            this.secondaryTerminal.TabIndex = 34;
            this.secondaryTerminal.Text = "";
            // 
            // terminalContextMenu
            // 
            this.terminalContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.terminalContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoScrollToolStripMenuItem,
            this.deleteAllTextToolStripMenuItem,
            this.toolStripSeparator5,
            this.saveTextToolStripMenuItem});
            this.terminalContextMenu.Name = "terminalContextMenu";
            this.terminalContextMenu.Size = new System.Drawing.Size(194, 82);
            // 
            // autoScrollToolStripMenuItem
            // 
            this.autoScrollToolStripMenuItem.Name = "autoScrollToolStripMenuItem";
            this.autoScrollToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.autoScrollToolStripMenuItem.Text = "AutoScroll";
            this.autoScrollToolStripMenuItem.Click += new System.EventHandler(this.autoScrollToolStripMenuItem_Click);
            // 
            // deleteAllTextToolStripMenuItem
            // 
            this.deleteAllTextToolStripMenuItem.Name = "deleteAllTextToolStripMenuItem";
            this.deleteAllTextToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.deleteAllTextToolStripMenuItem.Text = "Delete all Text";
            this.deleteAllTextToolStripMenuItem.Click += new System.EventHandler(this.deleteAllTextToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(190, 6);
            // 
            // saveTextToolStripMenuItem
            // 
            this.saveTextToolStripMenuItem.Name = "saveTextToolStripMenuItem";
            this.saveTextToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.saveTextToolStripMenuItem.Text = "Save Text to Logs";
            this.saveTextToolStripMenuItem.Click += new System.EventHandler(this.saveTextToolStripMenuItem_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Enabled = false;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Location = new System.Drawing.Point(804, 710);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(170, 72);
            this.stopBtn.TabIndex = 12;
            this.stopBtn.Text = "Stop Server";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Location = new System.Drawing.Point(980, 710);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(170, 72);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "Start Server";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // playersPage
            // 
            this.playersPage.Controls.Add(this.playerList);
            this.playersPage.Location = new System.Drawing.Point(4, 14);
            this.playersPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playersPage.Name = "playersPage";
            this.playersPage.Size = new System.Drawing.Size(1510, 785);
            this.playersPage.TabIndex = 8;
            this.playersPage.Text = "Players";
            this.playersPage.UseVisualStyleBackColor = true;
            // 
            // playerList
            // 
            this.playerList.AutoScroll = true;
            this.playerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerList.Location = new System.Drawing.Point(0, 0);
            this.playerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(1510, 785);
            this.playerList.TabIndex = 0;
            // 
            // filesPage
            // 
            this.filesPage.Controls.Add(this.folderList);
            this.filesPage.Location = new System.Drawing.Point(4, 14);
            this.filesPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filesPage.Name = "filesPage";
            this.filesPage.Size = new System.Drawing.Size(1510, 785);
            this.filesPage.TabIndex = 2;
            this.filesPage.Text = "Files";
            this.filesPage.UseVisualStyleBackColor = true;
            // 
            // folderList
            // 
            this.folderList.AutoScroll = true;
            this.folderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderList.Location = new System.Drawing.Point(0, 0);
            this.folderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(1510, 785);
            this.folderList.TabIndex = 0;
            // 
            // logPage
            // 
            this.logPage.Controls.Add(this.logsOutput);
            this.logPage.Location = new System.Drawing.Point(4, 14);
            this.logPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logPage.Name = "logPage";
            this.logPage.Size = new System.Drawing.Size(1510, 785);
            this.logPage.TabIndex = 7;
            this.logPage.Text = "Logs";
            this.logPage.UseVisualStyleBackColor = true;
            // 
            // logsOutput
            // 
            this.logsOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logsOutput.BackColor = System.Drawing.SystemColors.Window;
            this.logsOutput.Location = new System.Drawing.Point(4, 2);
            this.logsOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logsOutput.Name = "logsOutput";
            this.logsOutput.ReadOnly = true;
            this.logsOutput.Size = new System.Drawing.Size(1545, 785);
            this.logsOutput.TabIndex = 38;
            this.logsOutput.Text = "";
            // 
            // backupPage
            // 
            this.backupPage.Controls.Add(this.backupLabel);
            this.backupPage.Controls.Add(this.backupFolderList);
            this.backupPage.Controls.Add(this.backupProgressBar);
            this.backupPage.Controls.Add(this.createBackupBtn);
            this.backupPage.Location = new System.Drawing.Point(4, 14);
            this.backupPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backupPage.Name = "backupPage";
            this.backupPage.Size = new System.Drawing.Size(1510, 785);
            this.backupPage.TabIndex = 5;
            this.backupPage.Text = "Backups";
            this.backupPage.UseVisualStyleBackColor = true;
            // 
            // backupLabel
            // 
            this.backupLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.backupLabel.BackColor = System.Drawing.Color.Transparent;
            this.backupLabel.Location = new System.Drawing.Point(3, 525);
            this.backupLabel.Name = "backupLabel";
            this.backupLabel.Size = new System.Drawing.Size(1547, 163);
            this.backupLabel.TabIndex = 24;
            this.backupLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // backupFolderList
            // 
            this.backupFolderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backupFolderList.AutoScroll = true;
            this.backupFolderList.Location = new System.Drawing.Point(3, 2);
            this.backupFolderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backupFolderList.Name = "backupFolderList";
            this.backupFolderList.Size = new System.Drawing.Size(1546, 688);
            this.backupFolderList.TabIndex = 26;
            // 
            // backupProgressBar
            // 
            this.backupProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backupProgressBar.Location = new System.Drawing.Point(44, 758);
            this.backupProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backupProgressBar.Name = "backupProgressBar";
            this.backupProgressBar.Size = new System.Drawing.Size(1420, 23);
            this.backupProgressBar.TabIndex = 25;
            // 
            // createBackupBtn
            // 
            this.createBackupBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.createBackupBtn.FlatAppearance.BorderSize = 0;
            this.createBackupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBackupBtn.Location = new System.Drawing.Point(421, 695);
            this.createBackupBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createBackupBtn.Name = "createBackupBtn";
            this.createBackupBtn.Size = new System.Drawing.Size(666, 58);
            this.createBackupBtn.TabIndex = 23;
            this.createBackupBtn.Text = "Create Backup";
            this.createBackupBtn.UseVisualStyleBackColor = true;
            this.createBackupBtn.Click += new System.EventHandler(this.createBackupBtn_Click);
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.openServerPropertiesLabel);
            this.settingsPage.Controls.Add(this.settingsGamemodeComboBox);
            this.settingsPage.Controls.Add(this.GamemodeLbl);
            this.settingsPage.Controls.Add(this.settingsWorldTextBox);
            this.settingsPage.Controls.Add(this.WorldLbl);
            this.settingsPage.Controls.Add(this.ramSlider);
            this.settingsPage.Controls.Add(this.ramNumber);
            this.settingsPage.Controls.Add(this.RamLbl);
            this.settingsPage.Controls.Add(this.label12);
            this.settingsPage.Controls.Add(this.label11);
            this.settingsPage.Controls.Add(this.threadCount);
            this.settingsPage.Controls.Add(this.ThreadsLbl);
            this.settingsPage.Controls.Add(this.PlayersLbl);
            this.settingsPage.Controls.Add(this.settingsPlayersTextBox);
            this.settingsPage.Controls.Add(this.SettingsProgressBar);
            this.settingsPage.Controls.Add(this.settingsSaveBtn);
            this.settingsPage.Controls.Add(this.MOTDLbl);
            this.settingsPage.Controls.Add(this.PortLbl);
            this.settingsPage.Controls.Add(this.IPAddressLbl);
            this.settingsPage.Controls.Add(this.serverNameLbl);
            this.settingsPage.Controls.Add(this.settingsMotdTextBox);
            this.settingsPage.Controls.Add(this.settingsIpTextBox);
            this.settingsPage.Controls.Add(this.settingsNameTextBox);
            this.settingsPage.Controls.Add(this.settingsPortTextBox);
            this.settingsPage.Controls.Add(this.SettingsStatusLabel);
            this.settingsPage.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsPage.Location = new System.Drawing.Point(4, 14);
            this.settingsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(1510, 785);
            this.settingsPage.TabIndex = 3;
            this.settingsPage.Text = "Settings";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // openServerPropertiesLabel
            // 
            this.openServerPropertiesLabel.AutoSize = true;
            this.openServerPropertiesLabel.Font = new System.Drawing.Font("Consolas", 20F);
            this.openServerPropertiesLabel.ForeColor = System.Drawing.Color.Yellow;
            this.openServerPropertiesLabel.Location = new System.Drawing.Point(228, 8);
            this.openServerPropertiesLabel.Name = "openServerPropertiesLabel";
            this.openServerPropertiesLabel.Size = new System.Drawing.Size(133, 40);
            this.openServerPropertiesLabel.TabIndex = 2004;
            this.openServerPropertiesLabel.Text = "📂Open";
            this.openServerPropertiesLabel.Click += new System.EventHandler(this.label16_Click);
            // 
            // settingsGamemodeComboBox
            // 
            this.settingsGamemodeComboBox.FormattingEnabled = true;
            this.settingsGamemodeComboBox.Items.AddRange(new object[] {
            "Adventure",
            "Creative",
            "Spectator",
            "Survival"});
            this.settingsGamemodeComboBox.Location = new System.Drawing.Point(804, 82);
            this.settingsGamemodeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsGamemodeComboBox.MaxDropDownItems = 4;
            this.settingsGamemodeComboBox.Name = "settingsGamemodeComboBox";
            this.settingsGamemodeComboBox.Size = new System.Drawing.Size(152, 35);
            this.settingsGamemodeComboBox.TabIndex = 7;
            // 
            // GamemodeLbl
            // 
            this.GamemodeLbl.AutoSize = true;
            this.GamemodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GamemodeLbl.Location = new System.Drawing.Point(640, 82);
            this.GamemodeLbl.Name = "GamemodeLbl";
            this.GamemodeLbl.Size = new System.Drawing.Size(140, 29);
            this.GamemodeLbl.TabIndex = 2003;
            this.GamemodeLbl.Text = "Gamemode";
            // 
            // settingsWorldTextBox
            // 
            this.settingsWorldTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsWorldTextBox.Location = new System.Drawing.Point(174, 294);
            this.settingsWorldTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsWorldTextBox.Name = "settingsWorldTextBox";
            this.settingsWorldTextBox.Size = new System.Drawing.Size(457, 34);
            this.settingsWorldTextBox.TabIndex = 6;
            // 
            // WorldLbl
            // 
            this.WorldLbl.AutoSize = true;
            this.WorldLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WorldLbl.Location = new System.Drawing.Point(10, 295);
            this.WorldLbl.Name = "WorldLbl";
            this.WorldLbl.Size = new System.Drawing.Size(77, 29);
            this.WorldLbl.TabIndex = 2001;
            this.WorldLbl.Text = "World";
            // 
            // ramSlider
            // 
            this.ramSlider.LargeChange = 1024;
            this.ramSlider.Location = new System.Drawing.Point(174, 459);
            this.ramSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ramSlider.Maximum = 512;
            this.ramSlider.Minimum = 512;
            this.ramSlider.Name = "ramSlider";
            this.ramSlider.Size = new System.Drawing.Size(172, 56);
            this.ramSlider.SmallChange = 256;
            this.ramSlider.TabIndex = 30;
            this.ramSlider.TickFrequency = 256;
            this.ramSlider.Value = 512;
            this.ramSlider.Scroll += new System.EventHandler(this.ramSlider_Scroll);
            // 
            // ramNumber
            // 
            this.ramNumber.Increment = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.ramNumber.Location = new System.Drawing.Point(352, 459);
            this.ramNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ramNumber.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.ramNumber.Minimum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.ramNumber.Name = "ramNumber";
            this.ramNumber.Size = new System.Drawing.Size(93, 35);
            this.ramNumber.TabIndex = 31;
            this.ramNumber.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.ramNumber.ValueChanged += new System.EventHandler(this.ramNumber_ValueChanged);
            // 
            // RamLbl
            // 
            this.RamLbl.AutoSize = true;
            this.RamLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RamLbl.Location = new System.Drawing.Point(10, 460);
            this.RamLbl.Name = "RamLbl";
            this.RamLbl.Size = new System.Drawing.Size(63, 29);
            this.RamLbl.TabIndex = 32;
            this.RamLbl.Text = "Ram";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 51);
            this.label12.TabIndex = 31;
            this.label12.Text = "Advanced";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 51);
            this.label11.TabIndex = 30;
            this.label11.Text = "Standard";
            // 
            // threadCount
            // 
            this.threadCount.Location = new System.Drawing.Point(174, 417);
            this.threadCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.threadCount.Name = "threadCount";
            this.threadCount.Size = new System.Drawing.Size(89, 35);
            this.threadCount.TabIndex = 29;
            // 
            // ThreadsLbl
            // 
            this.ThreadsLbl.AutoSize = true;
            this.ThreadsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ThreadsLbl.Location = new System.Drawing.Point(10, 418);
            this.ThreadsLbl.Name = "ThreadsLbl";
            this.ThreadsLbl.Size = new System.Drawing.Size(103, 29);
            this.ThreadsLbl.TabIndex = 28;
            this.ThreadsLbl.Text = "Threads";
            // 
            // PlayersLbl
            // 
            this.PlayersLbl.AutoSize = true;
            this.PlayersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PlayersLbl.Location = new System.Drawing.Point(10, 253);
            this.PlayersLbl.Name = "PlayersLbl";
            this.PlayersLbl.Size = new System.Drawing.Size(93, 29);
            this.PlayersLbl.TabIndex = 24;
            this.PlayersLbl.Text = "Players";
            // 
            // settingsPlayersTextBox
            // 
            this.settingsPlayersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsPlayersTextBox.Location = new System.Drawing.Point(174, 252);
            this.settingsPlayersTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsPlayersTextBox.Name = "settingsPlayersTextBox";
            this.settingsPlayersTextBox.Size = new System.Drawing.Size(457, 34);
            this.settingsPlayersTextBox.TabIndex = 5;
            // 
            // SettingsProgressBar
            // 
            this.SettingsProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsProgressBar.Location = new System.Drawing.Point(44, 758);
            this.SettingsProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsProgressBar.Name = "SettingsProgressBar";
            this.SettingsProgressBar.Size = new System.Drawing.Size(1420, 23);
            this.SettingsProgressBar.TabIndex = 22;
            // 
            // settingsSaveBtn
            // 
            this.settingsSaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingsSaveBtn.FlatAppearance.BorderSize = 0;
            this.settingsSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsSaveBtn.Location = new System.Drawing.Point(421, 695);
            this.settingsSaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsSaveBtn.Name = "settingsSaveBtn";
            this.settingsSaveBtn.Size = new System.Drawing.Size(666, 58);
            this.settingsSaveBtn.TabIndex = 2000;
            this.settingsSaveBtn.Text = "Save Settings";
            this.settingsSaveBtn.UseVisualStyleBackColor = true;
            this.settingsSaveBtn.Click += new System.EventHandler(this.button2_ClickAsync);
            // 
            // MOTDLbl
            // 
            this.MOTDLbl.AutoSize = true;
            this.MOTDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MOTDLbl.Location = new System.Drawing.Point(10, 210);
            this.MOTDLbl.Name = "MOTDLbl";
            this.MOTDLbl.Size = new System.Drawing.Size(85, 29);
            this.MOTDLbl.TabIndex = 18;
            this.MOTDLbl.Text = "MOTD";
            // 
            // PortLbl
            // 
            this.PortLbl.AutoSize = true;
            this.PortLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PortLbl.Location = new System.Drawing.Point(10, 166);
            this.PortLbl.Name = "PortLbl";
            this.PortLbl.Size = new System.Drawing.Size(57, 29);
            this.PortLbl.TabIndex = 17;
            this.PortLbl.Text = "Port";
            // 
            // IPAddressLbl
            // 
            this.IPAddressLbl.AutoSize = true;
            this.IPAddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.IPAddressLbl.Location = new System.Drawing.Point(10, 122);
            this.IPAddressLbl.Name = "IPAddressLbl";
            this.IPAddressLbl.Size = new System.Drawing.Size(130, 29);
            this.IPAddressLbl.TabIndex = 16;
            this.IPAddressLbl.Text = "IP Address";
            // 
            // serverNameLbl
            // 
            this.serverNameLbl.AutoSize = true;
            this.serverNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.serverNameLbl.Location = new System.Drawing.Point(10, 82);
            this.serverNameLbl.Name = "serverNameLbl";
            this.serverNameLbl.Size = new System.Drawing.Size(155, 29);
            this.serverNameLbl.TabIndex = 15;
            this.serverNameLbl.Text = "Server Name";
            // 
            // settingsMotdTextBox
            // 
            this.settingsMotdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsMotdTextBox.Location = new System.Drawing.Point(174, 208);
            this.settingsMotdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsMotdTextBox.Name = "settingsMotdTextBox";
            this.settingsMotdTextBox.Size = new System.Drawing.Size(457, 34);
            this.settingsMotdTextBox.TabIndex = 4;
            // 
            // settingsIpTextBox
            // 
            this.settingsIpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsIpTextBox.Location = new System.Drawing.Point(174, 120);
            this.settingsIpTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsIpTextBox.Name = "settingsIpTextBox";
            this.settingsIpTextBox.Size = new System.Drawing.Size(457, 34);
            this.settingsIpTextBox.TabIndex = 2;
            // 
            // settingsNameTextBox
            // 
            this.settingsNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsNameTextBox.Location = new System.Drawing.Point(174, 79);
            this.settingsNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsNameTextBox.Name = "settingsNameTextBox";
            this.settingsNameTextBox.Size = new System.Drawing.Size(457, 34);
            this.settingsNameTextBox.TabIndex = 1;
            this.settingsNameTextBox.Text = "Server";
            // 
            // settingsPortTextBox
            // 
            this.settingsPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsPortTextBox.Location = new System.Drawing.Point(174, 164);
            this.settingsPortTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsPortTextBox.MaxLength = 5;
            this.settingsPortTextBox.Name = "settingsPortTextBox";
            this.settingsPortTextBox.Size = new System.Drawing.Size(89, 34);
            this.settingsPortTextBox.TabIndex = 3;
            // 
            // SettingsStatusLabel
            // 
            this.SettingsStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsStatusLabel.Location = new System.Drawing.Point(0, 530);
            this.SettingsStatusLabel.Name = "SettingsStatusLabel";
            this.SettingsStatusLabel.Size = new System.Drawing.Size(1509, 163);
            this.SettingsStatusLabel.TabIndex = 21;
            this.SettingsStatusLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.themesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1687, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startupToolStripMenuItem,
            this.dToolStripMenuItem,
            this.toolStripSeparator3,
            this.settingsToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startupToolStripMenuItem
            // 
            this.startupToolStripMenuItem.Name = "startupToolStripMenuItem";
            this.startupToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.startupToolStripMenuItem.Text = "Startup";
            this.startupToolStripMenuItem.Click += new System.EventHandler(this.startupToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.dToolStripMenuItem.Text = "Hide Window";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileLocationToolStripMenuItem,
            this.toolStripSeparator6,
            this.openLogsToolStripMenuItem,
            this.openLogsFolderToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // openFileLocationToolStripMenuItem
            // 
            this.openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
            this.openFileLocationToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.openFileLocationToolStripMenuItem.Text = "Open Folder Location";
            this.openFileLocationToolStripMenuItem.Click += new System.EventHandler(this.openFileLocationToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(232, 6);
            // 
            // openLogsToolStripMenuItem
            // 
            this.openLogsToolStripMenuItem.Name = "openLogsToolStripMenuItem";
            this.openLogsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.openLogsToolStripMenuItem.Text = "Open latest.log";
            this.openLogsToolStripMenuItem.Click += new System.EventHandler(this.openLogsToolStripMenuItem_Click);
            // 
            // openLogsFolderToolStripMenuItem
            // 
            this.openLogsFolderToolStripMenuItem.Name = "openLogsFolderToolStripMenuItem";
            this.openLogsFolderToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.openLogsFolderToolStripMenuItem.Text = "Open Logs Folder";
            this.openLogsFolderToolStripMenuItem.Click += new System.EventHandler(this.openLogsFolderToolStripMenuItem_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeThemeToolStripMenuItem,
            this.toolStripSeparator2,
            this.openThemesToolStripMenuItem,
            this.reToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.themesToolStripMenuItem.Text = "Theme";
            // 
            // customizeThemeToolStripMenuItem
            // 
            this.customizeThemeToolStripMenuItem.Name = "customizeThemeToolStripMenuItem";
            this.customizeThemeToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.customizeThemeToolStripMenuItem.Text = "Customize Theme";
            this.customizeThemeToolStripMenuItem.Click += new System.EventHandler(this.customizeThemeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(226, 6);
            // 
            // openThemesToolStripMenuItem
            // 
            this.openThemesToolStripMenuItem.Name = "openThemesToolStripMenuItem";
            this.openThemesToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.openThemesToolStripMenuItem.Text = "Open Themes Folder";
            this.openThemesToolStripMenuItem.Click += new System.EventHandler(this.openThemesToolStripMenuItem_Click);
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.reToolStripMenuItem.Text = "Delete All Themes";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator4,
            this.supportToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(142, 6);
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.supportToolStripMenuItem.Text = "Support";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.supportToolStripMenuItem_Click);
            // 
            // serverTabsPanel
            // 
            this.serverTabsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.serverTabsPanel.AutoScroll = true;
            this.serverTabsPanel.Location = new System.Drawing.Point(0, 30);
            this.serverTabsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverTabsPanel.Name = "serverTabsPanel";
            this.serverTabsPanel.Size = new System.Drawing.Size(178, 794);
            this.serverTabsPanel.TabIndex = 15;
            // 
            // cpuRamUsage
            // 
            this.cpuRamUsage.Interval = 1000;
            this.cpuRamUsage.Tick += new System.EventHandler(this.cpuUsage_Tick);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 819);
            this.Controls.Add(this.serverTabsPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.serverTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1691, 857);
            this.Name = "Terminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerName | CraftForge {release} - v{applicationVersion}";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Terminal_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Terminal_Closed);
            this.Load += new System.EventHandler(this.Terminal_Load);
            this.serverTabs.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramUsageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuUsageChart)).EndInit();
            this.serverStatusPanel.ResumeLayout(false);
            this.serverStatusPanel.PerformLayout();
            this.serverJarPanel.ResumeLayout(false);
            this.serverJarPanel.PerformLayout();
            this.terminalContextMenu.ResumeLayout(false);
            this.playersPage.ResumeLayout(false);
            this.filesPage.ResumeLayout(false);
            this.logPage.ResumeLayout(false);
            this.backupPage.ResumeLayout(false);
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadCount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer serverStatusNetwork;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TabPage filesPage;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.Label MOTDLbl;
        private System.Windows.Forms.Label PortLbl;
        private System.Windows.Forms.Label IPAddressLbl;
        private System.Windows.Forms.Label serverNameLbl;
        private System.Windows.Forms.TextBox settingsMotdTextBox;
        private System.Windows.Forms.TextBox settingsIpTextBox;
        private System.Windows.Forms.TextBox settingsNameTextBox;
        private System.Windows.Forms.TextBox settingsPortTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileLocationToolStripMenuItem;
        private System.Windows.Forms.TabPage backupPage;
        private System.Windows.Forms.Button settingsSaveBtn;
        private System.Windows.Forms.ProgressBar SettingsProgressBar;
        private System.Windows.Forms.Label PlayersLbl;
        private System.Windows.Forms.TextBox settingsPlayersTextBox;
        private System.Windows.Forms.ToolStripMenuItem openLogsToolStripMenuItem;
        public System.Windows.Forms.TabControl serverTabs;
        private System.Windows.Forms.ComboBox serverJarCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel serverTabsPanel;
        private System.Windows.Forms.RichTextBox secondaryTerminal;
        private System.Windows.Forms.Panel serverJarPanel;
        private System.Windows.Forms.Panel serverStatusPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mainIpLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mainPortLabel;
        private System.Windows.Forms.ProgressBar backupProgressBar;
        private System.Windows.Forms.Button createBackupBtn;
        private System.Windows.Forms.TabPage logPage;
        public System.Windows.Forms.RichTextBox logsOutput;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel folderList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel backupFolderList;
        private System.Windows.Forms.Label backupLabel;
        private System.Windows.Forms.Label SettingsStatusLabel;
        private System.Windows.Forms.NumericUpDown threadCount;
        private System.Windows.Forms.Label ThreadsLbl;
        private System.Windows.Forms.Label cpuUsageLabel;
        private System.Windows.Forms.Timer cpuRamUsage;
        private System.Windows.Forms.Label ramUsageLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuUsageChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ramUsageChart;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label RamLbl;
        private System.Windows.Forms.TrackBar ramSlider;
        private System.Windows.Forms.NumericUpDown ramNumber;
        private System.Windows.Forms.TabPage playersPage;
        private System.Windows.Forms.FlowLayoutPanel playerList;
        private System.Windows.Forms.TextBox settingsWorldTextBox;
        private System.Windows.Forms.Label WorldLbl;
        private System.Windows.Forms.Label GamemodeLbl;
        private System.Windows.Forms.ComboBox settingsGamemodeComboBox;
        private System.Windows.Forms.Label openServerPropertiesLabel;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openThemesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllTextToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip terminalContextMenu;
        private System.Windows.Forms.ToolStripMenuItem autoScrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem saveTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem openLogsFolderToolStripMenuItem;
        private System.Windows.Forms.TextBox secondaryTerminalInput;
    }
}

