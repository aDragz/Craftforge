using Minecraft_Multiplayer_Host.Server.GUI.Console;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Multiplayer_Host.Server.Classes.Console.CreateConsole
{
    internal class setAffinity
    {
        public static void SetProcessAffinity(Process process, int maxCores)
        {
            //Grab all currently open Processes
            List<Process> processes = new List<Process>();
            long usedCoresMask = 0;
            if (Terminal.serverProcesses != null)
            {
                processes = Terminal.serverProcesses.Values.ToList();

                // Go through each process, and grab the core
                foreach (var proc in processes)
                {
                    usedCoresMask += proc.ProcessorAffinity.ToInt64();
                }
            }

            MessageBox.Show(usedCoresMask.ToString());

            if (maxCores < 1 || maxCores > Environment.ProcessorCount)
            {
                throw new ArgumentOutOfRangeException(nameof(maxCores), "The number of cores must be between 1 and the number of available processors.");
            }

            int affinityMask = 0;
            for (int i = 0; i < maxCores; i++)
            {
                affinityMask |= (1 << i);
            }

            // Set the processor affinity for the process
            process.ProcessorAffinity = (IntPtr)affinityMask;
        }
    }
}
