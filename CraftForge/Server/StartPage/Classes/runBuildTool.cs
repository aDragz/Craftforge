using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftForge.Server.StartPage.Classes
{
    internal class runBuildTool
    {
        public static void runTool(string directory, string spigotVersion)
        {
            try
            {
                Process cmdProcess = new Process(); //Create a new process

                cmdProcess.StartInfo = new ProcessStartInfo //Generate the process info
                {
                    FileName = "cmd.exe",
                    WorkingDirectory = directory,
                    Arguments = $"/c title Spigot - Build Tools && " +
                    $"curl -o BuildTools.jar https://hub.spigotmc.org/jenkins/job/BuildTools/lastSuccessfulBuild/artifact/target/BuildTools.jar && " +
                    $"java -jar BuildTools.jar --rev {spigotVersion}",
                };

                cmdProcess.Start(); //Start the process
                cmdProcess.WaitForExit();
            }
            catch { }
        }
    }
}
