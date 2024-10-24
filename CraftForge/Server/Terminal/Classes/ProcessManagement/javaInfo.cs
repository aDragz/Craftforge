using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraftForge.Server.GUI.Console.Classes
{
    internal class javaInfo
    {
        public static async Task<Process[]> GetChildProcessesAsync(int parentId)
        {
            var query = $"SELECT * FROM Win32_Process WHERE ParentProcessId={parentId}";
            var searcher = new ManagementObjectSearcher(query);
            var results = searcher.Get();

            //Wait 0.5Seconds
            await Task.Delay(500);

            return results.Cast<ManagementObject>().Select(p => Process.GetProcessById(Convert.ToInt32(p["ProcessId"]))).ToArray();
        }

        public static async Task<int> grabProcessID()
        {
            Process javaProcess = null;
            while (javaProcess == null) //Use while loop, in case they have a "slower" computer, so it takes time to grab the value.
            {
                javaProcess = Process.GetProcessesByName("java").FirstOrDefault();
                if (javaProcess == null)
                {
                    MessageBox.Show("No java.exe process found. Retrying in 1 second...");
                    await Task.Delay(1000); // Wait for 1 second before retrying
                }
            }
            return javaProcess.Id;
        }
    }
}
