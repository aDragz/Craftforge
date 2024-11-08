using CraftForge.Server.Events;
using CraftForge.Server.GUI.Console;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraftForge.Server.Classes.Player
{
    internal class playerJoin
    {
        public static async Task addPlayer(FlowLayoutPanel panel, string playerName, Process process, TabControl serverTabs, int consoleID, Terminal terminal)
        {
            //Create the player panel
            Panel playerPanel = new Panel();
            playerPanel.Size = new System.Drawing.Size(500, 100);
            playerPanel.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            playerPanel.BorderStyle = BorderStyle.FixedSingle;
            playerPanel.Name = playerName;

            //Player Name
            Label playerNameLabel = new Label();
            playerNameLabel.Text = playerName;
            playerNameLabel.Location = new System.Drawing.Point(105, 10);
            playerNameLabel.Font = new System.Drawing.Font("Arial", 12);
            playerNameLabel.Size = new System.Drawing.Size(200, 25);

            //Skull of playerName
            PictureBox playerHead = new PictureBox();
            playerHead.Load("https://minotar.net/helm/" + playerName + "/100.png"); //Loading async doesn't seem to work for some reason
            playerHead.Location = new System.Drawing.Point(0, 0);
            playerHead.Size = new System.Drawing.Size(100, 100);

            ComboBox playerControlComboBox = new ComboBox();
            playerControlComboBox.Location = new System.Drawing.Point(105, 45);
            playerControlComboBox.Size = new System.Drawing.Size(150, 25);
            playerControlComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            playerControlComboBox.Items.Add("Controls");
            playerControlComboBox.Items.Add("Ban");
            playerControlComboBox.Items.Add("Kick");
            playerControlComboBox.Items.Add(" ");
            playerControlComboBox.Items.Add("Op");
            playerControlComboBox.Items.Add("Deop");
            playerControlComboBox.Items.Add(" ");
            playerControlComboBox.Items.Add("Whitelist");
            playerControlComboBox.Items.Add("Unwhitelist");

            playerControlComboBox.Text = "Controls";

            //Click event for the playerControlComboBox
            playerControlComboBox.SelectedIndexChanged += (sender, e) => playerControlComboBox_Click(sender, e, process, serverTabs, consoleID, terminal);

            if (panel.InvokeRequired)
            {
                panel.Invoke(new Action(() =>
                {
                    playerPanel.Controls.Add(playerNameLabel);
                    playerPanel.Controls.Add(playerHead);
                    playerPanel.Controls.Add(playerControlComboBox);
                    panel.Controls.Add(playerPanel);
                }));
            }
            else
            {
                playerPanel.Controls.Add(playerNameLabel);
                playerPanel.Controls.Add(playerHead);
                playerPanel.Controls.Add(playerControlComboBox);
                panel.Controls.Add(playerPanel);
            }
        }



        public static void playerControlComboBox_Click(object sender, EventArgs e, Process process, TabControl serverTabs, int consoleID, Terminal terminal)
        {
            ComboBox playerControlComboBox = (ComboBox)sender;
            string playerName = playerControlComboBox.Parent.Controls[0].Text;
            string control = playerControlComboBox.SelectedItem.ToString();

            switch (control)
            {
                case "Ban":
                    enterCommand.runCommand($"ban {playerName}", process, serverTabs, consoleID, terminal);
                    break;
                case "Kick":
                    enterCommand.runCommand($"kick {playerName}", process, serverTabs, consoleID, terminal);
                    break;
                case "Op":
                    enterCommand.runCommand($"op {playerName}", process, serverTabs, consoleID, terminal);
                    break;
                case "Deop":
                    enterCommand.runCommand($"deop {playerName}", process, serverTabs, consoleID, terminal);
                    break;
                case "Whitelist":
                    enterCommand.runCommand($"whitelist add {playerName}", process, serverTabs, consoleID, terminal);
                    break;
                case "Unwhitelist":
                    enterCommand.runCommand($"whitelist remove {playerName}", process, serverTabs, consoleID, terminal);
                    break;
                default:
                    break;

            }

            playerControlComboBox.Text = "Controls";
        }
    }
}
