using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Management.Instrumentation;

namespace GetServerInfo
{
    public partial class _WMI
    {


        public static _WMI.MachineObject GetServerInfo(
            _WMI.MachineObject machineObject)
        {
            string sResults = null;



            return machineObject;
        }


        public static string GetServerInfo(
            string strMachineName)
        {
            string strResults = null;
            string strReturn = null;

            strReturn = _WMI.ComputerSystemProduct.GetManufacturer(strMachineName);
            strResults = "Machine Name:  " + strReturn;

            strReturn = _WMI.ComputerSystemProduct.GetMachineModel(strMachineName);
            strResults = strResults + "\r\n" +
                "Model:  " + strReturn;

            strReturn = _WMI.ComputerSystemProduct.GetManufacturer(strMachineName);
            strResults = strResults + "\r\n" +
                "Manufacturer:  " + strReturn;

            strReturn = _WMI.ComputerSystemProduct.GetUUID(strMachineName);
            strResults = strResults + "\r\n" +
                "UUID:  " + strReturn;

            strReturn = _WMI.OperatingSystem.GetSerialNumber(strMachineName);
            strResults = strResults + "\r\n" +
                "Serial Number:  " + strReturn;

            strReturn = _WMI.OperatingSystem.GetSerialNumber(strMachineName);
            strResults = strResults + "\r\n" +
                strReturn;

            strReturn = _WMI.Processor.GetProcessorType(strMachineName);
            strResults = strResults + "\r\n" +
                "Processor(s):  " + strReturn;

            strReturn = _WMI.Processor.GetProcessorCores(strMachineName);
            strResults = strResults + "\r\n" +
                "Processor Cores:  " + strReturn;

            //strReturn = _sys.WMI.PhysicalMemory.GetTotalRAMInstalledAndString(strMachineName);
            //strResults = strResults + "\r\n" +
            //    "RAM Installed:  " + strReturn;

            //strReturn = _sys.WMI.PhysicalMemory.GetMaxRAMCapacityAndString(strMachineName);
            //strResults = strResults + "\r\n" +
            //    "Max RAM Capacity:  " + strReturn;

            strReturn = _WMI.PhysicalMemory.GetDetailedMemoryInfo(strMachineName);
            strResults = strResults + "\r\n" +
                strReturn;

            strReturn = "OS Version:  " + _WMI.OperatingSystem.GetOSVersion(strMachineName) +
                "(" + _WMI.OperatingSystem.GetOSArchitecture(strMachineName).ToString() + ")";
            strResults = strResults + "\r\n" +
                strReturn;

            strReturn = "OS Sub Version:  " + _WMI.OperatingSystem.GetOSSubVersion(strMachineName);
            strResults = strResults + "\r\n" +
                strReturn;

            strReturn = "Build Number:  " + _WMI.OperatingSystem.GetOSBuildNumber(strMachineName);
            strResults = strResults + "\r\n" +
                strReturn;

            strReturn = "OS Installation Date:  " + _WMI.OperatingSystem.GetOSInstallDate(strMachineName);
            strResults = strResults + "\r\n" +
                strReturn;

            strReturn = "Last Reboot:  " + _WMI.OperatingSystem.GetLastReboot(strMachineName);
            strResults = strResults + "\r\n" +
                strReturn;

            strReturn = "Hard Drive Information:  " + "\r\n" + _WMI.LogicalDisk.GetDetailedHardDriveInfo(strMachineName);
            strResults = strResults + "\r\n" +
                strReturn;

            strReturn = _WMI.QuickFixEngineering.GetInstalledHotFixCount(strMachineName) + " Hotfix(s) installed.";
            strResults = strResults + "\r\n" +
                strReturn;

            strReturn = _WMI.QuickFixEngineering.GetInstalledHotFixList(strMachineName);
            strResults = strResults + "\r\n" +
                strReturn;







            //strResults = _sys.WMI.ComputerSystem.GetLocalMachineName();
            //strResults = _sys.WMI.ConvertWMIDateString(txtInput.Text);
            //strResults = _sys.WMI.ComputerSystemProduct.GetManufacturer(txtInput.Text);
            //strResults = _sys.WMI.OperatingSystem.GetSerialNumber(txtInput.Text);
            //strResults = _sys.WMI.OperatingSystem.GetOSVersion(txtInput.Text);
            //strResults = _sys.WMI.OperatingSystem.GetOSArchitecture(txtInput.Text);
            //strResults = _sys.WMI.OperatingSystem.GetOSSubVersion(txtInput.Text);
            //strResults = _sys.WMI.OperatingSystem.GetOSBuildNumber(txtInput.Text);
            //strResults = _sys.WMI.OperatingSystem.GetOSInstallDate(txtInput.Text);
            //strResults = _sys.WMI.OperatingSystem.GetLastReboot(txtInput.Text);
            //strResults = _sys.WMI.Processor.GetProcessorType(txtInput.Text);
            //strResults = _sys.WMI.Processor.GetProcessorCores(txtInput.Text);
            //strResults = _sys.WMI.QuickFixEngineering.GetInstalledHotFixCount(txtInput.Text).ToString();
            //strResults = _sys.WMI.QuickFixEngineering.GetInstalledHotFixList(txtInput.Text);
            //Int64 intResults = _sys.WMI.PhysicalMemory.GetMaxRAMCapacity(txtInput.Text);
            //strResults = _sys.WMI.PhysicalMemory.GetMaxRAMCapacityAndString(txtInput.Text);
            //Int64 intResults = _sys.WMI.PhysicalMemory.GetTotalRAMInstalled(txtInput.Text);
            //strResults = _sys.WMI.PhysicalMemory.GetTotalRAMInstalledAndString(txtInput.Text);
            //strResults = _sys.WMI.PhysicalMemory.GetMemoryModuleDetails(txtInput.Text, 0, 0, "");
            //strResults = _sys.WMI.PhysicalMemory.GetDetailedMemoryInfo(txtInput.Text);
            //int intResults = _sys.WMI.PhysicalMemory.GetMemorySlotCount(txtInput.Text);
            //strResults = _sys.WMI.LogicalDisk.GetDetailedHardDriveInfo(txtInput.Text);
            //strResults = _sys.WMI.Product.GetInstalledSoftwareList(txtInput.Text);






            return strResults;
        }


        public static ManagementObjectSearcher GetWMIQuerySearcher(
            string strMachineName,
            string strWMINamespace,
            string strWMIQueryString)
        {
            if (String.IsNullOrEmpty(strMachineName))
            {
                strMachineName = ".";
            }

            ManagementObjectSearcher WMISearcher =
                new ManagementObjectSearcher(
                    @"\\" +
                    strMachineName +
                    strWMINamespace,
                    strWMIQueryString);

            WMISearcher.Scope.Options.EnablePrivileges = true;
            WMISearcher.Scope.Options.Impersonation = ImpersonationLevel.Impersonate;
            WMISearcher.Scope.Options.Authentication = AuthenticationLevel.PacketPrivacy;

            return WMISearcher;
        }




        public static ManagementObjectCollection GetWMIQueryCollection(
            string strMachineName,
            string strWMINamespace,
            string strWMIQueryString)
        {

            if (strMachineName == "" | strMachineName == null)
            {
                strMachineName = ".";
            }

            ManagementObjectSearcher WMISearcher =
                new ManagementObjectSearcher(
                        @"\\" +
                        strMachineName +
                        strWMINamespace,
                        strWMIQueryString);


            WMISearcher.Scope.Options.EnablePrivileges = true;
            WMISearcher.Scope.Options.Impersonation = ImpersonationLevel.Impersonate;
            WMISearcher.Scope.Options.Authentication = AuthenticationLevel.PacketPrivacy;


            //WMISearcher.Scope.Connect();
            ManagementObjectCollection WMIQueryCollection = null;

            try
            {
                WMIQueryCollection = WMISearcher.Get();
            }
            catch
            {
            }

            return WMIQueryCollection;

        }

        public static string ConvertWMIDateString(
            string dtmWMIDateFormat)
        {
            string strResults = null;

            try
            {
                DateTime dtConvertedDate =
                        ManagementDateTimeConverter.ToDateTime(dtmWMIDateFormat);

                strResults = dtConvertedDate.ToString();
            }
            catch
            {

            }

            return strResults;
        }


        public class HardDrive
        {
            public string Drive { get; set; }
            public string FileSystem { get; set; }
            public decimal DiskSize { get; set; }
            public decimal DiskSpaceFree { get; set; }
            public decimal DiskSpaceUsed { get; set; }
            public string SerialNumber { get; set; }
            public string VolumeName { get; set; }
        }

        public class MemorySlots
        {
            public string SlotNumber { get; set; }
            public string SlotPartNumber { get; set; }
            public string SlotSerialNumber { get; set; }
            public string SlotSize { get; set; }
        }

        public class MachineObject
        {
            public bool _Debugging { get; set; }
            public bool _Logging { get; set; }
            public string BuildNumber { get; set; }
            public bool Diagnostics { get; set; }
            public string GetLastError { get; set; }
            public List<_WMI.HardDrive> HardDrive { get; set; }
            public string HardDriveInformation { get; set; }
            public string HotFixesInstalled { get; set; }
            public int L2CacheSize { get; set; }
            public int L3CacheSize { get; set; }
            public string Language { get; set; }
            public string LastReboot { get; set; }
            public int LogicalProcessors { get; set; }
            public string MachineName { get; set; }
            public string Manufacturer { get; set; }
            public int MaxRAMCapacity { get; set; }
            public string MemoryDetails { get; set; }
            public List<MemorySlots> MemorySlots { get; set; }
            public string Model { get; set; }
            public int NumberOfMemorySlots { get; set; }
            public string OSArchitecture { get; set; }
            public string OSInstallationDate { get; set; }
            public string OSSubVersion { get; set; }
            public string OSVersion { get; set; }
            public string Processor { get; set; }
            public string ProcessorCores { get; set; }
            public string ProcessorDescription { get; set; }
            public string ProcessorID { get; set; }
            public int ProcessorLoadPercentage { get; set; }
            public string ProcessorType { get; set; }
            public int RAMInstalled { get; set; }
            public string RAMInstalledAndString { get; set; }
            public string SerialNumber { get; set; }
            public int TotalRAMInstalled { get; set; }
            public int USBDriveCount { get; set; }
            public string USBDriveCountDetails { get; set; }
            public string USBDrive1FileSystem { get; set; }
            public string USBDrive1SerialNumber { get; set; }
            public decimal USBDrive1Size { get; set; }
            public decimal USBDrive1SpaceFree { get; set; }
            public decimal USBDrive1SpaceUsed { get; set; }
            public string USBDrive1Volume { get; set; }
            public string USBDrive1VolumeName { get; set; }
            public string USBDrive2FileSystem { get; set; }
            public string USBDrive2SerialNumber { get; set; }
            public decimal USBDrive2Size { get; set; }
            public decimal USBDrive2SpaceFree { get; set; }
            public decimal USBDrive2SpaceUsed { get; set; }
            public string USBDrive2Volume { get; set; }
            public string USBDrive2VolumeName { get; set; }
            public string USBDrive3FileSystem { get; set; }
            public string USBDrive3SerialNumber { get; set; }
            public decimal USBDrive3Size { get; set; }
            public decimal USBDrive3SpaceFree { get; set; }
            public decimal USBDrive3SpaceUsed { get; set; }
            public string USBDrive3Volume { get; set; }
            public string USBDrive3VolumeName { get; set; }
            public int WindowsUpdateCount { get; set; }
            public string WindowsUpdatesInstalled { get; set; }
            public string UUID { get; set; }
            public bool VirtualizationFirmwareEnabled { get; set; }

        }

    }
}
