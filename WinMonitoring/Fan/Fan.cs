using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace WinMonitoring.Fan
{
    class Fan
    {
        public string FaN()
        {
            string retBB = "";
            SelectQuery sq = new SelectQuery("Win32_Fan");
            ManagementObjectSearcher mos = new ManagementObjectSearcher(sq);
            string[] list = { "Caption", "CreationClassName", "Description", "DeviceID", 
                                "ErrorDescription", "Name", "PNPDeviceID", "Status", 
                                "SystemCreationClassName", "SystemName" };

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
