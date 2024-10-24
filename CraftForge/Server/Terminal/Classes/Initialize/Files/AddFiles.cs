using CraftForge.Server.Classes.Console.Initialize.Files.ContextMenus;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CraftForge.Server.Classes.Console.Initialize.Files
{
    internal class AddFiles
    {
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbFileInfo, uint uFlags);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }

        public const uint SHGFI_ICON = 0x100;
        public const uint SHGFI_LARGEICON = 0x0; // 'Large icon
        public const uint SHGFI_SMALLICON = 0x1; // 'Small icon

        public static Icon GetFolderIcon(string folderPath)
        {
            SHFILEINFO shinfo = new SHFILEINFO();
            IntPtr hImgSmall = SHGetFileInfo(folderPath, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_LARGEICON);
            return Icon.FromHandle(shinfo.hIcon);
        }

        private static ContextMenu contextMenu; //Base context menu to upload files

        private static string TruncateText(string text)
        {
            if (text.Length > 16)
            {
                return text.Substring(0, 16) + "...";
            }
            return text;
        }

        public static void initializeFiles(FlowLayoutPanel panel, String directory, String serverName)
        {
            //Check contextMenu Items
            if (contextMenu == null)
            {
                contextMenu = CreateContextMenu(panel, directory, serverName);
            }

            panel.Controls.Clear();

            // Get all files in the directory
            string[] files = Directory.GetFiles(directory);
            string[] folders = Directory.GetDirectories(directory);

            // Ensure the directory ends with a backslash
            if (!directory.EndsWith("\\"))
            {
                directory += "\\";
            }

            string mainDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\Minecraft-Multiplayer-Host\\Servers\\{serverName}\\";
            string backupDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\Minecraft-Multiplayer-Host\\Backups\\{serverName}\\";

            //Add ... as a folder, to go back, at the beginning
            if (directory != mainDirectory && directory != backupDirectory)
            {
                Array.Resize(ref folders, folders.Length + 1);
                Array.Copy(folders, 0, folders, 1, folders.Length - 1);
                folders[0] = "...";
            }

            // For each file, add a panel with the file name and icon
            addToPanel(folders, directory, serverName, panel);
            addToPanel(files, directory, serverName, panel);
        }

        private static void addToPanel(string[] folders, string directory, string serverName, FlowLayoutPanel panel)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new Action(() => addToPanel(folders, directory, serverName, panel)));
                return;
            }

            panel.ContextMenu = CreateContextMenu(panel, directory, serverName);

            // Add folders
            foreach (String folder in folders)
            {
                // Create a new panel
                Panel newPanel = new Panel();
                newPanel.Size = new Size(200, 100);
                newPanel.Margin = new Padding(0, 0, 0, 0);
                newPanel.Padding = new Padding(0, 0, 0, 0);
                newPanel.BackColor = Color.Transparent;

                newPanel.Name = $"{folder}pnl"; //Make it 3 letters long, as there is a check to check to see the last 3 letters of the name

                // Create a new label
                Label newLabel = new Label();
                newLabel.Text = TruncateText(Path.GetFileName(folder));
                newLabel.Size = new Size(200, 50);
                newLabel.TextAlign = ContentAlignment.MiddleCenter;
                newLabel.Margin = new Padding(0, 0, 0, 0);
                newLabel.Padding = new Padding(0, 0, 0, 0);
                newLabel.BackColor = Color.Transparent;
                newLabel.Location = new Point(0, 50);

                newLabel.Name = $"{folder}lbl"; //Make it 3 letters long, as there is a check to check to see the last 3 letters of the name

                //Put label into middle
                newLabel.Anchor = AnchorStyles.None;

                // Create a new picture box
                PictureBox newPictureBox = new PictureBox();
                newPictureBox.Size = new Size(200, 75);
                newPictureBox.Margin = new Padding(0, 0, 0, 0);
                newPictureBox.Padding = new Padding(0, 0, 0, 0);
                newPictureBox.Location = new Point(0, 0);
                newPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                newPictureBox.Image = GetFolderIcon(folder).ToBitmap();

                newPictureBox.Name = $"{folder}ptb"; //Make it 3 letters long, as there is a check to check to see the last 3 letters of the name

                // Debug
                string iconFilePath = Path.Combine(directory, Path.GetFileNameWithoutExtension(folder) + ".png");

                // Add the label and picture box to the panel
                newPanel.Controls.Add(newLabel);
                newPanel.Controls.Add(newPictureBox);

                //Add on click, goto location of folder
                newPictureBox.DoubleClick += (sender, e) => clickEvent(folder, directory, serverName, panel);
                newLabel.DoubleClick += (sender, e) => clickEvent(folder, directory, serverName, panel);

                if (Path.GetFileName(folder) != "...")
                {
                    newPictureBox.ContextMenu = CreateCustomContextMenu(panel, directory, serverName, newPictureBox);
                    newLabel.ContextMenu = CreateCustomContextMenu(panel, directory, serverName, newLabel);
                    newPanel.ContextMenu = CreateCustomContextMenu(panel, directory, serverName, newPanel);
                }

                // Add the panel to the flow layout panel
                panel.Controls.Add(newPanel);
            }
        }

        private static void clickEvent(string fileName, string directory, string serverName, FlowLayoutPanel panel)
        {
            bool isDirectory = (File.GetAttributes(fileName) & FileAttributes.Directory) == FileAttributes.Directory;

            if (isDirectory)
            {
                if (Path.GetFileName(fileName) == "...")
                {
                    //Go back
                    directory = Directory.GetParent(directory).FullName;

                    //Grab last \\ and trim the ending

                    string lastSlash = directory.Substring(0, directory.LastIndexOf("\\"));
                    directory = lastSlash;
                }
                else
                {
                    directory = fileName;
                }

                //Clear the panel
                panel.Controls.Clear();

                //Reinitialize the files
                initializeFiles(panel, directory, serverName);
            }
            else
            {
                Process.Start(fileName);
            }
        }

        private static ContextMenu CreateContextMenu(FlowLayoutPanel panel, string directory, string serverName)
        {
            ContextMenu contextMenu = new ContextMenu();
            MenuItem uploadFiles = new MenuItem("Upload File");
            MenuItem uploadFolder = new MenuItem("Upload Folder");
            MenuItem space = new MenuItem("-");
            MenuItem openLocation = new MenuItem("Open Location");
            contextMenu.MenuItems.Add(uploadFiles);
            contextMenu.MenuItems.Add(uploadFolder);
            contextMenu.MenuItems.Add(space);
            contextMenu.MenuItems.Add(openLocation);

            //Open file dialog to upload files
            try
            {
                uploadFiles.Click += (sender, e) => UploadFile.UploadFiles(panel, directory, serverName);
                uploadFolder.Click += (sender, e) => UploadFolder.UploadFolders(panel, directory, serverName);
                openLocation.Click += (sender, e) => Process.Start(directory);
            } catch (IOException)
            {
                MessageBox.Show("File already exists in the directory");
            }

            return contextMenu;
        }

        private static ContextMenu CreateCustomContextMenu(FlowLayoutPanel panel, string directory, string serverName, Control control)
        {
            ContextMenu customContextMenu = CreateContextMenu(panel, directory, serverName);

            MenuItem openFiles = new MenuItem("Open File");
            MenuItem deleteFiles = new MenuItem("Delete File");
            MenuItem spacer = new MenuItem("-");

            //Check if folder or file, and replace file with folder
            string fileName = control.Name.Substring(0, control.Name.Length - 3);

            if (Directory.Exists(fileName))
            {
                //Replace open file with open folder
                openFiles.Text = "Open Folder";
                deleteFiles.Text = "Delete Folder";
            }

            customContextMenu.MenuItems.Add(0, spacer);
            customContextMenu.MenuItems.Add(0, deleteFiles);
            customContextMenu.MenuItems.Add(0, openFiles);

            openFiles.Click += (sender, dF) => openFile.openFiles(panel, directory, serverName, fileName);
            deleteFiles.Click += (sender, dF) => deleteFile.deleteFiles(panel, directory, serverName, fileName);

            return customContextMenu;
        }
    }
}