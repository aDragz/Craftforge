﻿namespace CraftForge.Server.GUI.Console
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
            this.secondaryTerminalInput = new System.Windows.Forms.RichTextBox();
            this.serverJarPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.serverJarCombo = new System.Windows.Forms.ComboBox();
            this.secondaryTerminal = new System.Windows.Forms.RichTextBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.filesPage = new System.Windows.Forms.TabPage();
            this.folderList = new System.Windows.Forms.FlowLayoutPanel();
            this.pluginsPage = new System.Windows.Forms.TabPage();
            this.schedulerPage = new System.Windows.Forms.TabPage();
            this.logPage = new System.Windows.Forms.TabPage();
            this.logsOutput = new System.Windows.Forms.RichTextBox();
            this.backupPage = new System.Windows.Forms.TabPage();
            this.backupLabel = new System.Windows.Forms.Label();
            this.backupFolderList = new System.Windows.Forms.FlowLayoutPanel();
            this.backupProgressBar = new System.Windows.Forms.ProgressBar();
            this.createBackupBtn = new System.Windows.Forms.Button();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.threadCount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.settingsPlayersTextBox = new System.Windows.Forms.TextBox();
            this.SettingsProgressBar = new System.Windows.Forms.ProgressBar();
            this.settingsSaveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.openLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverTabsPanel = new System.Windows.Forms.Panel();
            this.removeTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeTabClick = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.cpuRamUsage = new System.Windows.Forms.Timer(this.components);
            this.serverTabs.SuspendLayout();
            this.generalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramUsageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuUsageChart)).BeginInit();
            this.serverStatusPanel.SuspendLayout();
            this.serverJarPanel.SuspendLayout();
            this.filesPage.SuspendLayout();
            this.logPage.SuspendLayout();
            this.backupPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadCount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.removeTab.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverStatusNetwork
            // 
            this.serverStatusNetwork.Tick += new System.EventHandler(this.serverStatusNetwork_Tick);
            // 
            // serverTabs
            // 
            this.serverTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.serverTabs.Controls.Add(this.generalPage);
            this.serverTabs.Controls.Add(this.filesPage);
            this.serverTabs.Controls.Add(this.pluginsPage);
            this.serverTabs.Controls.Add(this.schedulerPage);
            this.serverTabs.Controls.Add(this.logPage);
            this.serverTabs.Controls.Add(this.backupPage);
            this.serverTabs.Controls.Add(this.settingsPage);
            this.serverTabs.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTabs.HotTrack = true;
            this.serverTabs.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.serverTabs.ItemSize = new System.Drawing.Size(100, 10);
            this.serverTabs.Location = new System.Drawing.Point(148, 36);
            this.serverTabs.Multiline = true;
            this.serverTabs.Name = "serverTabs";
            this.serverTabs.Padding = new System.Drawing.Point(0, 0);
            this.serverTabs.SelectedIndex = 0;
            this.serverTabs.Size = new System.Drawing.Size(1750, 955);
            this.serverTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.serverTabs.TabIndex = 10;
            // 
            // generalPage
            // 
            this.generalPage.Controls.Add(this.ramUsageChart);
            this.generalPage.Controls.Add(this.cpuUsageChart);
            this.generalPage.Controls.Add(this.ramUsageLabel);
            this.generalPage.Controls.Add(this.cpuUsageLabel);
            this.generalPage.Controls.Add(this.serverStatusPanel);
            this.generalPage.Controls.Add(this.secondaryTerminalInput);
            this.generalPage.Controls.Add(this.serverJarPanel);
            this.generalPage.Controls.Add(this.secondaryTerminal);
            this.generalPage.Controls.Add(this.stopBtn);
            this.generalPage.Controls.Add(this.startBtn);
            this.generalPage.Location = new System.Drawing.Point(4, 14);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(1742, 937);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "General";
            this.generalPage.UseVisualStyleBackColor = true;
            // 
            // ramUsageChart
            // 
            this.ramUsageChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ramUsageChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ramUsageChart.Legends.Add(legend1);
            this.ramUsageChart.Location = new System.Drawing.Point(1341, 284);
            this.ramUsageChart.Name = "ramUsageChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ramUsageChart.Series.Add(series1);
            this.ramUsageChart.Size = new System.Drawing.Size(393, 189);
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
            this.cpuUsageChart.Location = new System.Drawing.Point(1341, 479);
            this.cpuUsageChart.Name = "cpuUsageChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cpuUsageChart.Series.Add(series2);
            this.cpuUsageChart.Size = new System.Drawing.Size(393, 189);
            this.cpuUsageChart.TabIndex = 40;
            this.cpuUsageChart.Text = "chart1";
            // 
            // ramUsageLabel
            // 
            this.ramUsageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ramUsageLabel.AutoSize = true;
            this.ramUsageLabel.Location = new System.Drawing.Point(1445, 248);
            this.ramUsageLabel.Name = "ramUsageLabel";
            this.ramUsageLabel.Size = new System.Drawing.Size(45, 33);
            this.ramUsageLabel.TabIndex = 39;
            this.ramUsageLabel.Text = "0%";
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.Location = new System.Drawing.Point(1344, 248);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(45, 33);
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
            this.serverStatusPanel.Location = new System.Drawing.Point(1341, 6);
            this.serverStatusPanel.Name = "serverStatusPanel";
            this.serverStatusPanel.Size = new System.Drawing.Size(393, 220);
            this.serverStatusPanel.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 33);
            this.label2.TabIndex = 36;
            this.label2.Text = "Port:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPortLabel
            // 
            this.mainPortLabel.Location = new System.Drawing.Point(3, 176);
            this.mainPortLabel.Name = "mainPortLabel";
            this.mainPortLabel.Size = new System.Drawing.Size(387, 33);
            this.mainPortLabel.TabIndex = 35;
            this.mainPortLabel.Text = "Port:";
            this.mainPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 33);
            this.label3.TabIndex = 34;
            this.label3.Text = "IP:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainIpLabel
            // 
            this.mainIpLabel.Location = new System.Drawing.Point(3, 89);
            this.mainIpLabel.Name = "mainIpLabel";
            this.mainIpLabel.Size = new System.Drawing.Size(387, 33);
            this.mainIpLabel.TabIndex = 33;
            this.mainIpLabel.Text = "Port:";
            this.mainIpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(104, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Server Status";
            // 
            // secondaryTerminalInput
            // 
            this.secondaryTerminalInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondaryTerminalInput.Location = new System.Drawing.Point(3, 750);
            this.secondaryTerminalInput.Multiline = false;
            this.secondaryTerminalInput.Name = "secondaryTerminalInput";
            this.secondaryTerminalInput.Size = new System.Drawing.Size(1332, 36);
            this.secondaryTerminalInput.TabIndex = 36;
            this.secondaryTerminalInput.Text = "";
            this.secondaryTerminalInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondaryTerminalInput_KeyPress);
            // 
            // serverJarPanel
            // 
            this.serverJarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.serverJarPanel.Controls.Add(this.label9);
            this.serverJarPanel.Controls.Add(this.serverJarCombo);
            this.serverJarPanel.Location = new System.Drawing.Point(1341, 674);
            this.serverJarPanel.Name = "serverJarPanel";
            this.serverJarPanel.Size = new System.Drawing.Size(393, 266);
            this.serverJarPanel.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(125, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 32);
            this.label9.TabIndex = 32;
            this.label9.Text = "Server Jar";
            // 
            // serverJarCombo
            // 
            this.serverJarCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverJarCombo.FormattingEnabled = true;
            this.serverJarCombo.IntegralHeight = false;
            this.serverJarCombo.Location = new System.Drawing.Point(3, 38);
            this.serverJarCombo.Name = "serverJarCombo";
            this.serverJarCombo.Size = new System.Drawing.Size(387, 41);
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
            this.secondaryTerminal.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryTerminal.Location = new System.Drawing.Point(3, 6);
            this.secondaryTerminal.Name = "secondaryTerminal";
            this.secondaryTerminal.ReadOnly = true;
            this.secondaryTerminal.Size = new System.Drawing.Size(1332, 742);
            this.secondaryTerminal.TabIndex = 34;
            this.secondaryTerminal.Text = "";
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Enabled = false;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Location = new System.Drawing.Point(947, 841);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(191, 90);
            this.stopBtn.TabIndex = 12;
            this.stopBtn.Text = "Stop Server";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Location = new System.Drawing.Point(1144, 841);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(191, 90);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "Start Server";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // filesPage
            // 
            this.filesPage.Controls.Add(this.folderList);
            this.filesPage.Location = new System.Drawing.Point(4, 14);
            this.filesPage.Name = "filesPage";
            this.filesPage.Size = new System.Drawing.Size(1742, 937);
            this.filesPage.TabIndex = 2;
            this.filesPage.Text = "Files";
            this.filesPage.UseVisualStyleBackColor = true;
            // 
            // folderList
            // 
            this.folderList.AutoScroll = true;
            this.folderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderList.Location = new System.Drawing.Point(0, 0);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(1742, 937);
            this.folderList.TabIndex = 0;
            // 
            // pluginsPage
            // 
            this.pluginsPage.Location = new System.Drawing.Point(4, 14);
            this.pluginsPage.Name = "pluginsPage";
            this.pluginsPage.Size = new System.Drawing.Size(1742, 937);
            this.pluginsPage.TabIndex = 4;
            this.pluginsPage.Text = "Plugins";
            this.pluginsPage.UseVisualStyleBackColor = true;
            // 
            // schedulerPage
            // 
            this.schedulerPage.Location = new System.Drawing.Point(4, 14);
            this.schedulerPage.Name = "schedulerPage";
            this.schedulerPage.Size = new System.Drawing.Size(1742, 937);
            this.schedulerPage.TabIndex = 6;
            this.schedulerPage.Text = "Scheduler";
            this.schedulerPage.UseVisualStyleBackColor = true;
            // 
            // logPage
            // 
            this.logPage.Controls.Add(this.logsOutput);
            this.logPage.Location = new System.Drawing.Point(4, 14);
            this.logPage.Name = "logPage";
            this.logPage.Size = new System.Drawing.Size(1742, 937);
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
            this.logsOutput.Location = new System.Drawing.Point(4, 3);
            this.logsOutput.Name = "logsOutput";
            this.logsOutput.ReadOnly = true;
            this.logsOutput.Size = new System.Drawing.Size(1730, 939);
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
            this.backupPage.Name = "backupPage";
            this.backupPage.Size = new System.Drawing.Size(1742, 937);
            this.backupPage.TabIndex = 5;
            this.backupPage.Text = "Backups";
            this.backupPage.UseVisualStyleBackColor = true;
            // 
            // backupLabel
            // 
            this.backupLabel.BackColor = System.Drawing.Color.Transparent;
            this.backupLabel.Location = new System.Drawing.Point(-1, 615);
            this.backupLabel.Name = "backupLabel";
            this.backupLabel.Size = new System.Drawing.Size(1740, 204);
            this.backupLabel.TabIndex = 24;
            this.backupLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // backupFolderList
            // 
            this.backupFolderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backupFolderList.AutoScroll = true;
            this.backupFolderList.Location = new System.Drawing.Point(3, 3);
            this.backupFolderList.Name = "backupFolderList";
            this.backupFolderList.Size = new System.Drawing.Size(1731, 819);
            this.backupFolderList.TabIndex = 26;
            // 
            // backupProgressBar
            // 
            this.backupProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backupProgressBar.Location = new System.Drawing.Point(50, 906);
            this.backupProgressBar.Name = "backupProgressBar";
            this.backupProgressBar.Size = new System.Drawing.Size(1640, 29);
            this.backupProgressBar.TabIndex = 25;
            // 
            // createBackupBtn
            // 
            this.createBackupBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.createBackupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBackupBtn.Location = new System.Drawing.Point(495, 828);
            this.createBackupBtn.Name = "createBackupBtn";
            this.createBackupBtn.Size = new System.Drawing.Size(749, 72);
            this.createBackupBtn.TabIndex = 23;
            this.createBackupBtn.Text = "Create Backup";
            this.createBackupBtn.UseVisualStyleBackColor = true;
            this.createBackupBtn.Click += new System.EventHandler(this.createBackupBtn_Click);
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.threadCount);
            this.settingsPage.Controls.Add(this.label10);
            this.settingsPage.Controls.Add(this.label8);
            this.settingsPage.Controls.Add(this.settingsPlayersTextBox);
            this.settingsPage.Controls.Add(this.SettingsProgressBar);
            this.settingsPage.Controls.Add(this.settingsSaveBtn);
            this.settingsPage.Controls.Add(this.label4);
            this.settingsPage.Controls.Add(this.label5);
            this.settingsPage.Controls.Add(this.label6);
            this.settingsPage.Controls.Add(this.label7);
            this.settingsPage.Controls.Add(this.settingsMotdTextBox);
            this.settingsPage.Controls.Add(this.settingsIpTextBox);
            this.settingsPage.Controls.Add(this.settingsNameTextBox);
            this.settingsPage.Controls.Add(this.settingsPortTextBox);
            this.settingsPage.Controls.Add(this.SettingsStatusLabel);
            this.settingsPage.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsPage.Location = new System.Drawing.Point(4, 14);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(1742, 937);
            this.settingsPage.TabIndex = 3;
            this.settingsPage.Text = "Settings";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // threadCount
            // 
            this.threadCount.Location = new System.Drawing.Point(196, 5);
            this.threadCount.Name = "threadCount";
            this.threadCount.Size = new System.Drawing.Size(100, 40);
            this.threadCount.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(11, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 32);
            this.label10.TabIndex = 28;
            this.label10.Text = "Threads";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(11, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "Players";
            // 
            // settingsPlayersTextBox
            // 
            this.settingsPlayersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsPlayersTextBox.Location = new System.Drawing.Point(196, 272);
            this.settingsPlayersTextBox.Name = "settingsPlayersTextBox";
            this.settingsPlayersTextBox.Size = new System.Drawing.Size(514, 39);
            this.settingsPlayersTextBox.TabIndex = 5;
            // 
            // SettingsProgressBar
            // 
            this.SettingsProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsProgressBar.Location = new System.Drawing.Point(50, 906);
            this.SettingsProgressBar.Name = "SettingsProgressBar";
            this.SettingsProgressBar.Size = new System.Drawing.Size(1640, 29);
            this.SettingsProgressBar.TabIndex = 22;
            // 
            // settingsSaveBtn
            // 
            this.settingsSaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingsSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsSaveBtn.Location = new System.Drawing.Point(495, 828);
            this.settingsSaveBtn.Name = "settingsSaveBtn";
            this.settingsSaveBtn.Size = new System.Drawing.Size(749, 72);
            this.settingsSaveBtn.TabIndex = 20;
            this.settingsSaveBtn.Text = "Save Settings";
            this.settingsSaveBtn.UseVisualStyleBackColor = true;
            this.settingsSaveBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(11, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "MOTD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(11, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(11, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "IP Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(11, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Server Name";
            // 
            // settingsMotdTextBox
            // 
            this.settingsMotdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsMotdTextBox.Location = new System.Drawing.Point(196, 217);
            this.settingsMotdTextBox.Name = "settingsMotdTextBox";
            this.settingsMotdTextBox.Size = new System.Drawing.Size(514, 39);
            this.settingsMotdTextBox.TabIndex = 4;
            // 
            // settingsIpTextBox
            // 
            this.settingsIpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsIpTextBox.Location = new System.Drawing.Point(196, 107);
            this.settingsIpTextBox.Name = "settingsIpTextBox";
            this.settingsIpTextBox.Size = new System.Drawing.Size(271, 39);
            this.settingsIpTextBox.TabIndex = 2;
            // 
            // settingsNameTextBox
            // 
            this.settingsNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsNameTextBox.Location = new System.Drawing.Point(196, 56);
            this.settingsNameTextBox.Name = "settingsNameTextBox";
            this.settingsNameTextBox.Size = new System.Drawing.Size(275, 39);
            this.settingsNameTextBox.TabIndex = 1;
            this.settingsNameTextBox.Text = "Server";
            // 
            // settingsPortTextBox
            // 
            this.settingsPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsPortTextBox.Location = new System.Drawing.Point(196, 162);
            this.settingsPortTextBox.MaxLength = 5;
            this.settingsPortTextBox.Name = "settingsPortTextBox";
            this.settingsPortTextBox.Size = new System.Drawing.Size(100, 39);
            this.settingsPortTextBox.TabIndex = 3;
            // 
            // SettingsStatusLabel
            // 
            this.SettingsStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsStatusLabel.Location = new System.Drawing.Point(1, 497);
            this.SettingsStatusLabel.Name = "SettingsStatusLabel";
            this.SettingsStatusLabel.Size = new System.Drawing.Size(1740, 204);
            this.SettingsStatusLabel.TabIndex = 21;
            this.SettingsStatusLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1898, 33);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startupToolStripMenuItem
            // 
            this.startupToolStripMenuItem.Name = "startupToolStripMenuItem";
            this.startupToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.startupToolStripMenuItem.Text = "Startup";
            this.startupToolStripMenuItem.Click += new System.EventHandler(this.startupToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.dToolStripMenuItem.Text = "Hide Window";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(219, 6);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(222, 34);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileLocationToolStripMenuItem,
            this.openLogsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // openFileLocationToolStripMenuItem
            // 
            this.openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
            this.openFileLocationToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.openFileLocationToolStripMenuItem.Text = "Open File Location";
            this.openFileLocationToolStripMenuItem.Click += new System.EventHandler(this.openFileLocationToolStripMenuItem_Click);
            // 
            // openLogsToolStripMenuItem
            // 
            this.openLogsToolStripMenuItem.Name = "openLogsToolStripMenuItem";
            this.openLogsToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.openLogsToolStripMenuItem.Text = "Open logs";
            this.openLogsToolStripMenuItem.Click += new System.EventHandler(this.openLogsToolStripMenuItem_Click);
            // 
            // serverTabsPanel
            // 
            this.serverTabsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.serverTabsPanel.AutoScroll = true;
            this.serverTabsPanel.Location = new System.Drawing.Point(0, 33);
            this.serverTabsPanel.Name = "serverTabsPanel";
            this.serverTabsPanel.Size = new System.Drawing.Size(150, 960);
            this.serverTabsPanel.TabIndex = 15;
            // 
            // removeTab
            // 
            this.removeTab.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.removeTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeTabClick});
            this.removeTab.Name = "removeTab";
            this.removeTab.Size = new System.Drawing.Size(181, 36);
            // 
            // removeTabClick
            // 
            this.removeTabClick.Name = "removeTabClick";
            this.removeTabClick.Size = new System.Drawing.Size(180, 32);
            this.removeTabClick.Text = "Remove Tab";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 1002);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(1898, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusBar";
            // 
            // cpuRamUsage
            // 
            this.cpuRamUsage.Interval = 2000;
            this.cpuRamUsage.Tick += new System.EventHandler(this.cpuUsage_Tick);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.serverTabsPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.serverTabs);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Terminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Terminal_Close);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.terminal_Close);
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
            this.filesPage.ResumeLayout(false);
            this.logPage.ResumeLayout(false);
            this.backupPage.ResumeLayout(false);
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadCount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.removeTab.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.TabPage pluginsPage;
        private System.Windows.Forms.TabPage backupPage;
        private System.Windows.Forms.TabPage schedulerPage;
        private System.Windows.Forms.Button settingsSaveBtn;
        private System.Windows.Forms.ProgressBar SettingsProgressBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox settingsPlayersTextBox;
        private System.Windows.Forms.ToolStripMenuItem openLogsToolStripMenuItem;
        public System.Windows.Forms.TabControl serverTabs;
        private System.Windows.Forms.ComboBox serverJarCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel serverTabsPanel;
        private System.Windows.Forms.RichTextBox secondaryTerminal;
        private System.Windows.Forms.Panel serverJarPanel;
        private System.Windows.Forms.RichTextBox secondaryTerminalInput;
        private System.Windows.Forms.Panel serverStatusPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mainIpLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip removeTab;
        private System.Windows.Forms.ToolStripMenuItem removeTabClick;
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
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
        public System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.FlowLayoutPanel backupFolderList;
        private System.Windows.Forms.Label backupLabel;
        private System.Windows.Forms.Label SettingsStatusLabel;
        private System.Windows.Forms.NumericUpDown threadCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cpuUsageLabel;
        private System.Windows.Forms.Timer cpuRamUsage;
        private System.Windows.Forms.Label ramUsageLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuUsageChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ramUsageChart;
    }
}

