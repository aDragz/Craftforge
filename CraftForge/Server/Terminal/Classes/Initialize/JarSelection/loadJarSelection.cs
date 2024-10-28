using CraftForge.Server.GUI.Console;
using System;
using System.IO;
using System.Windows.Forms;

namespace CraftForge.Server.Classes.Console.Initialize.JarSelection
{
    internal class loadJarSelection
    {
        public static bool initializeJar(Terminal terminal, ComboBox serverJarCombo)
        {
            //Load jar selection text
            //Grab this.name and remove anything after :
            String[] name = terminal.Name.Split(':');

            String location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("/CraftForge/Servers/" + name[0]);

            //Read start.bat file
            String text = File.ReadAllText(location + "\\start.bat");

            //Check if the server contains ".jar", and if it matches the serverJarCombo
            String[] words = text.Split(' ');
            String textJar = "";

            foreach (String word in words)
            {
                if (word.Contains(".jar"))
                {
                    textJar = word;
                }
            }

            if (textJar != null)
            {
                serverJarCombo.Text = textJar;
            }

            //Does not contain any in start.bat file
            if (serverJarCombo.Text == "")
            {
                //Grab all files in the directory, with the extension .jar
                string[] files = Directory.GetFiles(location, "*.jar");
                serverJarCombo.Items.Clear();

                //Grab all files in the directory, with the extension .jar, and select the first one
                //So when the user starts the server, it will not return null, and start with the selected jar
                serverJarCombo.Text = Path.GetFileName(files[0]);

                //Force Update the start.bat file
                return true;
            }

            return false;
        }
    }
}
