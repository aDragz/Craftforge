using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftForge.Server.Classes.Console.Yaml.UpdateSettings
{
    internal class updateThreads
    {
        public static void UpdateThreads(string name, int threadCount)
        {
            //Update threads settings
            var settings = serverSettings.ReadSettings(name);
            settings.threadAmount = threadCount.ToString();
            settings.writeFile(name);
        }
    }
}
