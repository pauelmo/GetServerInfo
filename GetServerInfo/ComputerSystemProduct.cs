using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace GetServerInfo
{
    public partial class _WMI
    {
        public class ComputerSystemProduct
        {

            public static string GetMachineModel(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_ComputerSystemProduct(
                    strMachineName,
                    "Name");

                return strResults;
            }

            public static string GetUUID(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_ComputerSystemProduct(
                    strMachineName,
                    "UUID");

                return strResults;
            }



            public static string GetManufacturer(
                string strMachineName)
            {

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                }

                string strResults = _Win32_ComputerSystemProduct(
                    strMachineName,
                    "Vendor");

                return strResults;
            }



            private static string _Win32_ComputerSystemProduct(
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
                    "SELECT * FROM Win32_ComputerSystemProduct");


                try
                {
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
