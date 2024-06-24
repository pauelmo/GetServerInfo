using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace _sys
{
    public partial class _WMI
    {
        public class Product
        {
            public static string GetInstalledSoftwareList(
                string strMachineName)
            {
                string strResults = null;

                string strHeader = "-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+";
                string strCaption = null;
                string strDescription = null;
                string strIdentifyingNumber = null;
                string strInstallLocation = null;
                //string strInstallState = null;
                string strName = null;
                string strPackageCache = null;
                string strVendor = null;
                string strVersion = null;

                if (String.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = _sys._WMI.ComputerSystem.GetLocalMachineName();
                }

                ManagementObjectSearcher objWMISearcher = new ManagementObjectSearcher(
                    @"\\" +
                    strMachineName +
                    "\\root\\cimv2",
                    "SELECT * FROM Win32_Product");

                objWMISearcher.Scope.Options.EnablePrivileges = true;
                objWMISearcher.Scope.Options.Impersonation = ImpersonationLevel.Impersonate;
                objWMISearcher.Scope.Options.Authentication = AuthenticationLevel.PacketPrivacy;

                try
                {

                    foreach (ManagementObject objItem in objWMISearcher.Get())
                    {

                        strCaption = Convert.ToString(objItem["Caption"]);
                        strDescription = Convert.ToString(objItem["Description"]);
                        strIdentifyingNumber = Convert.ToString(objItem["IdentifyingNumber"]);
                        strInstallLocation = Convert.ToString(objItem["InstallLocation"]);
                        strName = Convert.ToString(objItem["Name"]);
                        strPackageCache = Convert.ToString(objItem["PackageCache"]);
                        strVendor = Convert.ToString(objItem["Vendor"]);
                        strVersion = Convert.ToString(objItem["Version"]);


                        if (strResults == null | strResults == "")
                        {

                            strResults = strHeader + "\r\n" +
                                         "Application:  " + strDescription + "\r\n" +
                                         strHeader + "\r\n" +
                                         "Identifying Number:  " + strIdentifyingNumber + "\r\n" +
                                         "Installation Location:  " + strInstallLocation + "\r\n" +
                                         "Name:  " + strName + "\r\n" +
                                         "Package Cache:  " + strPackageCache + "\r\n" +
                                         "Vendor:  " + strVendor + "\r\n" +
                                         "Version:  " + strVersion + "\r\n" +
                                         "\r\n" + "\r\n";
                        }
                        else
                        {
                            strResults = strResults +
                                         strHeader + "\r\n" +
                                         "Application:  " + strDescription + "\r\n" +
                                         strHeader + "\r\n" +
                                         "Identifying Number:  " + strIdentifyingNumber + "\r\n" +
                                         "Installation Location:  " + strInstallLocation + "\r\n" +
                                         "Name:  " + strName + "\r\n" +
                                         "Package Cache:  " + strPackageCache + "\r\n" +
                                         "Vendor:  " + strVendor + "\r\n" +
                                         "Version:  " + strVersion + "\r\n" +
                                         "\r\n" + "\r\n";
                        }
                    }
                }
                catch (Exception e)
                {
                    strResults = "ERROR:" + "\r\n" +
                        "There was a problem attempting to retrieve software inventory " +
                        "list from the specified machine.  Please make sure the machine name " +
                        "is correct, the machine is powered on, and you have permissions to access " +
                        "the machine, then try running your query again." + "\r\n" + "\r\n" +
                        "ERROR DETAILS:  " + "\r\n" +
                        "==============" + "\r\n" +
                        "Error Message:" + "\r\n" +
                        e.Message + "\r\n" + "\r\n" +
                        "Error Source:" + "\r\n" +
                        e.Source + "\r\n" + "\r\n" +
                        "Stack Trace:" + "\r\n" +
                        e.StackTrace;


                }



                return strResults;
            }
        }
    }
}
