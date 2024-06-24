using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace _sys
{
    public partial class _WMI
    {
        public class PhysicalMemory
        {

            public static string GetDetailedMemoryInfo(
                string strMachineName)
            {
                string strDetailedMemoryInfo = null;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _sys._WMI.ComputerSystem.GetLocalMachineName();
                }

                int intMemorySlotCount = GetMemorySlotCount(strMachineName);

                string strInstalledRAM = GetTotalRAMInstalledAndString(strMachineName);
                string strMaxRAMCapacity = GetMaxRAMCapacityAndString(strMachineName);
                string StrMemoryModuleDetails = GetMemoryModuleDetails(strMachineName, 0, 0, "");

                strDetailedMemoryInfo =
                    "RAM Installed:  " + strInstalledRAM + "\r\n" +
                    "Max RAM Capacity:  " + strMaxRAMCapacity + "\r\n" +
                    "Memory Slots:  " + intMemorySlotCount.ToString() + "\r\n" +
                    StrMemoryModuleDetails;

                return strDetailedMemoryInfo;
            }


            //public static string GetDetailedMemoryInfo(
            //    string strMachineName,
            //    //int intModuleNum,
            //    string strOutputFormat)
            //{
            //    string strMemoryDetail = null;
            //    string strTotalInstalled = null;
            //    string strMaxCapacity = null;

            //    int intI = 0;
            //    int intMM = 0;
            //    int intTotalInstalled = 0;
            //    int intNumSockets = 0;
            //    int intMaxCapacity = 0;
            //    int intStart = 0;
            //    int intEnd = 0;

            //    ManagementObjectCollection objWMIQueryCollection = _sys.WMI.GetWMIQueryCollection(
            //        strMachineName,
            //        "\\root\\cimv2",
            //        "Win32_PhysicalMemoryArray");

            //    int intSlotCount = 1;
            //    string strSlotCount = null;

            //    foreach (ManagementObject objItem in objWMIQueryCollection)
            //    {
            //        strSlotCount = "Slot " + intSlotCount.ToString() + ": ";

            //        intNumSockets = Convert.ToInt16(objItem["MemoryDevices"]);
            //        intMaxCapacity = Convert.ToInt16(objItem["MaxCapacity"]);
            //        intMaxCapacity = intMaxCapacity * 1024;
            //        intStart = intMM;
            //        intEnd = intMM + intNumSockets - 1;

            //        intSlotCount++;

            //        for (intI = intStart; intI <= intEnd; intI++)
            //        {
            //            strMemoryDetail = GetMemoryModuleDetails(strMachineName, intI, intTotalInstalled, strOutputFormat);
            //            intTotalInstalled = intTotalInstalled + intTotalInstalled;
            //        }
            //    }

            //    strTotalInstalled = FormatCapacity(intTotalInstalled);
            //    strMaxCapacity = FormatCapacity(intMaxCapacity);

            //    return strMemoryDetail;
            //}




            public static string GetMemoryModuleDetails(
                string strMachineName,
                int intModuleNum,
                int intTotalInstalled,
                string strOutputFormat)
            {
                string strResults = null;

                string strPartNumber = null;
                string strSerialNumber = null;
                string strLocation = null;
                string strSlotNumber = null;
                string strInstalledRAM = null;
                string strInstalledRAMFormat = null;
                string strSpeed = null;
                string strTypeDetail = null;
                Int64 intInstalledRAM = 0;
                int intTypeDetail = 0;
                int intSpeed = 0;
                int intSlotNumber = 0;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _sys._WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectSearcher objWMISearcher =
                    new ManagementObjectSearcher(
                        @"\\" +
                        strMachineName +
                        "\\root\\cimv2",
                        "SELECT * FROM Win32_PhysicalMemory");

                objWMISearcher.Scope.Options.EnablePrivileges = true;
                objWMISearcher.Scope.Options.Impersonation = ImpersonationLevel.Impersonate;
                objWMISearcher.Scope.Options.Authentication = AuthenticationLevel.PacketPrivacy;

                foreach (ManagementObject objItem in objWMISearcher.Get())
                {
                    intInstalledRAM = 0; //resetting for each enumeration

                    strSlotNumber = "Slot:  " + intSlotNumber.ToString();
                    strLocation = objItem["DeviceLocator"].ToString();

                    intInstalledRAM = Convert.ToInt64(objItem["Capacity"]);
                    strInstalledRAMFormat = GetCapacityFormat(intInstalledRAM);
                    intInstalledRAM = FormatCapacity(intInstalledRAM);
                    strInstalledRAM = intInstalledRAM.ToString() + strInstalledRAMFormat;

                    intTypeDetail = Convert.ToInt16(objItem["TypeDetail"]);
                    strTypeDetail = Convert.ToString(GetTypeDetail(intTypeDetail));

                    intSpeed = Convert.ToInt16(objItem["Speed"]);
                    strSpeed = intSpeed.ToString() + "MHz";

                    if (strSpeed == "0MHz")
                    {
                        strSpeed = null;
                    }

                    strPartNumber = Convert.ToString(objItem["PartNumber"]);

                    if (strPartNumber == "" & intInstalledRAM >= 0 | strPartNumber == null & intInstalledRAM >= 0)
                    {
                        strPartNumber = "(Virtual)";
                    }

                    strSerialNumber = Convert.ToString(objItem["SerialNumber"]);


                    if (strResults == "" | strResults == null)
                    {

                        if (strPartNumber == "(Virtual)")
                        {

                            strResults = strSlotNumber + "; " +
                                strInstalledRAM + " (Virtual)";

                        }
                        else
                        {
                            strResults = strSlotNumber + "; " +
                                            strInstalledRAM + " " +
                                            strTypeDetail + " " +
                                            strSpeed + "; " +
                                            "Part Number:  " + strPartNumber + "; " +
                                            "Serial Number:  " + strSerialNumber;
                        }

                    }
                    else
                    {
                        if (intInstalledRAM == 0)
                        {

                            strResults = "Slot: " + intSlotNumber + "--- EMPTY ---";
                        }
                        else
                        {
                            if (strPartNumber == "(Virtual)")
                            {
                                strResults = strResults + "\r\n" +
                                    strInstalledRAM + " (Virtual)";
                            }
                            else
                            {
                                strResults = strResults + "\r\n" +
                                    strSlotNumber + "; " +
                                    strInstalledRAM + " " +
                                    strTypeDetail + " " +
                                    strSpeed + "; " +
                                    "Part Number:  " + strPartNumber + "; " +
                                    "Serial Number:  " + strSerialNumber;
                            }
                        }
                    }

                    intSlotNumber++;

                }

                return strResults;
            }



            public static string GetTotalRAMInstalledAndString(
                string strMachineName)
            {
                string strTotalRAMInstalled = null;

                Int64 intTotalInstalledRAM = 0;
                Int64 intInstalledRAM = 0;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _sys._WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectSearcher objWMISearcher =
                    new ManagementObjectSearcher(
                        @"\\" +
                        strMachineName +
                        "\\root\\cimv2",
                        "SELECT * FROM Win32_PhysicalMemory");

                objWMISearcher.Scope.Options.EnablePrivileges = true;
                objWMISearcher.Scope.Options.Impersonation = ImpersonationLevel.Impersonate;
                objWMISearcher.Scope.Options.Authentication = AuthenticationLevel.PacketPrivacy;


                foreach (ManagementObject objItem in objWMISearcher.Get())
                {
                    intInstalledRAM = Convert.ToInt64(objItem["Capacity"]);
                    intTotalInstalledRAM = intTotalInstalledRAM + intInstalledRAM;
                }

                string strCapacityFormat = GetCapacityFormat(intInstalledRAM);
                intTotalInstalledRAM = FormatCapacity(intTotalInstalledRAM);
                strTotalRAMInstalled = intTotalInstalledRAM + " " + strCapacityFormat;


                return strTotalRAMInstalled;
            }




            public static Int64 GetTotalRAMInstalled(
                string strMachineName)
            {
                Int64 intTotalInstalledRAM = 0;
                Int64 intInstalledRAM = 0;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _sys._WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectSearcher objWMISearcher =
                    new ManagementObjectSearcher(
                        @"\\" +
                        strMachineName +
                        "\\root\\cimv2",
                        "SELECT * FROM Win32_PhysicalMemory");

                objWMISearcher.Scope.Options.EnablePrivileges = true;
                objWMISearcher.Scope.Options.Impersonation = ImpersonationLevel.Impersonate;
                objWMISearcher.Scope.Options.Authentication = AuthenticationLevel.PacketPrivacy;

                foreach (ManagementObject objItem in objWMISearcher.Get())
                {
                    intInstalledRAM = Convert.ToInt64(objItem["Capacity"]);
                    intTotalInstalledRAM = intTotalInstalledRAM + intInstalledRAM;

                }

                intTotalInstalledRAM = FormatCapacity(intTotalInstalledRAM);

                return intTotalInstalledRAM;
            }




            public static string GetMaxRAMCapacityAndString(
                string strMachineName)
            {
                string strMaxCapacity = null;

                Int64 intMaxCapacity = 0;
                int intFormattedCapacity = 0;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _sys._WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectSearcher objWMISearcher =
                    new ManagementObjectSearcher(
                        @"\\" +
                        strMachineName +
                        "\\root\\cimv2",
                        "SELECT * FROM Win32_PhysicalMemoryArray Where Use=3 OR Use=NULL");

                objWMISearcher.Scope.Options.EnablePrivileges = true;
                objWMISearcher.Scope.Options.Impersonation = ImpersonationLevel.Impersonate;
                objWMISearcher.Scope.Options.Authentication = AuthenticationLevel.PacketPrivacy;

                foreach (ManagementObject objItem in objWMISearcher.Get())
                {
                    intMaxCapacity = Convert.ToInt64(objItem["MaxCapacity"]);
                    intMaxCapacity = intMaxCapacity * 1024;
                }

                string strCapacityFormat = GetCapacityFormat(intMaxCapacity);
                intFormattedCapacity = FormatCapacity(intMaxCapacity);

                strMaxCapacity = intFormattedCapacity + " " + strCapacityFormat;

                return strMaxCapacity;
            }



            public static Int64 GetMaxRAMCapacity(
                string strMachineName)
            {
                Int64 intMaxCapacity = 0;
                Int64 intFormattedCapacity = 0;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _sys._WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectSearcher objWMISearcher =
                    new ManagementObjectSearcher(
                        @"\\" +
                        strMachineName +
                        "\\root\\cimv2",
                        "SELECT * FROM Win32_PhysicalMemoryArray Where Use=3 OR Use=NULL");

                objWMISearcher.Scope.Options.EnablePrivileges = true;
                objWMISearcher.Scope.Options.Impersonation = ImpersonationLevel.Impersonate;
                objWMISearcher.Scope.Options.Authentication = AuthenticationLevel.PacketPrivacy;

                foreach (ManagementObject objItem in objWMISearcher.Get())
                {
                    intMaxCapacity = Convert.ToInt64(objItem["MaxCapacity"]);
                    intMaxCapacity = intMaxCapacity * 1024;
                }

                intFormattedCapacity = FormatCapacity(intMaxCapacity);

                return intFormattedCapacity;
            }


            public static int GetMemorySlotCount(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _sys._WMI.ComputerSystem.GetLocalMachineName();
                }

                int intMemorySlotCount = Convert.ToInt16(_WMI_PhysicalMemoryArray(
                                        strMachineName,
                                        "MemoryDevices"));

                return intMemorySlotCount;
            }



            private static string GetCapacityFormat(
                Int64 intSizeInBytes)
            {
                string strCapacityFormat = null;

                if (intSizeInBytes >= 1073741824)
                {
                    strCapacityFormat = " GB";
                }
                else
                {
                    strCapacityFormat = " MB";
                }

                return strCapacityFormat;
            }



            private static int FormatCapacity(
                Int64 intSizeInBytes)
            {
                int intCapacity = 0;
                decimal decCapacity = 0;

                if (intSizeInBytes >= 1073741824)
                {
                    decCapacity = Math.Abs(intSizeInBytes / 1073741824);
                }
                else
                {
                    decCapacity = Math.Abs(intSizeInBytes / 1048576);
                }

                intCapacity = Convert.ToInt16(decCapacity);

                return intCapacity;
            }



            private static string FormatCapacity(
                int intSizeInBytes)
            {
                string strCapacity = null;

                if (intSizeInBytes >= 1073741824)
                {
                    intSizeInBytes = Math.Abs(intSizeInBytes);
                }

                strCapacity = intSizeInBytes.ToString() + " GB";

                return strCapacity;
            }

            private static string GetMemoryType(
                int intTypeID)
            {
                string strMemoryType = null;

                switch (intTypeID)
                {
                    case 0:
                        strMemoryType = "Unknown";
                        break;

                    case 1:
                        strMemoryType = "Other";
                        break;

                    case 2:
                        strMemoryType = "DRAM";
                        break;

                    case 3:
                        strMemoryType = "Synchronous DRAM";
                        break;

                    case 4:
                        strMemoryType = "Cache DRAM";
                        break;

                    case 5:
                        strMemoryType = "EDO";
                        break;

                    case 6:
                        strMemoryType = "EDRAM";
                        break;

                    case 7:
                        strMemoryType = "VRAM";
                        break;

                    case 8:
                        strMemoryType = "SRAM";
                        break;

                    case 9:
                        strMemoryType = "RAM";
                        break;

                    case 10:
                        strMemoryType = "ROM";
                        break;

                    case 11:
                        strMemoryType = "Flash";
                        break;

                    case 12:
                        strMemoryType = "EEPROM";
                        break;

                    case 13:
                        strMemoryType = "FEPROM";
                        break;

                    case 14:
                        strMemoryType = "EPROM";
                        break;

                    case 15:
                        strMemoryType = "CDRAM";
                        break;

                    case 16:
                        strMemoryType = "3DRAM";
                        break;

                    case 17:
                        strMemoryType = "SDRAM";
                        break;

                    case 18:
                        strMemoryType = "SGRAM";
                        break;

                    case 19:
                        strMemoryType = "RDRAM";
                        break;

                    case 20:
                        strMemoryType = "DDR";
                        break;

                    case 21:
                        strMemoryType = "DDR-2";
                        break;
                }

                return strMemoryType;
            }


            private static string GetTypeDetail(
                int intTypeID)
            {
                string strTypeID = null;

                switch (intTypeID)
                {
                    case 1:
                        strTypeID = "Reserved";
                        break;

                    case 2:
                        strTypeID = "Other";
                        break;

                    case 4:
                        strTypeID = "Unknown";
                        break;

                    case 8:
                        strTypeID = "Fast-paged";
                        break;

                    case 16:
                        strTypeID = "Static column";
                        break;

                    case 32:
                        strTypeID = "Pseudo-static";
                        break;

                    case 64:
                        strTypeID = "RAMBUS";
                        break;

                    case 128:
                        strTypeID = "Synchronous";
                        break;

                    case 256:
                        strTypeID = "CMOS";
                        break;

                    case 512:
                        strTypeID = "EDO";
                        break;

                    case 1024:
                        strTypeID = "Window DRAM";
                        break;

                    case 2048:
                        strTypeID = "Cache DRAM";
                        break;

                    case 4096:
                        strTypeID = "Non-volatile";
                        break;

                }

                return strTypeID;
            }


            private static string GetSpeed(
                int intSpeedID)
            {
                string strSpeedID = null;

                switch (intSpeedID)
                {
                    case 266:
                        strSpeedID = "PC2100";
                        break;

                    case 333:
                        strSpeedID = "PC2600";
                        break;

                    case 400:
                        strSpeedID = "PC3200";
                        break;

                    case 667:
                        strSpeedID = "PC5300";
                        break;
                }

                return strSpeedID;

            }




            private static string _WMI_PhysicalMemoryArray(
                string strMachineName,
                string strProperty)
            {
                string strReturn = null;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _sys._WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectCollection objWMIQueryCollection = _sys._WMI.GetWMIQueryCollection(
                    strMachineName,
                    "\\root\\cimv2",
                    "SELECT * FROM Win32_PhysicalMemoryArray");

                foreach (ManagementObject objItem in objWMIQueryCollection)
                {
                    strReturn = objItem[strProperty].ToString();
                }

                return strReturn;
            }



            private static string _WMI_PhysicalMemory(
                string strMachineName,
                string strProperty)
            {
                string strReturn = null;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _sys._WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectCollection objWMIQueryCollection = _sys._WMI.GetWMIQueryCollection(
                    strMachineName,
                    "\\root\\cimv2",
                    "Win32_PhysicalMemory");

                foreach (ManagementObject objItem in objWMIQueryCollection)
                {
                    strReturn = objItem[strProperty].ToString();
                }

                return strReturn;
            }
        }
    }
}
