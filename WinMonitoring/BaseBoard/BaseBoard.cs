using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace WinMonitoring.BaseBoard
{
    class BaseBoard
    {
        public string BBoard()
        {
            string retBB = "Caption";
            SelectQuery sq = new SelectQuery("Win32_BaseBoard");
            ManagementObjectSearcher mos = new ManagementObjectSearcher(sq);
            string[] list = { "Caption", "CreationClassName", 
                                "Depth", "Description", "Height", "HostingBoard",
                                "HotSwappable", "InstallDate", "Manufacturer", "Model", "Name", 
                                "OtherIdentifyingInfo", "PartNumber", "PoweredOn", "Product", 
                                "Removable", "Replaceable", "RequirementsDescription", 
                                "RequiresDaughterBoard", "SerialNumber", "SKU", 
                                "SlotLayout", "SpecialRequirements", "Status", "Tag", 
                                "Version", "Weight", "Width" };
            foreach (ManagementObject baseboard in mos.Get())
            {
                foreach (var bblist in list)
                {
                    //Console.WriteLine(baseboard[bblist]);
                    retBB += (string)bblist + ": " + baseboard[bblist] + "\n";
                }
            }

            return retBB;

        }
    }
}
