namespace CraftForge.Server.Classes.Themes.Applications
{
    partial class customizeTheme
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.themeList = new System.Windows.Forms.ComboBox();
            this.terminalBackground = new System.Windows.Forms.FlowLayoutPanel();
            this.ramUsageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuUsageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ramUsageLabel = new System.Windows.Forms.Label();
            this.cpuUsageLabel = new System.Windows.Forms.Label();
            this.serverStatusPanel = new System.Windows.Forms.Panel();
            this.ServerStatusPortLbl = new System.Windows.Forms.Label();
            this.ServerStatusPortInfoLbl = new System.Windows.Forms.Label();
            this.ServerStatusIPLbl = new System.Windows.Forms.Label();
            this.ServerStatusIPInfoLbl = new System.Windows.Forms.Label();
            this.serverStatusLbl = new System.Windows.Forms.Label();
            this.secondaryTerminalInput = new System.Windows.Forms.RichTextBox();
            this.serverJarPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.serverJarCombo = new System.Windows.Forms.ComboBox();
            this.secondaryTerminal = new System.Windows.Forms.RichTextBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.itemFontBtn = new System.Windows.Forms.Button();
            this.itemFontLbl = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.itemTextColourBtn = new System.Windows.Forms.Button();
            this.itemColourLbl = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.selectedItemBox = new System.Windows.Forms.ComboBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemBackColourBtn = new System.Windows.Forms.Button();
            this.itemBackColourLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusBar = new System.Windows.Forms.Label();
            this.themeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ramUsageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuUsageChart)).BeginInit();
            this.serverStatusPanel.SuspendLayout();
            this.serverJarPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // themeList
            // 
            this.themeList.Font = new System.Drawing.Font("Consolas", 12F);
            this.themeList.FormattingEnabled = true;
            this.themeList.Location = new System.Drawing.Point(213, 3);
            this.themeList.Name = "themeList";
            this.themeList.Size = new System.Drawing.Size(325, 31);
            this.themeList.TabIndex = 0;
            this.themeList.SelectedIndexChanged += new System.EventHandler(this.themeList_SelectedIndexChanged);
            // 
            // terminalBackground
            // 
            this.terminalBackground.Location = new System.Drawing.Point(176, 38);
            this.terminalBackground.Name = "terminalBackground";
            this.terminalBackground.Size = new System.Drawing.Size(1516, 806);
            this.terminalBackground.TabIndex = 1;
            // 
            // ramUsageChart
            // 
            this.ramUsageChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ramUsageChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Chart";
            this.ramUsageChart.Legends.Add(legend1);
            this.ramUsageChart.Location = new System.Drawing.Point(1336, 261);
            this.ramUsageChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ramUsageChart.Name = "ramUsageChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "CPU/Ram";
            this.ramUsageChart.Series.Add(series1);
            this.ramUsageChart.Size = new System.Drawing.Size(349, 151);
            this.ramUsageChart.TabIndex = 51;
            this.ramUsageChart.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "CPU/Ram Chart";
            this.ramUsageChart.Titles.Add(title1);
            // 
            // cpuUsageChart
            // 
            this.cpuUsageChart.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.cpuUsageChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cpuUsageChart.Legends.Add(legend2);
            this.cpuUsageChart.Location = new System.Drawing.Point(1336, 417);
            this.cpuUsageChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cpuUsageChart.Name = "cpuUsageChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cpuUsageChart.Series.Add(series2);
            this.cpuUsageChart.Size = new System.Drawing.Size(349, 151);
            this.cpuUsageChart.TabIndex = 50;
            this.cpuUsageChart.Text = "chart1";
            this.cpuUsageChart.Visible = false;
            // 
            // ramUsageLabel
            // 
            this.ramUsageLabel.AutoSize = true;
            this.ramUsageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ramUsageLabel.Location = new System.Drawing.Point(1428, 232);
            this.ramUsageLabel.Name = "ramUsageLabel";
            this.ramUsageLabel.Size = new System.Drawing.Size(37, 16);
            this.ramUsageLabel.TabIndex = 49;
            this.ramUsageLabel.Text = "0 MB";
            this.ramUsageLabel.Visible = false;
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuUsageLabel.Location = new System.Drawing.Point(1338, 232);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(26, 16);
            this.cpuUsageLabel.TabIndex = 48;
            this.cpuUsageLabel.Text = "0%";
            this.cpuUsageLabel.Visible = false;
            // 
            // serverStatusPanel
            // 
            this.serverStatusPanel.BackColor = System.Drawing.Color.Transparent;
            this.serverStatusPanel.Controls.Add(this.ServerStatusPortLbl);
            this.serverStatusPanel.Controls.Add(this.ServerStatusPortInfoLbl);
            this.serverStatusPanel.Controls.Add(this.ServerStatusIPLbl);
            this.serverStatusPanel.Controls.Add(this.ServerStatusIPInfoLbl);
            this.serverStatusPanel.Controls.Add(this.serverStatusLbl);
            this.serverStatusPanel.Location = new System.Drawing.Point(1336, 39);
            this.serverStatusPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverStatusPanel.Name = "serverStatusPanel";
            this.serverStatusPanel.Size = new System.Drawing.Size(349, 176);
            this.serverStatusPanel.TabIndex = 46;
            this.serverStatusPanel.Visible = false;
            // 
            // ServerStatusPortLbl
            // 
            this.ServerStatusPortLbl.Font = new System.Drawing.Font("Consolas", 14F);
            this.ServerStatusPortLbl.Location = new System.Drawing.Point(3, 106);
            this.ServerStatusPortLbl.Name = "ServerStatusPortLbl";
            this.ServerStatusPortLbl.Size = new System.Drawing.Size(344, 26);
            this.ServerStatusPortLbl.TabIndex = 36;
            this.ServerStatusPortLbl.Text = "Port:";
            this.ServerStatusPortLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerStatusPortInfoLbl
            // 
            this.ServerStatusPortInfoLbl.Font = new System.Drawing.Font("Consolas", 14F);
            this.ServerStatusPortInfoLbl.Location = new System.Drawing.Point(3, 141);
            this.ServerStatusPortInfoLbl.Name = "ServerStatusPortInfoLbl";
            this.ServerStatusPortInfoLbl.Size = new System.Drawing.Size(344, 26);
            this.ServerStatusPortInfoLbl.TabIndex = 35;
            this.ServerStatusPortInfoLbl.Text = "Unknown";
            this.ServerStatusPortInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerStatusIPLbl
            // 
            this.ServerStatusIPLbl.Font = new System.Drawing.Font("Consolas", 14F);
            this.ServerStatusIPLbl.Location = new System.Drawing.Point(3, 36);
            this.ServerStatusIPLbl.Name = "ServerStatusIPLbl";
            this.ServerStatusIPLbl.Size = new System.Drawing.Size(344, 26);
            this.ServerStatusIPLbl.TabIndex = 34;
            this.ServerStatusIPLbl.Text = "IP:";
            this.ServerStatusIPLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerStatusIPInfoLbl
            // 
            this.ServerStatusIPInfoLbl.Font = new System.Drawing.Font("Consolas", 14F);
            this.ServerStatusIPInfoLbl.Location = new System.Drawing.Point(3, 71);
            this.ServerStatusIPInfoLbl.Name = "ServerStatusIPInfoLbl";
            this.ServerStatusIPInfoLbl.Size = new System.Drawing.Size(344, 26);
            this.ServerStatusIPInfoLbl.TabIndex = 33;
            this.ServerStatusIPInfoLbl.Text = "Unknown";
            this.ServerStatusIPInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serverStatusLbl
            // 
            this.serverStatusLbl.AutoSize = true;
            this.serverStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.serverStatusLbl.Location = new System.Drawing.Point(92, 2);
            this.serverStatusLbl.Name = "serverStatusLbl";
            this.serverStatusLbl.Size = new System.Drawing.Size(156, 29);
            this.serverStatusLbl.TabIndex = 32;
            this.serverStatusLbl.Text = "Server Status";
            // 
            // secondaryTerminalInput
            // 
            this.secondaryTerminalInput.BackColor = System.Drawing.Color.White;
            this.secondaryTerminalInput.Font = new System.Drawing.Font("Consolas", 14F);
            this.secondaryTerminalInput.ForeColor = System.Drawing.Color.Black;
            this.secondaryTerminalInput.Location = new System.Drawing.Point(184, 673);
            this.secondaryTerminalInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondaryTerminalInput.Multiline = false;
            this.secondaryTerminalInput.Name = "secondaryTerminalInput";
            this.secondaryTerminalInput.ReadOnly = true;
            this.secondaryTerminalInput.Size = new System.Drawing.Size(1147, 30);
            this.secondaryTerminalInput.TabIndex = 47;
            this.secondaryTerminalInput.Text = "op aDragz";
            // 
            // serverJarPanel
            // 
            this.serverJarPanel.BackColor = System.Drawing.Color.Transparent;
            this.serverJarPanel.Controls.Add(this.label9);
            this.serverJarPanel.Controls.Add(this.serverJarCombo);
            this.serverJarPanel.Location = new System.Drawing.Point(1336, 612);
            this.serverJarPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverJarPanel.Name = "serverJarPanel";
            this.serverJarPanel.Size = new System.Drawing.Size(349, 213);
            this.serverJarPanel.TabIndex = 45;
            this.serverJarPanel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(111, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 29);
            this.label9.TabIndex = 32;
            this.label9.Text = "Server Jar";
            // 
            // serverJarCombo
            // 
            this.serverJarCombo.Font = new System.Drawing.Font("Consolas", 14F);
            this.serverJarCombo.FormattingEnabled = true;
            this.serverJarCombo.IntegralHeight = false;
            this.serverJarCombo.Items.AddRange(new object[] {
            "server.jar"});
            this.serverJarCombo.Location = new System.Drawing.Point(3, 37);
            this.serverJarCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverJarCombo.Name = "serverJarCombo";
            this.serverJarCombo.Size = new System.Drawing.Size(344, 35);
            this.serverJarCombo.TabIndex = 33;
            this.serverJarCombo.Text = "server.jar";
            // 
            // secondaryTerminal
            // 
            this.secondaryTerminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondaryTerminal.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryTerminal.Location = new System.Drawing.Point(184, 39);
            this.secondaryTerminal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondaryTerminal.Name = "secondaryTerminal";
            this.secondaryTerminal.ReadOnly = true;
            this.secondaryTerminal.Size = new System.Drawing.Size(1147, 633);
            this.secondaryTerminal.TabIndex = 44;
            this.secondaryTerminal.Text = "Terminal Text";
            // 
            // stopBtn
            // 
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Consolas", 14F);
            this.stopBtn.Location = new System.Drawing.Point(985, 744);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(170, 72);
            this.stopBtn.TabIndex = 43;
            this.stopBtn.Text = "Stop Server";
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Consolas", 14F);
            this.startBtn.Location = new System.Drawing.Point(1161, 744);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(170, 72);
            this.startBtn.TabIndex = 42;
            this.startBtn.Text = "Start Server";
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F);
            this.button1.Location = new System.Drawing.Point(335, 769);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 12F);
            this.button2.Location = new System.Drawing.Point(226, 769);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.itemFontBtn);
            this.panel8.Controls.Add(this.itemFontLbl);
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Location = new System.Drawing.Point(0, 128);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(3);
            this.panel8.Size = new System.Drawing.Size(442, 32);
            this.panel8.TabIndex = 5;
            // 
            // itemFontBtn
            // 
            this.itemFontBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.itemFontBtn.Font = new System.Drawing.Font("Consolas", 6F);
            this.itemFontBtn.Location = new System.Drawing.Point(402, 3);
            this.itemFontBtn.Name = "itemFontBtn";
            this.itemFontBtn.Size = new System.Drawing.Size(35, 24);
            this.itemFontBtn.TabIndex = 10;
            this.itemFontBtn.Text = "...";
            this.itemFontBtn.UseVisualStyleBackColor = true;
            this.itemFontBtn.Click += new System.EventHandler(this.itemFontBtn_Click);
            // 
            // itemFontLbl
            // 
            this.itemFontLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemFontLbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.itemFontLbl.Location = new System.Drawing.Point(3, 3);
            this.itemFontLbl.Name = "itemFontLbl";
            this.itemFontLbl.Size = new System.Drawing.Size(434, 24);
            this.itemFontLbl.TabIndex = 8;
            this.itemFontLbl.Text = "Font:";
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Location = new System.Drawing.Point(0, 64);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(3);
            this.panel13.Size = new System.Drawing.Size(281, 32);
            this.panel13.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.itemTextColourBtn);
            this.panel9.Controls.Add(this.itemColourLbl);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Location = new System.Drawing.Point(0, 64);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(3);
            this.panel9.Size = new System.Drawing.Size(442, 32);
            this.panel9.TabIndex = 4;
            // 
            // itemTextColourBtn
            // 
            this.itemTextColourBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.itemTextColourBtn.Font = new System.Drawing.Font("Consolas", 6F);
            this.itemTextColourBtn.Location = new System.Drawing.Point(402, 3);
            this.itemTextColourBtn.Name = "itemTextColourBtn";
            this.itemTextColourBtn.Size = new System.Drawing.Size(35, 24);
            this.itemTextColourBtn.TabIndex = 8;
            this.itemTextColourBtn.Text = "...";
            this.itemTextColourBtn.UseVisualStyleBackColor = true;
            this.itemTextColourBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // itemColourLbl
            // 
            this.itemColourLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemColourLbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.itemColourLbl.Location = new System.Drawing.Point(3, 3);
            this.itemColourLbl.Name = "itemColourLbl";
            this.itemColourLbl.Size = new System.Drawing.Size(434, 24);
            this.itemColourLbl.TabIndex = 7;
            this.itemColourLbl.Text = "Text Colour:";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(0, 32);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(3);
            this.panel10.Size = new System.Drawing.Size(281, 32);
            this.panel10.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Location = new System.Drawing.Point(0, 64);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(3);
            this.panel11.Size = new System.Drawing.Size(281, 32);
            this.panel11.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Location = new System.Drawing.Point(0, 64);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(3);
            this.panel12.Size = new System.Drawing.Size(281, 32);
            this.panel12.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1689, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 826);
            this.panel1.TabIndex = 52;
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.selectedItemBox);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.panel14.Size = new System.Drawing.Size(442, 32);
            this.panel14.TabIndex = 4;
            // 
            // selectedItemBox
            // 
            this.selectedItemBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedItemBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedItemBox.FormattingEnabled = true;
            this.selectedItemBox.Location = new System.Drawing.Point(3, 3);
            this.selectedItemBox.Name = "selectedItemBox";
            this.selectedItemBox.Size = new System.Drawing.Size(434, 28);
            this.selectedItemBox.TabIndex = 4;
            this.selectedItemBox.SelectedIndexChanged += new System.EventHandler(this.selectedItemBox_SelectedIndexChanged);
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Location = new System.Drawing.Point(0, 64);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(3);
            this.panel15.Size = new System.Drawing.Size(281, 32);
            this.panel15.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.itemNameLbl);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(442, 32);
            this.panel4.TabIndex = 4;
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemNameLbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.itemNameLbl.Location = new System.Drawing.Point(3, 3);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(434, 24);
            this.itemNameLbl.TabIndex = 6;
            this.itemNameLbl.Text = "Name:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 32);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3);
            this.panel6.Size = new System.Drawing.Size(281, 32);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(0, 64);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(3);
            this.panel7.Size = new System.Drawing.Size(281, 32);
            this.panel7.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(0, 64);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(281, 32);
            this.panel5.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.itemBackColourBtn);
            this.panel2.Controls.Add(this.itemBackColourLbl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(442, 32);
            this.panel2.TabIndex = 2;
            // 
            // itemBackColourBtn
            // 
            this.itemBackColourBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.itemBackColourBtn.Font = new System.Drawing.Font("Consolas", 6F);
            this.itemBackColourBtn.Location = new System.Drawing.Point(402, 3);
            this.itemBackColourBtn.Name = "itemBackColourBtn";
            this.itemBackColourBtn.Size = new System.Drawing.Size(35, 24);
            this.itemBackColourBtn.TabIndex = 10;
            this.itemBackColourBtn.Text = "...";
            this.itemBackColourBtn.UseVisualStyleBackColor = true;
            this.itemBackColourBtn.Click += new System.EventHandler(this.itemBackColourBtn_Click);
            // 
            // itemBackColourLbl
            // 
            this.itemBackColourLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemBackColourLbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.itemBackColourLbl.Location = new System.Drawing.Point(3, 3);
            this.itemBackColourLbl.Name = "itemBackColourLbl";
            this.itemBackColourLbl.Size = new System.Drawing.Size(434, 24);
            this.itemBackColourLbl.TabIndex = 8;
            this.itemBackColourLbl.Text = "Back Colour:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(281, 32);
            this.panel3.TabIndex = 3;
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Arial", 14F);
            this.statusBar.Location = new System.Drawing.Point(0, 38);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(178, 811);
            this.statusBar.TabIndex = 53;
            this.statusBar.Text = "Status Bar";
            this.statusBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // themeLbl
            // 
            this.themeLbl.AutoSize = true;
            this.themeLbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.themeLbl.Location = new System.Drawing.Point(12, 7);
            this.themeLbl.Name = "themeLbl";
            this.themeLbl.Size = new System.Drawing.Size(175, 23);
            this.themeLbl.TabIndex = 54;
            this.themeLbl.Text = "Selected Theme:";
            // 
            // customizeTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2132, 826);
            this.Controls.Add(this.themeLbl);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ramUsageChart);
            this.Controls.Add(this.cpuUsageChart);
            this.Controls.Add(this.ramUsageLabel);
            this.Controls.Add(this.cpuUsageLabel);
            this.Controls.Add(this.serverStatusPanel);
            this.Controls.Add(this.secondaryTerminalInput);
            this.Controls.Add(this.serverJarPanel);
            this.Controls.Add(this.secondaryTerminal);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.terminalBackground);
            this.Controls.Add(this.themeList);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2150, 873);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(2150, 873);
            this.Name = "customizeTheme";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customizeTheme";
            this.Load += new System.EventHandler(this.customizeTheme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ramUsageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuUsageChart)).EndInit();
            this.serverStatusPanel.ResumeLayout(false);
            this.serverStatusPanel.PerformLayout();
            this.serverJarPanel.ResumeLayout(false);
            this.serverJarPanel.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox themeList;
        private System.Windows.Forms.FlowLayoutPanel terminalBackground;
        private System.Windows.Forms.DataVisualization.Charting.Chart ramUsageChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuUsageChart;
        private System.Windows.Forms.Label ramUsageLabel;
        private System.Windows.Forms.Label cpuUsageLabel;
        private System.Windows.Forms.Panel serverStatusPanel;
        private System.Windows.Forms.Label ServerStatusPortLbl;
        private System.Windows.Forms.Label ServerStatusPortInfoLbl;
        private System.Windows.Forms.Label ServerStatusIPLbl;
        private System.Windows.Forms.Label ServerStatusIPInfoLbl;
        private System.Windows.Forms.Label serverStatusLbl;
        private System.Windows.Forms.RichTextBox secondaryTerminalInput;
        private System.Windows.Forms.Panel serverJarPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox serverJarCombo;
        private System.Windows.Forms.RichTextBox secondaryTerminal;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.Label itemColourLbl;
        private System.Windows.Forms.Button itemTextColourBtn;
        private System.Windows.Forms.Label itemFontLbl;
        private System.Windows.Forms.Label itemBackColourLbl;
        private System.Windows.Forms.Button itemFontBtn;
        private System.Windows.Forms.Button itemBackColourBtn;
        private System.Windows.Forms.Label statusBar;
        private System.Windows.Forms.ComboBox selectedItemBox;
        private System.Windows.Forms.Label themeLbl;
    }
}