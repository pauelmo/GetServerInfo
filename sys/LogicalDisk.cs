using System;
using System.Collections.Generic;
using System.Management;
using System.Linq;
using System.Text;


namespace _sys
{
    public partial class _WMI
    {
        public class LogicalDisk
        {

            public static _WMI.MachineObject GetDetailedHardDriveInfo(
                MachineObject machineObject)
            {
                if (String.IsNullOrEmpty(machineObject.MachineName))
                {
                    machineObject.MachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                try
                {
                    ManagementObjectCollection objWMIQueryCollection =
                        _WMI.GetWMIQueryCollection(
                            machineObject.MachineName,
                            "\\root\\cimv2",
                            "SELECT * FROM Win32_LogicalDisk WHERE DriveType = 3");

                    foreach (ManagementObject objItem in objWMIQueryCollection)
                    {
                        if (objItem["Name"] != null)
                        {
                            HardDrive tempHardDrive = new HardDrive();

                            tempHardDrive.Drive = objItem["Name"].ToString();

                            if (objItem["VolumeName"] != null |
                                objItem["VolumeName"] != string.Empty)
                            {
                                tempHardDrive.VolumeName = objItem["VolumeName"].ToString();
                            }
                            else
                            {
                                tempHardDrive.VolumeName = "(BLANK)";
                            }

                            tempHardDrive.SerialNumber = objItem["VolumeSerialNumber"].ToString();
                            tempHardDrive.FileSystem = objItem["FileSystem"].ToString();

                            tempHardDrive.DiskSize = (Convert.ToInt64(objItem["Size"]));
                            tempHardDrive.DiskSize = (tempHardDrive.DiskSize / 1073741824);
                            tempHardDrive.DiskSize = decimal.Round(tempHardDrive.DiskSize, 3);

                            tempHardDrive.DiskSpaceFree = (Convert.ToInt64(objItem["FreeSpace"]));
                            tempHardDrive.DiskSpaceFree = (tempHardDrive.DiskSpaceFree / 1073741824);
                            tempHardDrive.DiskSpaceFree = decimal.Round(tempHardDrive.DiskSpaceFree, 3);

                            tempHardDrive.DiskSpaceUsed = tempHardDrive.DiskSize - tempHardDrive.DiskSpaceFree;
                            tempHardDrive.DiskSpaceUsed = decimal.Round(tempHardDrive.DiskSpaceUsed, 3);

                            machineObject.HardDrive.Add(tempHardDrive);
                            tempHardDrive = null;
                        }
                    }

                }
                catch (Exception e)
                {
                    machineObject.GetLastError = e.Message;
                }

                return machineObject;
            }


            public static string GetDetailedHardDriveInfo(
                string strMachineName)
            {
                string strResults = null;
                string strDriveVolume = null;
                string strDriveVolumeName = null;
                string strFileSystem = null;
                string strSerialNumber = null;

                decimal decDiskSize = 0;
                decimal decDiskSpaceFree = 0;
                decimal decDiskSpaceUsed = 0;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                try
                {
                    ManagementObjectCollection objWMIQueryCollection = _WMI.GetWMIQueryCollection(
                    strMachineName,
                    "\\root\\cimv2",
                    "SELECT * FROM Win32_LogicalDisk WHERE DriveType = 3");


                    foreach (ManagementObject objItem in objWMIQueryCollection)
                    {
                        if (objItem["Name"] != null)
                        {
                            strDriveVolume = objItem["Name"].ToString();
                        }

                        if (objItem["VolumeName"] != null)
                        {
                            strDriveVolumeName = objItem["VolumeName"].ToString();
                        }

                        if (strDriveVolumeName == "")
                        {
                            strDriveVolumeName = "(BLANK)";
                        }

                        if (objItem["FileSystem"] != null)
                        {
                            strFileSystem = objItem["FileSystem"].ToString();
                        }

                        if (objItem["VolumeSerialNumber"] != null)
                        {
                            strSerialNumber = objItem["VolumeSerialNumber"].ToString();
                        }

                        decDiskSize = (Convert.ToInt64(objItem["Size"]));
                        decDiskSize = (decDiskSize / 1073741824);
                        decDiskSize = decimal.Round(decDiskSize, 3);

                        decDiskSpaceFree = Convert.ToInt64(objItem["FreeSpace"]);
                        decDiskSpaceFree = (decDiskSpaceFree / 1073741824);
                        decDiskSpaceFree = decimal.Round(decDiskSpaceFree, 3);

                        decDiskSpaceUsed = (decDiskSize - decDiskSpaceFree);
                        decDiskSpaceUsed = decimal.Round(decDiskSpaceUsed, 3);

                        if (strResults == null | strResults == "")
                        {
                            strResults = "Drive: " + strDriveVolume + "; " +
                                "Volume: " + strDriveVolumeName + "; " +
                                "File System:  " + strFileSystem + "; " + "\r\n" +
                                "Size: " + decDiskSize.ToString() + " GB; " +
                                "Used Space: " + decDiskSpaceUsed.ToString() + " GB; " +
                                "Free Space: " + decDiskSpaceFree.ToString() + " GB; " + "\r\n" +
                                "Serial: " + strSerialNumber;
                        }
                        else
                        {
                            strResults = strResults + "\r\n" +
                                "Drive: " + strDriveVolume + "; " +
                                "Volume: " + strDriveVolumeName + "; " +
                                "File System:  " + strFileSystem + "; " + "\r\n" +
                                "Size: " + decDiskSize.ToString() + " GB; " +
                                "Used Space: " + decDiskSpaceUsed.ToString() + " GB; " +
                                "Free Space: " + decDiskSpaceFree.ToString() + " GB; " + "\r\n" +
                                "Serial: " + strSerialNumber;
                        }

                    }

                    strMachineName = null;
                    strFileSystem = null;
                    strSerialNumber = null;
                    decDiskSize = 0;
                    decDiskSpaceFree = 0;
                    decDiskSpaceUsed = 0;
                }
                catch
                {

                }

                return strResults;
            }


            public static string GetDetailedUSBDriveInfo(
                string strMachineName)
            {
                string strResults = null;
                string strUSBDriveCount = null;

                string strDriveVolume = null;
                string strDriveVolumeName = null;
                string strFileSystem = null;
                string strSerialNumber = null;

                decimal decDiskSize = 0;
                decimal decDiskSpaceFree = 0;
                decimal decDiskSpaceUsed = 0;

                int intUSBDriveCount = 0;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                try
                {
                    ManagementObjectCollection objWMIQueryCollection = _WMI.GetWMIQueryCollection(
                    strMachineName,
                    "\\root\\cimv2",
                    "SELECT * FROM Win32_LogicalDisk WHERE Description = 'Removable Disk'");

                    strUSBDriveCount = GetUSBDriveCountDetails(strMachineName);
                    intUSBDriveCount = GetUSBDriveCount(strMachineName);

                    foreach (ManagementObject objItem in objWMIQueryCollection)
                    {
                        if (objItem["Name"] != null)
                        {
                            strDriveVolume = objItem["Name"].ToString();
                        }

                        if (objItem["VolumeName"] != null)
                        {
                            strDriveVolumeName = objItem["VolumeName"].ToString();
                        }

                        if (strDriveVolumeName == "")
                        {
                            strDriveVolumeName = "(BLANK)";
                        }

                        if (objItem["FileSystem"] != null)
                        {
                            strFileSystem = objItem["FileSystem"].ToString();
                        }

                        if (objItem["VolumeSerialNumber"] != null)
                        {
                            strSerialNumber = objItem["VolumeSerialNumber"].ToString();
                        }

                        decDiskSize = (Convert.ToInt64(objItem["Size"]));
                        decDiskSize = (decDiskSize / 1073741824);
                        decDiskSize = decimal.Round(decDiskSize, 3);

                        decDiskSpaceFree = Convert.ToInt64(objItem["FreeSpace"]);
                        decDiskSpaceFree = (decDiskSpaceFree / 1073741824);
                        decDiskSpaceFree = decimal.Round(decDiskSpaceFree, 3);

                        decDiskSpaceUsed = (decDiskSize - decDiskSpaceFree);
                        decDiskSpaceUsed = decimal.Round(decDiskSpaceUsed, 3);

                        if (strResults == null | strResults == "")
                        {

                            strResults = "Drive: " + strDriveVolume + "; " + "\t" +
                                "Volume: " + strDriveVolumeName + "; " + "\t" +
                                "File System:  " + strFileSystem + "; " + "\t" +
                                "Size: " + decDiskSize.ToString() + " GB; " + "\t" +
                                "Used Space: " + decDiskSpaceUsed.ToString() + " GB; " + "\t" +
                                "Free Space: " + decDiskSpaceFree.ToString() + " GB; " + "\t" +
                                "Serial: " + strSerialNumber;
                        }
                        else
                        {
                            strResults = strResults + "\r\n" +
                                "Drive: " + strDriveVolume + "; " + "\t" +
                                "Volume: " + strDriveVolumeName + "; " + "\t" +
                                "File System:  " + strFileSystem + "; " + "\t" +
                                "Size: " + decDiskSize.ToString() + " GB; " + "\t" +
                                "Used Space: " + decDiskSpaceUsed.ToString() + " GB; " + "\t" +
                                "Free Space: " + decDiskSpaceFree.ToString() + " GB; " + "\t" +
                                "Serial: " + strSerialNumber;
                        }

                    }

                    if (intUSBDriveCount == 0)
                    {
                        strResults = "No USB drives were detected on the " + strMachineName + " machine.";
                    }

                    strMachineName = null;
                    strDriveVolume = null;
                    strDriveVolumeName = null;
                    strFileSystem = null;
                    strSerialNumber = null;
                    decDiskSize = 0;
                    decDiskSpaceFree = 0;
                    decDiskSpaceUsed = 0;
                }
                catch
                {

                }

                return strResults;
            }







            public static string GetUSBDriveLetter(
                string strMachineName,
                string strSerialNumber)
            {
                string strResults = null;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectCollection objWMIQueryCollection = _WMI.GetWMIQueryCollection(
                    strMachineName,
                    "\\root\\cimv2",
                    "SELECT * FROM Win32_LogicalDisk WHERE DriveType = '2' AND VolumeSerialNumber = '" + strSerialNumber + "'");

                foreach (ManagementObject objItem in objWMIQueryCollection)
                {
                    strResults = objItem["Name"].ToString();
                }

                if (strResults == null)
                {
                    strResults = "No drive found with specified serial number.";
                }

                return strResults;
            }




            public static string GetUSBSerialNumber(
                string strMachineName,
                string strDriveLetter)
            {
                string strResults = null;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectCollection objWMIQueryCollection = _WMI.GetWMIQueryCollection(
                    strMachineName,
                    "\\root\\cimv2",
                    "SELECT * FROM Win32_LogicalDisk WHERE DriveType = '2' AND Name = '" + strDriveLetter + "'");

                foreach (ManagementObject objItem in objWMIQueryCollection)
                {
                    strResults = objItem["VolumeSerialNumber"].ToString();
                }

                if (strResults == null)
                {
                    strResults = "No drive found with specified drive letter.";
                }

                return strResults;
            }




            public static string GetUSBDriveCountDetails(
                string strMachineName)
            {
                string strResults = null;
                int intDriveCount = 0;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectCollection objWMIQueryCollection = _WMI.GetWMIQueryCollection(
                    strMachineName,
                    "\\root\\cimv2",
                    "SELECT * FROM Win32_LogicalDisk WHERE Description = 'Removable Disk'");


                foreach (ManagementObject objCount in objWMIQueryCollection)
                {
                    intDriveCount++;
                }

                if (intDriveCount == 0)
                {
                    strResults = "No USB drives were detected on the " + strMachineName + " machine.";
                    Console.WriteLine("No USB drives were detected on the " + strMachineName + " machine.");
                }

                if (intDriveCount == 1)
                {
                    strResults = "Detected (1) USB drive attached to the " + strMachineName + " machine.";
                    Console.WriteLine("Detected (1) USB drive attached to the " + strMachineName + " machine.");
                }

                if (intDriveCount > 1)
                {
                    strResults = "Detected (" + intDriveCount + ") USB drives attached to the " + strMachineName + " machine.";
                    Console.WriteLine("Detected (" + intDriveCount + ") USB drives attached to the " + strMachineName + " machine.");
                }


                return strResults;
            }



            public static int GetUSBDriveCount(
                string strMachineName)
            {
                int intDriveCount = 0;

                ManagementObjectSearcher WMISearcher =
                new ManagementObjectSearcher(
                        @"\\" +
                        strMachineName +
                        "Win_32LogicalDisk",
                        "SELECT * FROM Win32_LogicalDisk WHERE Description = 'Removable Disk");

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectCollection objWMIQueryCollection = _WMI.GetWMIQueryCollection(
                    strMachineName,
                    "\\root\\cimv2",
                    "SELECT * FROM Win32_LogicalDisk WHERE Description = 'Removable Disk'");


                foreach (ManagementObject objCount in objWMIQueryCollection)
                {
                    intDriveCount++;
                }

                if (intDriveCount == 0)
                {
                    Console.WriteLine("No USB drives were detected.");
                }

                if (intDriveCount == 1)
                {
                    Console.WriteLine("Detected (1) USB drive.");
                }

                if (intDriveCount > 1)
                {
                    Console.WriteLine("Detected (" + intDriveCount + ") USB drives.");
                }

                return intDriveCount;

            }


            private static string _Win32_LogicalDisk(
                string strMachineName,
                string strProperty)
            {
                string strResults = null;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectCollection objWMIQueryCollection = _WMI.GetWMIQueryCollection(
                    strMachineName,
                    "\\root\\cimv2",
                    "SELECT * FROM Win32_LogicalDisk");

                foreach (ManagementObject objItem in objWMIQueryCollection)
                {
                    strResults = objItem[strProperty].ToString();
                }

                return strResults;
            }
        }
    }
}
