using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace _sys
{
    public partial class _WMI
    {

        public class Processor
        {

            public static string GetProcessorType(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _sys._WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_Processor(
                    strMachineName,
                    "Name");

                return strResults;
            }


            public static string GetProcessorCores(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _sys._WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_Processor(
                    strMachineName,
                    "NumberOfCores");

                return strResults;
            }




            private static string _Win32_Processor(
                string strMachineName,
                string strProperty)
            {
                string strResults = null;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _sys._WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectCollection objWMIQueryCollection = _sys._WMI.GetWMIQueryCollection(
                    strMachineName,
                    "\\root\\cimv2",
                    "SELECT * FROM Win32_Processor");

                foreach (ManagementObject objItem in objWMIQueryCollection)
                {
                    strResults = objItem[strProperty].ToString();
                }

                return strResults;
            }

        }
    }
}
