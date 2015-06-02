using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace WinMonitoring.Battery
{
    class Battery
    {
        public string Batery()
        {
            string retBB = "";
            SelectQuery sq = new SelectQuery("Win32_Battery");
            ManagementObjectSearcher mos = new ManagementObjectSearcher(sq);
            string[] list = { "Caption", "Availability", "BatteryRechargeTime", "BatteryStatus", 
                                "Chemistry", "ConfigManagerErrorCode", "ConfigManagerUserConfig", 
                                "CreationClassName", "Description", "DesignCapacity", "DesignVoltage", 
                                "DeviceID", "ErrorCleared", "ErrorDescription", "EstimatedChargeRemaining", 
                                "EstimatedRunTime", "ExpectedBatteryLife", "ExpectedLife", "FullChargeCapacity", 
                                "InstallDate", "LastErrorCode", "MaxRechargeTime", "Name", "PNPDeviceID", 
                                "PowerManagementSupported", "SmartBatteryVersion", "Status" , "StatusInfo", 
                                "SystemCreationClassName", "SystemName", "TimeOnBattery", "TimeToFullCharge"};

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
