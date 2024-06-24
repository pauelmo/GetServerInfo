using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace GetServerInfo
{
    public partial class _WMI
    {

        public class QuickFixEngineering
        {


            public static string GetInstalledHotFixList(
                string strMachineName)
            {
                string strResults = null;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                try
                {
                    ManagementObjectCollection objWMIQueryCollection = _Win32_QuickFixEngineering(
                    strMachineName);

                    foreach (ManagementObject objItem in objWMIQueryCollection)
                    {
                        strResults = strResults +
                            "Hotfix ID:  " + objItem["HotFixID"].ToString() + "\r\n" +
                            "Description:   " + objItem["Description"].ToString() + "\r\n" +
                            "Installation Date:  " + objItem["InstalledOn"].ToString() + "\r\n" +
                            "Installed By:  " + objItem["InstalledBy"].ToString() + "\r\n" + "\r\n";
                    }
                }
                catch
                {

                }                

                return strResults;
            }




            public static int GetInstalledHotFixCount(
                string strMachineName)
            {
                int intHotFixCount = 0;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectCollection objWMIQueryCollection = _Win32_QuickFixEngineering(
                    strMachineName);

                foreach (ManagementObject objItem in objWMIQueryCollection)
                {
                    intHotFixCount++;
                }

                return intHotFixCount;
            }





            private static ManagementObjectCollection _Win32_QuickFixEngineering(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectCollection objWMIQueryCollection = _WMI.GetWMIQueryCollection(
                    strMachineName,
                    "\\root\\cimv2",
                    "SELECT * FROM Win32_QuickFixEngineering");

                return objWMIQueryCollection;
            }


            private static string _Win32_QuickFixEngineering(
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
                    "SELECT * FROM Win32_QuickFixEngineering");

                foreach (ManagementObject objItem in objWMIQueryCollection)
                {
                    strResults = objItem[strProperty].ToString();
                }

                return strResults;
            }
        }
    }
}
