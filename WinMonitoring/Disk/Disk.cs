using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace WinMonitoring.Disk
{
    class Disk
    {
        public string DDisk()
        {
            string retBB = "Caption";
            SelectQuery sq = new SelectQuery("Win32_DiskDrive");
            ManagementObjectSearcher mos = new ManagementObjectSearcher(sq);
            string[] list = { "Caption", "CompressionMethod", "CreationClassName", "ErrorDescription", 
                                "ErrorMethodology", "FirmwareRevision", "InterfaceType", "Manufacturer", 
                                "MediaType", "Model", "Name", "PNPDeviceID", "SerialNumber", "Status", 
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
