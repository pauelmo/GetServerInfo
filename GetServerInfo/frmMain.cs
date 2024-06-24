using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetServerInfo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        //moveable form with "none" on "FormBorderStyle" setting
        protected override void WndProc(ref Message m)
        {  
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);   
        }



        private void btnGetInfo_Click(object sender, EventArgs e)
        {

            txtStatus.Text = "Please wait...";
            txtStatus.Refresh();

            


            
                string sMachineName = txtMachineName.Text;
                string sResults = string.Empty;

                if (sMachineName == string.Empty)
                {
                    sMachineName = _WMI.ComputerSystem.GetLocalMachineName();
                    txtMachineName.Text = sMachineName;
                    txtMachineName.Refresh();
                }

                txtModel.Text = string.Empty;
                txtManufacturer.Text = string.Empty;
                txtUUID.Text = string.Empty;
                txtSerialNumber.Text = string.Empty;
                txtProcessor.Text = string.Empty;
                txtProcessorCores.Text = string.Empty;
                txtRAMInstalled.Text = string.Empty;
                txtMaxRAMCapacity.Text = string.Empty;
                txtDetailedMemory.Text = string.Empty;
                txtHardDriveInformation.Text = string.Empty;
                txtOSVersion.Text = string.Empty;
                txtOSSubVersion.Text = string.Empty;
                txtOSArchitecture.Text = string.Empty;
                txtBuildNumber.Text = string.Empty;
                txtOSInstallationDate.Text = string.Empty;
                txtLastReboot.Text = string.Empty;
                txtHotFixInformation.Text = string.Empty;

                txtStatus.Text = "Checking machine name (" + sMachineName + ")...";
                txtStatus.Refresh();
                sResults = _WMI.ComputerSystemProduct.GetMachineModel(sMachineName);
                txtModel.Text = sResults;
                txtModel.Refresh();

                txtStatus.Text = "Getting Manufacturer...";
                txtStatus.Refresh();
                sResults = _WMI.ComputerSystemProduct.GetManufacturer(sMachineName);
                txtManufacturer.Text = sResults;
                txtManufacturer.Refresh();

                txtStatus.Text = "Retreiving UUID...";
                txtStatus.Refresh();
                sResults = _WMI.ComputerSystemProduct.GetUUID(sMachineName);
                txtUUID.Text = sResults;
                txtUUID.Refresh();

                txtStatus.Text = "Retrieving Serial Number...";
                sResults = _WMI.OperatingSystem.GetSerialNumber(sMachineName);
                txtSerialNumber.Text = sResults;
                txtSerialNumber.Refresh();

                txtStatus.Text = "Detecting Processor Type...";
                txtStatus.Refresh();
                sResults = _WMI.Processor.GetProcessorType(sMachineName);
                txtProcessor.Text = sResults;
                txtProcessor.Refresh();

                txtStatus.Text = "Counting cores on fingers...";
                txtStatus.Refresh();
                sResults = _WMI.Processor.GetProcessorCores(sMachineName);
                txtProcessorCores.Text = sResults;
                txtProcessorCores.Refresh();

                txtStatus.Text = "Calculating total RAM installed...";
                txtStatus.Refresh();
                sResults = Convert.ToString(_WMI.PhysicalMemory.GetTotalRAMInstalled(sMachineName));
                txtRAMInstalled.Text = sResults;
                txtRAMInstalled.Refresh();

                txtStatus.Text = "Detecting maximum RAM capacity...";
                txtStatus.Refresh();
                sResults = Convert.ToString(_WMI.PhysicalMemory.GetMaxRAMCapacity(sMachineName));
                txtMaxRAMCapacity.Text = sResults;
                txtMaxRAMCapacity.Refresh();

                txtStatus.Text = "Retrieving detailed memory information...";
                txtStatus.Refresh();
                sResults = _WMI.PhysicalMemory.GetDetailedMemoryInfo(sMachineName);
                txtDetailedMemory.Text = sResults;
                txtDetailedMemory.Refresh();

                txtStatus.Text = "Obtaining detailed storage information...";
                txtStatus.Refresh();
                sResults = _WMI.LogicalDisk.GetDetailedHardDriveInfo(sMachineName);
                txtHardDriveInformation.Text = sResults;
                txtHardDriveInformation.Refresh();

                txtStatus.Text = "Detecting OS version...";
                txtStatus.Refresh();
                sResults = _WMI.OperatingSystem.GetOSVersion(sMachineName);
                txtOSVersion.Text = sResults;
                txtOSVersion.Refresh();

                txtStatus.Text = "Checking for OS Sub-version information...";
                txtStatus.Refresh();
                sResults = _WMI.OperatingSystem.GetOSSubVersion(sMachineName);
                txtOSSubVersion.Text = sResults;
                txtOSSubVersion.Refresh();

                sResults = _WMI.OperatingSystem.GetOSArchitecture(sMachineName);
                txtOSArchitecture.Text = sResults;
                txtOSArchitecture.Refresh();

                txtStatus.Text = "Retrieving build version information...";
                txtStatus.Refresh();
                sResults = _WMI.OperatingSystem.GetOSBuildNumber(sMachineName);
                txtBuildNumber.Text = sResults;
                txtBuildNumber.Refresh();

                txtStatus.Text = "Determining OS installation date...";
                txtStatus.Refresh();
                sResults = _WMI.OperatingSystem.GetOSInstallDate(sMachineName);
                txtOSInstallationDate.Text = sResults;
                txtOSInstallationDate.Refresh();

                txtStatus.Text = "Detecting the date / time of last reboot...";
                txtStatus.Refresh();
                sResults = _WMI.OperatingSystem.GetLastReboot(sMachineName);
                txtLastReboot.Text = sResults;
                txtLastReboot.Refresh();

                txtStatus.Text = "Retrieving list of Hot-fixes...";
                txtStatus.Refresh();
                sResults = _WMI.QuickFixEngineering.GetInstalledHotFixList(sMachineName);
                txtHotFixInformation.Text = sResults;
                txtHotFixInformation.Refresh();

                txtStatus.Text = "Done!";
                txtStatus.Refresh();

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void v_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string sAboutMessage =
                "Get Server Info " + Environment.NewLine +
                "Paul Elmore Copyright, © 2015";

            MessageBox.Show(sAboutMessage);
        }
    }
}
