using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace _sys
{
    public partial class _WMI
    {

        public class PhysicalMemoryArray
        {

            private static string _Win32_PhysicalMemoryArray(
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
                    "SELECT * FROM Win32_PhysicalMemoryArray");

                foreach (ManagementObject objItem in objWMIQueryCollection)
                {
                    strResults = objItem[strProperty].ToString();
                }

                return strResults;
            }
        }
    }
}
