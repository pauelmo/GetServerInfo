using System;
using _sys;
using Microsoft.Win32;

namespace SYS_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string results = string.Empty;
            
            _WMI.MachineObject machineObject = new _WMI.MachineObject();

            machineObject.MachineName = _WMI.ComputerSystem.GetLocalMachineName();
            results = _WMI.GetServerInfo(results);
            Console.WriteLine("The name of the machine is:  " + machineObject.MachineName);
            Console.ReadLine();

            machineObject = _WMI.NetworkAdapterConfiguration.GetMACAddreses(machineObject);

            /*
            string sMACAddress = machineObject.MACAddresses;

            foreach (string sMACAddress in tempList)
            {
                results = "MAC Address: " + sMACAddress;
                results = results + Environment.NewLine;
            }
            */

            Console.WriteLine(results);
            Console.ReadLine();
            Console.WriteLine("DONE!...");
            Console.ReadLine();




            machineObject = _WMI.LogicalDisk.GetDetailedHardDriveInfo(machineObject);

            foreach (_WMI.HardDrive tempHardDrive in machineObject.HardDrive)
            {
                results =
                    "Drive: " + tempHardDrive.Drive +
                    Environment.NewLine +
                    "Volume: " + tempHardDrive.VolumeName +
                    Environment.NewLine +
                    "File System: " + tempHardDrive.FileSystem +
                    Environment.NewLine +
                    "Size: " + Convert.ToString(tempHardDrive.DiskSize) +
                    Environment.NewLine +
                    "Used Space: " + Convert.ToString(tempHardDrive.DiskSpaceUsed) +
                    Environment.NewLine +
                    "Free Space: " + Convert.ToString(tempHardDrive.DiskSpaceFree) +
                    Environment.NewLine +
                    "Serial: " + tempHardDrive.SerialNumber +
                    Environment.NewLine + Environment.NewLine;

                results = results + results;
            }

            results =
                "----------------------------------------" +
                Environment.NewLine +
                "Hard Drive Information Example: " +
                Environment.NewLine +
                results +
                Environment.NewLine +
                "----------------------------------------" +
                Environment.NewLine +
                Environment.NewLine;

            Console.WriteLine(results);
            Console.ReadLine();
            Console.WriteLine("DONE!...");
            Console.ReadLine();



            /*
            string sInstalledSoftware =
                //_WMI.Product.GetInstalledSoftwareList("Vquiroz-SSD");
                _WMI.Product.GetInstalledSoftwareList("pelmore");

            Console.WriteLine(sInstalledSoftware);
            Console.WriteLine("Installed software search completed...");
            Console.ReadLine();
            */


            string sResults = string.Empty;
            string sDisplayName = string.Empty;
            string sDisplayVersion = string.Empty;
            string sInstallDate = string.Empty;
            DateTime dtInstallDate = DateTime.Now;
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {

                        sDisplayName = Convert.ToString(subkey.GetValue("DisplayName"));
                        

                        if (sDisplayName != string.Empty | sDisplayName != string.Empty)
                        {
                            sDisplayVersion = Convert.ToString(subkey.GetValue("DisplayVersion"));
                            sInstallDate = Convert.ToString(subkey.GetValue("InstallDate"));
                            //sInstallDate = dtInstallDate.ToString("dd/MM/yyyy");

                            try
                            {
                                dtInstallDate = Convert.ToDateTime(sInstallDate);
                                sInstallDate = dtInstallDate.ToString("MM/dd/yyyy");
                            }
                            catch
                            {

                            }

                            sResults = 
                                sDisplayName + " | " +
                                sInstallDate + " | " +
                                //sInstallDate + " | " + //Convert.ToString(dtInstallDate) + " | " +
                                sDisplayVersion;
                            Console.WriteLine(sResults);
                        }
                        
                        

                    }
                }
            }


            Console.WriteLine("Done!...");
            Console.ReadLine();

        }
    }
}
