using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace GetServerInfo
{
    public partial class _WMI
    {

        public class Processor
        {

            public string GetCurrentClockSpeed(
                string strMachineName)
            {
                if (string.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_Processor(
                    strMachineName,
                    "CurrentClockSpeed");

                return strResults;
            }

            /*
            CurrentClockSpeed
            Description
            L2CacheSize
            L3CacheSize
            NumberOfLogicalProcessors
            ProcessorID
            Revision
            SocketDesignation
            */
           



            public static string GetProcessorCores(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_Processor(
                    strMachineName,
                    "NumberOfCores");

                return strResults;
            }


            public static string GetProcessorType(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_Processor(
                    strMachineName,
                    "Name");

                return strResults;
            }

            public string GetSocketDesignation(
                string strMachineName)
            {
                if(string.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_Processor(
                    strMachineName,
                    "SocketDesignation");

                return strResults;
            }


            // another method / example of using ManagementObjectSearcher
            /*
            public static string GetSocketDesignation(
                string strMachineName)
            {
                string ProcessorSocket = string.Empty;

                var processor = new ManagementObjectSearcher(
                    "select * from Win32_Processor").Get().
                    Cast<ManagementObject>().FirstOrDefault();

                if (processor != null)
                {
                    ProcessorSocket = (string)processor["SocketDesignation"];
                }

                return ProcessorSocket;
            }
            */

            private static string _Win32_Processor(
                string strMachineName,
                string strProperty)
            {
                string strResults = null;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                try
                {
                    ManagementObjectCollection objWMIQueryCollection = 
                        _WMI.GetWMIQueryCollection(
                            strMachineName,
                            "\\root\\cimv2",
                            "SELECT * FROM Win32_Processor");

                    foreach (ManagementObject objItem in objWMIQueryCollection)
                    {
                        strResults = objItem[strProperty].ToString();
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
