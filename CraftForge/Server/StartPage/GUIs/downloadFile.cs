using Microsoft.SqlServer.Server;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraftForge.Server.GUI.Applications
{
    public partial class downloadFile : Form
    {
        private static ProgressBar progressBar1Static;
        private static Label downloadLabelStatic;
        private static downloadFile currentInstance;

        public downloadFile()
        {
            InitializeComponent();

            progressBar1Static = new ProgressBar();
            downloadLabelStatic = new Label();

            this.Controls.Add(progressBar1Static);
            this.Controls.Add(downloadLabelStatic);
        }

        private void downloadFile_Load(object sender, EventArgs e)
        {
            //Make sure it is in the middle of the form
            downloadLabelStatic.AutoSize = false; //Set to false so we can set the size of the label to be centered in the form
            downloadLabelStatic.TextAlign = ContentAlignment.MiddleCenter; // Center the text in the label

            //Set anchor
            downloadLabelStatic.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            //Set the font of the label
            downloadLabelStatic.Font = new Font("Consolas", 12, FontStyle.Bold);

            downloadLabelStatic.Location = new Point(10, 10);
            downloadLabelStatic.Size = new Size(780, 200);
            downloadLabelStatic.MaximumSize = new Size(780, 200);

            progressBar1Static.Location = new Point(40, 230);
            progressBar1Static.Size = new Size(700, 10);

            //Set the form size
            this.Size = new Size(800, 300);

            //Set the form to be in the center of the screen
            this.CenterToScreen();
        }

        public static async Task downloadUrlFileAsync(string url, string path)
        {
            //Make this the current instance, so it can be closed later when the download is complete
            currentInstance = new downloadFile();
            currentInstance.Name = url;

            currentInstance.Text = ("Downloading file from " + url + " to " + path);

            currentInstance.Show();

            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(displayProgress);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadComplete);
            await webClient.DownloadFileTaskAsync(new Uri(url), path);
            //File downloaded
            currentInstance.Close();
        }

        private static void displayProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            //Ensure the UI update is performed on the main thread
            if (downloadLabelStatic.InvokeRequired)
            {
                downloadLabelStatic.Invoke(new Action(() => displayProgress(sender, e)));
            }
            else
            {
                //Bytes
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());

                //mb
                double mbIn = bytesIn / 1_048_576; // Convert to MB
                double totalMb = totalBytes / 1_048_576; // Convert to MB


                double percentage = bytesIn / totalBytes * 100;

                //Set progress bar value
                progressBar1Static.Value = e.ProgressPercentage;

                //Set label text
                downloadLabelStatic.Text = string.Format("Downloading {0}\n\n", currentInstance.Name) +
                    string.Format("Downloaded {0:F2} MB of {1:F2} MB", mbIn, totalMb); //F2 formats number  to 2dp
            }
        }

        private static void downloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            if (currentInstance.InvokeRequired) //Ensure the UI update is performed on the main thread
                currentInstance.Invoke(new Action(() => downloadComplete(sender, e)));
        }
    }
}