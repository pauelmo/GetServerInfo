using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace GetServerInfo
{
    public partial class _WMI
    {

        public class OperatingSystem
        {

            public static string GetSerialNumber(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_ComputerSystem(
                    strMachineName,
                    "SerialNumber");

                return strResults;
            }


            public static string GetOSVersion(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_ComputerSystem(
                    strMachineName,
                    "Caption");

                return strResults;
            }


            public static string GetOSArchitecture(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_ComputerSystem(
                    strMachineName,
                    "OSArchitecture");

                return strResults;
            }


            public static string GetOSSubVersion(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_ComputerSystem(
                    strMachineName,
                    "CSDVersion");

                return strResults;
            }


            public static string GetOSBuildNumber(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_ComputerSystem(
                    strMachineName,
                    "BuildNumber");

                return strResults;
            }


            public static string GetOSInstallDate(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_ComputerSystem(
                    strMachineName,
                    "InstallDate");

                strResults = _WMI.ConvertWMIDateString(strResults);

                return strResults;
            }


            public static string GetLastReboot(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_ComputerSystem(
                    strMachineName,
                    "LastBootUpTime");

                strResults = _WMI.ConvertWMIDateString(strResults);

                return strResults;
            }




            private static string _Win32_ComputerSystem(
                string strMachineName,
                string strProperty)
            {
                string strResults = null;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectCollection objWMIQueryCollection = 
                        _WMI.GetWMIQueryCollection(
                        strMachineName,
                        "\\root\\cimv2",
                        "SELECT * FROM Win32_OperatingSystem");

                try
                {
                    foreach (ManagementObject objItem in objWMIQueryCollection)
                    {
                        strResults = Convert.ToString(objItem[strProperty]);
                    }

                    if (strResults == string.Empty)
                    {
                        strResults = "(None)";
                    }
                }
                catch
                {

                }

                return strResults;
            }



        }
    }
}
