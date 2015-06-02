using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace WinMonitoring.Bus
{
    class Bus
    {
        public string WBus()
        {
            string retBB = "";
            SelectQuery sq = new SelectQuery("Win32_Bus");
            ManagementObjectSearcher mos = new ManagementObjectSearcher(sq);
            string[] list = { "Caption", "Availability", "BusNum", "BusType", "ConfigManagerErrorCode", 
                                "ConfigManagerUserConfig", "CreationClassName", "Description", "DeviceID", 
                                "ErrorCleared", "ErrorDescription", "InstallDate", "LastErrorCode", 
                                "Name", "PNPDeviceID", "PowerManagementSupported", "Status", "StatusInfo", 
                                "SystemCreationClassName", "SystemName" };

            foreach (ManagementObject bus in mos.Get())
            {
                foreach (var blist in list)
                {
                    //Console.WriteLine(baseboard[bblist]);
                    retBB += (string)blist + ": " + bus[blist] + "\n";
                }
            }

            return retBB;
        }
    }
}
