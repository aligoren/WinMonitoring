using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace WinMonitoring.DMAChannel
{
    class DMAChannel
    {
        public string DChan()
        {
            string retBB = "Caption";
            SelectQuery sq = new SelectQuery("Win32_DMAChannel");
            ManagementObjectSearcher mos = new ManagementObjectSearcher(sq);
            string[] list = { "Caption", "CreationClassName", "CSCreationClassName", "CSName", 
                                "Description", "Name", "Status" };

            foreach (ManagementObject cdrom in mos.Get())
            {
                foreach (var clist in list)
                {
                    //Console.WriteLine(baseboard[bblist]);
                    retBB += (string)clist + ": " + cdrom[clist] + "\n";
                }
            }

            return retBB;
        }
    }
}
