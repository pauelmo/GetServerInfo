using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Management.Instrumentation;

namespace _sys
{
    public partial class _WMI
    {
        public class ComputerSystem
        {

            public static string GetLocalMachineName()
            {
                string strResults = _sys._WMI.ComputerSystem._Win32_ComputerSystem(
                    null,
                    "Name");

                return strResults;

            }


            private static string _Win32_ComputerSystem(
                string strMachineName,
                string strProperty)
            {
                string strResults = null;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = ".";
                }

                ManagementObjectCollection objWMIQueryCollection = _sys._WMI.GetWMIQueryCollection(
                    strMachineName,
                    "\\root\\cimv2",
                    "SELECT * FROM Win32_ComputerSystem");

                foreach (ManagementObject objItem in objWMIQueryCollection)
                {
                    strResults = objItem[strProperty].ToString();
                }

                return strResults;
            }
        }
    }
}
