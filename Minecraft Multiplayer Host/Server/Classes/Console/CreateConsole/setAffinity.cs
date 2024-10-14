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
        //int = Process ID, int[] = Threads used
        static Dictionary<int, int[]> threadsTaken = new Dictionary<int, int[]>();
        static List<int> threadsTakenList = new List<int>();

        public static void SetProcessAffinity(Process process, Process childProcess, int maxThreads, Terminal terminal)
        {
            try
            {
                // Check if the number of threads is valid (between 1 and the number of threads in the system)
                if (maxThreads < 1 || maxThreads > Environment.ProcessorCount)
                {
                    throw new ArgumentOutOfRangeException(nameof(maxThreads), "The number of cores must be between 1 and " + Environment.ProcessorCount);
                }

                //Reset threadsTakenList so it can update it for the new server
                threadsTakenList.Clear();

                //Grab all currently open Processes
                List<int> currentProcesses = new List<int>();

                // Add the current process to the list
                foreach (int processId in Terminal.serverProcesses.Keys)
                {
                    currentProcesses.Add(processId);
                }

                // Collect keys to be removed
                List<int> keysToRemove = new List<int>();
                foreach (int processId in threadsTaken.Keys)
                {
                    if (!currentProcesses.Contains(processId))
                    {
                        keysToRemove.Add(processId);
                    }
                }

                // Remove the keys
                foreach (int processId in keysToRemove)
                {
                    threadsTaken.Remove(processId);
                }

                //Grab each thread taken
                foreach (int[] core in threadsTaken.Values)
                {
                    threadsTakenList.AddRange(core);
                }

                int affinityMask = 0;
                List<int> coresTakenFor = new List<int>();
                for (int i = 0; i < maxThreads; i++)
                {
                    //Check if coreTakenList is empty
                    if (!threadsTakenList.Contains(i))
                    {
                        affinityMask |= (1 << i);
                        coresTakenFor.Add(i);
                    }
                    else
                    {
                        maxThreads++; //Add 1 to max cores so if it's 4, it could go up to 6 if there are 2 taken cores. It will still use 4 though.
                    }
                }

                threadsTaken.Add(process.Id, coresTakenFor.ToArray());

                // Set the processor affinity for the process
                childProcess.ProcessorAffinity = (IntPtr)affinityMask;
                process.ProcessorAffinity = (IntPtr)affinityMask;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
