using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace BackupManagerSettings
{
    public class _Reg
    {


        public static string DoesRegistryKeyExist(
            string strMachineName,
            string strRegHive,
            string strRegPath,
            string strKeyName,
            int intRegView)
        {
            string strResults = null;
            RegistryKey RegKey = null;



            string keyName = @"HKEY_LOCAL_MACHINE\System\CurrentControlSet\services\pcmcia";
            string valueName = "Start";
            if (Registry.GetValue(keyName, valueName, "Not Exist") == "Not Exist")
            {
                //code if key Not Exist 
            }
            else
            {
                //code if key Exist 
            }






            //RegKey = GetRegKeyHandle(
            //            strMachineName,
            //            strRegHive,
            //            strRegPath,
            //            strKeyName,
            //            intRegView);



            RegKey.Close();


            return strResults;
        }


        public static string GetRegistryKeyValue(
            string strMachineName,
            string strRegPath,
            string strKeyName)
        {
            string strResults = null;



            return strResults;
        }


        private static RegistryKey GetRegKeyHandle(
            string strMachineName,
            string strRegHive,
            string strRegPath,
            string strKeyName,
            int intRegView)
        {

            RegistryKey RegKey = null;

            if (String.IsNullOrEmpty(strMachineName))
            {
                switch (strRegHive)
                {
                    case "HKEY_CLASSES_ROOT":
                        Console.WriteLine("Classes Root");

                        if (intRegView == 32)
                        {
                            RegKey = RegistryKey.OpenBaseKey(
                                                RegistryHive.ClassesRoot,
                                                RegistryView.Registry32).OpenSubKey(strRegPath);
                        }

                        if (intRegView == 64)
                        {
                            RegKey = RegistryKey.OpenBaseKey(
                                                RegistryHive.ClassesRoot,
                                                RegistryView.Registry64).OpenSubKey(strRegPath);
                        }
                        break;


                    case "HKEY_CURRENT_USER":
                        Console.WriteLine("Current User");

                        if (intRegView == 32)
                        {
                            RegKey = RegistryKey.OpenBaseKey(
                                                RegistryHive.CurrentUser,
                                                RegistryView.Registry32).OpenSubKey(strRegPath);
                        }

                        if (intRegView == 64)
                        {
                            RegKey = RegistryKey.OpenBaseKey(
                                                RegistryHive.CurrentUser,
                                                RegistryView.Registry64).OpenSubKey(strRegPath);
                        }
                        break;


                    case "HKEY_LOCAL_MACHINE":
                        Console.WriteLine("HKEY LOCAL MACHINE");

                        if (intRegView == 32)
                        {
                            RegKey = RegistryKey.OpenBaseKey(
                                                RegistryHive.LocalMachine,
                                                RegistryView.Registry32).OpenSubKey(strRegPath);
                        }

                        if (intRegView == 64)
                        {
                            RegKey = RegistryKey.OpenBaseKey(
                                                RegistryHive.LocalMachine,
                                                RegistryView.Registry64).OpenSubKey(strRegPath);
                        }
                        break;


                    case "HKEY_CURRENT_CONFIG":
                        Console.WriteLine("HKEY CURRENT CONFIG");

                        if (intRegView == 32)
                        {
                            RegKey = RegistryKey.OpenBaseKey(
                                                RegistryHive.CurrentConfig,
                                                RegistryView.Registry32).OpenSubKey(strRegPath);
                        }

                        if (intRegView == 64)
                        {
                            RegKey = RegistryKey.OpenBaseKey(
                                                RegistryHive.CurrentConfig,
                                                RegistryView.Registry64).OpenSubKey(strRegPath);
                        }
                        break;

                }



            }
            else
            {
                switch (strRegHive)
                {
                    case "HKEY_CLASSES_ROOT":
                        Console.WriteLine("Classes Root");

                        if (intRegView == 32)
                        {
                            RegKey = RegistryKey.OpenRemoteBaseKey(
                                                RegistryHive.ClassesRoot,
                                                strMachineName,
                                                RegistryView.Registry32).OpenSubKey(strRegPath);
                        }

                        if (intRegView == 64)
                        {
                            RegKey = RegistryKey.OpenRemoteBaseKey(
                                                RegistryHive.ClassesRoot,
                                                strMachineName,
                                                RegistryView.Registry64).OpenSubKey(strRegPath);
                        }
                        break;


                    case "HKEY_CURRENT_USER":
                        Console.WriteLine("Current User");

                        if (intRegView == 32)
                        {
                            RegKey = RegistryKey.OpenRemoteBaseKey(
                                                RegistryHive.CurrentUser,
                                                strMachineName,
                                                RegistryView.Registry32).OpenSubKey(strRegPath);
                        }

                        if (intRegView == 64)
                        {
                            RegKey = RegistryKey.OpenRemoteBaseKey(
                                                RegistryHive.CurrentUser,
                                                strMachineName,
                                                RegistryView.Registry64).OpenSubKey(strRegPath);
                        }
                        break;


                    case "HKEY_LOCAL_MACHINE":
                        Console.WriteLine("HKEY LOCAL MACHINE");

                        if (intRegView == 32)
                        {
                            RegKey = RegistryKey.OpenRemoteBaseKey(
                                                RegistryHive.LocalMachine,
                                                strMachineName,
                                                RegistryView.Registry32).OpenSubKey(strRegPath);
                        }

                        if (intRegView == 64)
                        {
                            RegKey = RegistryKey.OpenRemoteBaseKey(
                                                RegistryHive.LocalMachine,
                                                strMachineName,
                                                RegistryView.Registry64).OpenSubKey(strRegPath);
                        }
                        break;


                    case "HKEY_CURRENT_CONFIG":
                        Console.WriteLine("HKEY CURRENT CONFIG");

                        if (intRegView == 32)
                        {
                            RegKey = RegistryKey.OpenRemoteBaseKey(
                                                RegistryHive.CurrentConfig,
                                                strMachineName,
                                                RegistryView.Registry32).OpenSubKey(strRegPath);
                        }

                        if (intRegView == 64)
                        {
                            RegKey = RegistryKey.OpenRemoteBaseKey(
                                                RegistryHive.CurrentConfig,
                                                strMachineName,
                                                RegistryView.Registry64).OpenSubKey(strRegPath);
                        }
                        break;
                }

            }


            return RegKey;
        }

    }
}
