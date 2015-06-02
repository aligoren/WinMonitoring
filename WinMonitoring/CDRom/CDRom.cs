using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace WinMonitoring.CDRom
{
    class CDRom
    {
        public string CRom()
        {
            string retBB = "Caption";
            SelectQuery sq = new SelectQuery("Win32_CDROMDrive");
            ManagementObjectSearcher mos = new ManagementObjectSearcher(sq);
            string[] list = { "Caption", "Availability", "CompressionMethod", "ConfigManagerErrorCode",
                                "ConfigManagerErrorCode", 
                                "ConfigManagerUserConfig", "CreationClassName", "DefaultBlockSize", "Description", 
                                "DeviceID", "Drive", "DriveIntegrity", "ErrorCleared", 
                                "ErrorDescription", "ErrorMethodology", "FileSystemFlags", "FileSystemFlagsEx", "Id", 
                                "InstallDate", "LastErrorCode", "Manufacturer", "MaxBlockSize", "MaximumComponentLength",
                                "MaxMediaSize", "MediaLoaded", "MediaType", "MfrAssignedRevisionLevel", "MinBlockSize", 
                                "Name", "NeedsCleaning", "NumberOfMediaSupported", "PNPDeviceID", "PowerManagementSupported", 
                                "RevisionLevel", "SCSIBus", "SCSILogicalUnit", "SCSIPort", "SCSITargetId", "SerialNumber", 
                                "Size", "Status", "StatusInfo", "SystemCreationClassName", "SystemName", "TransferRate", 
                                "VolumeName", "VolumeSerialNumber"};

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
