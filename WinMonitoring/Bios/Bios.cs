using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace WinMonitoring.Bios
{
    class Bios
    {
        public string BiOs()
        {
            string retBB = "";
            SelectQuery sq = new SelectQuery("Win32_BIOS");
            ManagementObjectSearcher mos = new ManagementObjectSearcher(sq);
            string[] list = { "Caption", "BuildNumber", "CodeSet", "CurrentLanguage", 
                                "Description", "IdentificationCode", "InstallableLanguages",
                                "InstallDate", "LanguageEdition", 
                                "Manufacturer", "Name", "OtherTargetOS", "PrimaryBIOS", 
                                "ReleaseDate", "SerialNumber", "SMBIOSBIOSVersion", "SMBIOSMajorVersion", 
                                "SMBIOSMinorVersion", "SMBIOSPresent", "SoftwareElementID", "SoftwareElementState",
                                "Status", "TargetOperatingSystem" , "Version" };

            foreach (ManagementObject batty in mos.Get())
            {
                foreach (var blist in list)
                {
                    //Console.WriteLine(baseboard[bblist]);
                    retBB += (string)blist + ": " + batty[blist] + "\n";
                }
            }

            return retBB;
        }
    }
}
