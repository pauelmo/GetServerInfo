using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;


namespace _sys
{

    public partial class _WMI
    {
        public class NetworkAdapterConfiguration
        {
            public static _WMI.MachineObject GetMACAddreses(
                _WMI.MachineObject machineObject)
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
                            "SELECT * FROM Win32_NetworkAdapterConfiguration");

                    foreach (ManagementObject objItem in objWMIQueryCollection)
                    {
                        if (objItem["MACAddress"] != null)
                        {
                            machineObject.MACAddresses.Add(objItem["MACAddress"].ToString());
                        }
                    }

                }
                catch (Exception e)
                {
                    machineObject.GetLastError = e.Message;
                }

                return machineObject;

            }

        }

    }
    
}
