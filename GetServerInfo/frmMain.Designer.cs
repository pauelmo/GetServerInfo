namespace GetServerInfo
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxMachineInformation = new System.Windows.Forms.GroupBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.lblUUID = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.groupBoxCPUAndMemory = new System.Windows.Forms.GroupBox();
            this.lblDetailedMemory = new System.Windows.Forms.Label();
            this.txtDetailedMemory = new System.Windows.Forms.TextBox();
            this.txtMaxRAMCapacity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRAMInstalled = new System.Windows.Forms.TextBox();
            this.lblRAMIntalled = new System.Windows.Forms.Label();
            this.txtProcessorCores = new System.Windows.Forms.TextBox();
            this.lblProcessorCores = new System.Windows.Forms.Label();
            this.txtProcessor = new System.Windows.Forms.TextBox();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.groupBoxOperatingSystem = new System.Windows.Forms.GroupBox();
            this.txtOSArchitecture = new System.Windows.Forms.TextBox();
            this.lblOSArchitecture = new System.Windows.Forms.Label();
            this.txtLastReboot = new System.Windows.Forms.TextBox();
            this.lbLastReboot = new System.Windows.Forms.Label();
            this.txtOSInstallationDate = new System.Windows.Forms.TextBox();
            this.lblOSInstallationDate = new System.Windows.Forms.Label();
            this.txtBuildNumber = new System.Windows.Forms.TextBox();
            this.lblBuildNumber = new System.Windows.Forms.Label();
            this.txtOSSubVersion = new System.Windows.Forms.TextBox();
            this.lblOSSubVersion = new System.Windows.Forms.Label();
            this.txtOSVersion = new System.Windows.Forms.TextBox();
            this.lblOSVersion = new System.Windows.Forms.Label();
            this.groupBoxStorage = new System.Windows.Forms.GroupBox();
            this.lblHardDriveInformation = new System.Windows.Forms.Label();
            this.txtHardDriveInformation = new System.Windows.Forms.TextBox();
            this.groupBoxWindowsUpdates = new System.Windows.Forms.GroupBox();
            this.txtHotFixInformation = new System.Windows.Forms.TextBox();
            this.lblHotFixesInstalled = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblGetServerInfo = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxMachineInformation.SuspendLayout();
            this.groupBoxCPUAndMemory.SuspendLayout();
            this.groupBoxOperatingSystem.SuspendLayout();
            this.groupBoxStorage.SuspendLayout();
            this.groupBoxWindowsUpdates.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnGetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGetInfo.Location = new System.Drawing.Point(382, 446);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetInfo.TabIndex = 1;
            this.btnGetInfo.Text = "Get Info";
            this.btnGetInfo.UseVisualStyleBackColor = false;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(476, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = " ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxMachineInformation
            // 
            this.groupBoxMachineInformation.Controls.Add(this.txtSerialNumber);
            this.groupBoxMachineInformation.Controls.Add(this.lblSerialNumber);
            this.groupBoxMachineInformation.Controls.Add(this.txtUUID);
            this.groupBoxMachineInformation.Controls.Add(this.lblUUID);
            this.groupBoxMachineInformation.Controls.Add(this.txtManufacturer);
            this.groupBoxMachineInformation.Controls.Add(this.lblManufacturer);
            this.groupBoxMachineInformation.Controls.Add(this.txtModel);
            this.groupBoxMachineInformation.Controls.Add(this.lblModel);
            this.groupBoxMachineInformation.Controls.Add(this.txtMachineName);
            this.groupBoxMachineInformation.Controls.Add(this.lblMachineName);
            this.groupBoxMachineInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMachineInformation.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxMachineInformation.Location = new System.Drawing.Point(22, 28);
            this.groupBoxMachineInformation.Name = "groupBoxMachineInformation";
            this.groupBoxMachineInformation.Size = new System.Drawing.Size(442, 148);
            this.groupBoxMachineInformation.TabIndex = 38;
            this.groupBoxMachineInformation.TabStop = false;
            this.groupBoxMachineInformation.Text = "Machine Information";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.Color.Black;
            this.txtSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerialNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSerialNumber.Location = new System.Drawing.Point(92, 119);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.ReadOnly = true;
            this.txtSerialNumber.Size = new System.Drawing.Size(344, 15);
            this.txtSerialNumber.TabIndex = 21;
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumber.Location = new System.Drawing.Point(11, 119);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(82, 13);
            this.lblSerialNumber.TabIndex = 20;
            this.lblSerialNumber.Text = "Serial Number:";
            // 
            // txtUUID
            // 
            this.txtUUID.BackColor = System.Drawing.Color.Black;
            this.txtUUID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUUID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtUUID.Location = new System.Drawing.Point(92, 93);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.ReadOnly = true;
            this.txtUUID.Size = new System.Drawing.Size(344, 15);
            this.txtUUID.TabIndex = 19;
            // 
            // lblUUID
            // 
            this.lblUUID.AutoSize = true;
            this.lblUUID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUUID.Location = new System.Drawing.Point(56, 93);
            this.lblUUID.Name = "lblUUID";
            this.lblUUID.Size = new System.Drawing.Size(37, 13);
            this.lblUUID.TabIndex = 18;
            this.lblUUID.Text = "UUID:";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.BackColor = System.Drawing.Color.Black;
            this.txtManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtManufacturer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtManufacturer.Location = new System.Drawing.Point(92, 67);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(344, 15);
            this.txtManufacturer.TabIndex = 17;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturer.Location = new System.Drawing.Point(13, 67);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(80, 13);
            this.lblManufacturer.TabIndex = 16;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.Black;
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtModel.Location = new System.Drawing.Point(92, 43);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(344, 15);
            this.txtModel.TabIndex = 15;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(50, 43);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(43, 13);
            this.lblModel.TabIndex = 14;
            this.lblModel.Text = "Model:";
            // 
            // txtMachineName
            // 
            this.txtMachineName.BackColor = System.Drawing.Color.Black;
            this.txtMachineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMachineName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtMachineName.Location = new System.Drawing.Point(92, 16);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Size = new System.Drawing.Size(344, 22);
            this.txtMachineName.TabIndex = 13;
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineName.Location = new System.Drawing.Point(7, 16);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(86, 13);
            this.lblMachineName.TabIndex = 12;
            this.lblMachineName.Text = "Machine Name:";
            // 
            // groupBoxCPUAndMemory
            // 
            this.groupBoxCPUAndMemory.Controls.Add(this.lblDetailedMemory);
            this.groupBoxCPUAndMemory.Controls.Add(this.txtDetailedMemory);
            this.groupBoxCPUAndMemory.Controls.Add(this.txtMaxRAMCapacity);
            this.groupBoxCPUAndMemory.Controls.Add(this.label1);
            this.groupBoxCPUAndMemory.Controls.Add(this.txtRAMInstalled);
            this.groupBoxCPUAndMemory.Controls.Add(this.lblRAMIntalled);
            this.groupBoxCPUAndMemory.Controls.Add(this.txtProcessorCores);
            this.groupBoxCPUAndMemory.Controls.Add(this.lblProcessorCores);
            this.groupBoxCPUAndMemory.Controls.Add(this.txtProcessor);
            this.groupBoxCPUAndMemory.Controls.Add(this.lblProcessor);
            this.groupBoxCPUAndMemory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCPUAndMemory.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxCPUAndMemory.Location = new System.Drawing.Point(22, 182);
            this.groupBoxCPUAndMemory.Name = "groupBoxCPUAndMemory";
            this.groupBoxCPUAndMemory.Size = new System.Drawing.Size(883, 150);
            this.groupBoxCPUAndMemory.TabIndex = 39;
            this.groupBoxCPUAndMemory.TabStop = false;
            this.groupBoxCPUAndMemory.Text = "CPU and Memory";
            // 
            // lblDetailedMemory
            // 
            this.lblDetailedMemory.AutoSize = true;
            this.lblDetailedMemory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailedMemory.Location = new System.Drawing.Point(7, 44);
            this.lblDetailedMemory.Name = "lblDetailedMemory";
            this.lblDetailedMemory.Size = new System.Drawing.Size(89, 13);
            this.lblDetailedMemory.TabIndex = 27;
            this.lblDetailedMemory.Text = "Memory Details:";
            // 
            // txtDetailedMemory
            // 
            this.txtDetailedMemory.BackColor = System.Drawing.Color.Black;
            this.txtDetailedMemory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetailedMemory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetailedMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDetailedMemory.Location = new System.Drawing.Point(6, 59);
            this.txtDetailedMemory.Multiline = true;
            this.txtDetailedMemory.Name = "txtDetailedMemory";
            this.txtDetailedMemory.ReadOnly = true;
            this.txtDetailedMemory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDetailedMemory.Size = new System.Drawing.Size(871, 82);
            this.txtDetailedMemory.TabIndex = 26;
            // 
            // txtMaxRAMCapacity
            // 
            this.txtMaxRAMCapacity.BackColor = System.Drawing.Color.Black;
            this.txtMaxRAMCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaxRAMCapacity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxRAMCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtMaxRAMCapacity.Location = new System.Drawing.Point(804, 22);
            this.txtMaxRAMCapacity.Name = "txtMaxRAMCapacity";
            this.txtMaxRAMCapacity.ReadOnly = true;
            this.txtMaxRAMCapacity.Size = new System.Drawing.Size(73, 15);
            this.txtMaxRAMCapacity.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(699, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Max RAM Capacity:";
            // 
            // txtRAMInstalled
            // 
            this.txtRAMInstalled.BackColor = System.Drawing.Color.Black;
            this.txtRAMInstalled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRAMInstalled.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRAMInstalled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtRAMInstalled.Location = new System.Drawing.Point(656, 22);
            this.txtRAMInstalled.Name = "txtRAMInstalled";
            this.txtRAMInstalled.ReadOnly = true;
            this.txtRAMInstalled.Size = new System.Drawing.Size(45, 15);
            this.txtRAMInstalled.TabIndex = 23;
            // 
            // lblRAMIntalled
            // 
            this.lblRAMIntalled.AutoSize = true;
            this.lblRAMIntalled.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAMIntalled.Location = new System.Drawing.Point(576, 22);
            this.lblRAMIntalled.Name = "lblRAMIntalled";
            this.lblRAMIntalled.Size = new System.Drawing.Size(81, 13);
            this.lblRAMIntalled.TabIndex = 22;
            this.lblRAMIntalled.Text = "RAM Installed:";
            // 
            // txtProcessorCores
            // 
            this.txtProcessorCores.BackColor = System.Drawing.Color.Black;
            this.txtProcessorCores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProcessorCores.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessorCores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtProcessorCores.Location = new System.Drawing.Point(539, 22);
            this.txtProcessorCores.Name = "txtProcessorCores";
            this.txtProcessorCores.ReadOnly = true;
            this.txtProcessorCores.Size = new System.Drawing.Size(31, 15);
            this.txtProcessorCores.TabIndex = 19;
            // 
            // lblProcessorCores
            // 
            this.lblProcessorCores.AutoSize = true;
            this.lblProcessorCores.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessorCores.Location = new System.Drawing.Point(449, 22);
            this.lblProcessorCores.Name = "lblProcessorCores";
            this.lblProcessorCores.Size = new System.Drawing.Size(91, 13);
            this.lblProcessorCores.TabIndex = 18;
            this.lblProcessorCores.Text = "Processor Cores:";
            // 
            // txtProcessor
            // 
            this.txtProcessor.BackColor = System.Drawing.Color.Black;
            this.txtProcessor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProcessor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtProcessor.Location = new System.Drawing.Point(96, 22);
            this.txtProcessor.Name = "txtProcessor";
            this.txtProcessor.ReadOnly = true;
            this.txtProcessor.Size = new System.Drawing.Size(285, 15);
            this.txtProcessor.TabIndex = 17;
            // 
            // lblProcessor
            // 
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessor.Location = new System.Drawing.Point(37, 22);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(59, 13);
            this.lblProcessor.TabIndex = 16;
            this.lblProcessor.Text = "Processor:";
            // 
            // groupBoxOperatingSystem
            // 
            this.groupBoxOperatingSystem.Controls.Add(this.txtOSArchitecture);
            this.groupBoxOperatingSystem.Controls.Add(this.lblOSArchitecture);
            this.groupBoxOperatingSystem.Controls.Add(this.txtLastReboot);
            this.groupBoxOperatingSystem.Controls.Add(this.lbLastReboot);
            this.groupBoxOperatingSystem.Controls.Add(this.txtOSInstallationDate);
            this.groupBoxOperatingSystem.Controls.Add(this.lblOSInstallationDate);
            this.groupBoxOperatingSystem.Controls.Add(this.txtBuildNumber);
            this.groupBoxOperatingSystem.Controls.Add(this.lblBuildNumber);
            this.groupBoxOperatingSystem.Controls.Add(this.txtOSSubVersion);
            this.groupBoxOperatingSystem.Controls.Add(this.lblOSSubVersion);
            this.groupBoxOperatingSystem.Controls.Add(this.txtOSVersion);
            this.groupBoxOperatingSystem.Controls.Add(this.lblOSVersion);
            this.groupBoxOperatingSystem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOperatingSystem.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxOperatingSystem.Location = new System.Drawing.Point(470, 28);
            this.groupBoxOperatingSystem.Name = "groupBoxOperatingSystem";
            this.groupBoxOperatingSystem.Size = new System.Drawing.Size(435, 148);
            this.groupBoxOperatingSystem.TabIndex = 41;
            this.groupBoxOperatingSystem.TabStop = false;
            this.groupBoxOperatingSystem.Text = "Operating System";
            // 
            // txtOSArchitecture
            // 
            this.txtOSArchitecture.BackColor = System.Drawing.Color.Black;
            this.txtOSArchitecture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOSArchitecture.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSArchitecture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtOSArchitecture.Location = new System.Drawing.Point(119, 67);
            this.txtOSArchitecture.Name = "txtOSArchitecture";
            this.txtOSArchitecture.ReadOnly = true;
            this.txtOSArchitecture.Size = new System.Drawing.Size(72, 15);
            this.txtOSArchitecture.TabIndex = 49;
            // 
            // lblOSArchitecture
            // 
            this.lblOSArchitecture.AutoSize = true;
            this.lblOSArchitecture.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSArchitecture.Location = new System.Drawing.Point(28, 67);
            this.lblOSArchitecture.Name = "lblOSArchitecture";
            this.lblOSArchitecture.Size = new System.Drawing.Size(90, 13);
            this.lblOSArchitecture.TabIndex = 48;
            this.lblOSArchitecture.Text = "OS Architecture:";
            // 
            // txtLastReboot
            // 
            this.txtLastReboot.BackColor = System.Drawing.Color.Black;
            this.txtLastReboot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastReboot.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastReboot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtLastReboot.Location = new System.Drawing.Point(119, 118);
            this.txtLastReboot.Name = "txtLastReboot";
            this.txtLastReboot.ReadOnly = true;
            this.txtLastReboot.Size = new System.Drawing.Size(310, 15);
            this.txtLastReboot.TabIndex = 47;
            // 
            // lbLastReboot
            // 
            this.lbLastReboot.AutoSize = true;
            this.lbLastReboot.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastReboot.Location = new System.Drawing.Point(48, 118);
            this.lbLastReboot.Name = "lbLastReboot";
            this.lbLastReboot.Size = new System.Drawing.Size(71, 13);
            this.lbLastReboot.TabIndex = 46;
            this.lbLastReboot.Text = "Last Reboot:";
            // 
            // txtOSInstallationDate
            // 
            this.txtOSInstallationDate.BackColor = System.Drawing.Color.Black;
            this.txtOSInstallationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOSInstallationDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSInstallationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtOSInstallationDate.Location = new System.Drawing.Point(119, 93);
            this.txtOSInstallationDate.Name = "txtOSInstallationDate";
            this.txtOSInstallationDate.ReadOnly = true;
            this.txtOSInstallationDate.Size = new System.Drawing.Size(310, 15);
            this.txtOSInstallationDate.TabIndex = 45;
            // 
            // lblOSInstallationDate
            // 
            this.lblOSInstallationDate.AutoSize = true;
            this.lblOSInstallationDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSInstallationDate.Location = new System.Drawing.Point(6, 93);
            this.lblOSInstallationDate.Name = "lblOSInstallationDate";
            this.lblOSInstallationDate.Size = new System.Drawing.Size(113, 13);
            this.lblOSInstallationDate.TabIndex = 44;
            this.lblOSInstallationDate.Text = "OS Installation Date:";
            // 
            // txtBuildNumber
            // 
            this.txtBuildNumber.BackColor = System.Drawing.Color.Black;
            this.txtBuildNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuildNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBuildNumber.Location = new System.Drawing.Point(272, 67);
            this.txtBuildNumber.Name = "txtBuildNumber";
            this.txtBuildNumber.ReadOnly = true;
            this.txtBuildNumber.Size = new System.Drawing.Size(157, 15);
            this.txtBuildNumber.TabIndex = 43;
            // 
            // lblBuildNumber
            // 
            this.lblBuildNumber.AutoSize = true;
            this.lblBuildNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildNumber.Location = new System.Drawing.Point(189, 67);
            this.lblBuildNumber.Name = "lblBuildNumber";
            this.lblBuildNumber.Size = new System.Drawing.Size(81, 13);
            this.lblBuildNumber.TabIndex = 42;
            this.lblBuildNumber.Text = "Build Number:";
            // 
            // txtOSSubVersion
            // 
            this.txtOSSubVersion.BackColor = System.Drawing.Color.Black;
            this.txtOSSubVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOSSubVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSSubVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtOSSubVersion.Location = new System.Drawing.Point(119, 43);
            this.txtOSSubVersion.Name = "txtOSSubVersion";
            this.txtOSSubVersion.ReadOnly = true;
            this.txtOSSubVersion.Size = new System.Drawing.Size(310, 15);
            this.txtOSSubVersion.TabIndex = 41;
            // 
            // lblOSSubVersion
            // 
            this.lblOSSubVersion.AutoSize = true;
            this.lblOSSubVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSSubVersion.Location = new System.Drawing.Point(28, 43);
            this.lblOSSubVersion.Name = "lblOSSubVersion";
            this.lblOSSubVersion.Size = new System.Drawing.Size(90, 13);
            this.lblOSSubVersion.TabIndex = 40;
            this.lblOSSubVersion.Text = "OS Sub-Version:";
            // 
            // txtOSVersion
            // 
            this.txtOSVersion.BackColor = System.Drawing.Color.Black;
            this.txtOSVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOSVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtOSVersion.Location = new System.Drawing.Point(119, 18);
            this.txtOSVersion.Name = "txtOSVersion";
            this.txtOSVersion.ReadOnly = true;
            this.txtOSVersion.Size = new System.Drawing.Size(310, 15);
            this.txtOSVersion.TabIndex = 39;
            // 
            // lblOSVersion
            // 
            this.lblOSVersion.AutoSize = true;
            this.lblOSVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSVersion.Location = new System.Drawing.Point(54, 18);
            this.lblOSVersion.Name = "lblOSVersion";
            this.lblOSVersion.Size = new System.Drawing.Size(66, 13);
            this.lblOSVersion.TabIndex = 38;
            this.lblOSVersion.Text = "OS Version:";
            // 
            // groupBoxStorage
            // 
            this.groupBoxStorage.Controls.Add(this.lblHardDriveInformation);
            this.groupBoxStorage.Controls.Add(this.txtHardDriveInformation);
            this.groupBoxStorage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStorage.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBoxStorage.Location = new System.Drawing.Point(22, 338);
            this.groupBoxStorage.Name = "groupBoxStorage";
            this.groupBoxStorage.Size = new System.Drawing.Size(442, 103);
            this.groupBoxStorage.TabIndex = 42;
            this.groupBoxStorage.TabStop = false;
            this.groupBoxStorage.Text = "Storage";
            // 
            // lblHardDriveInformation
            // 
            this.lblHardDriveInformation.AutoSize = true;
            this.lblHardDriveInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardDriveInformation.Location = new System.Drawing.Point(6, 16);
            this.lblHardDriveInformation.Name = "lblHardDriveInformation";
            this.lblHardDriveInformation.Size = new System.Drawing.Size(128, 13);
            this.lblHardDriveInformation.TabIndex = 35;
            this.lblHardDriveInformation.Text = "Hard Drive Information:";
            // 
            // txtHardDriveInformation
            // 
            this.txtHardDriveInformation.BackColor = System.Drawing.Color.Black;
            this.txtHardDriveInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHardDriveInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHardDriveInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtHardDriveInformation.Location = new System.Drawing.Point(6, 32);
            this.txtHardDriveInformation.Multiline = true;
            this.txtHardDriveInformation.Name = "txtHardDriveInformation";
            this.txtHardDriveInformation.ReadOnly = true;
            this.txtHardDriveInformation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHardDriveInformation.Size = new System.Drawing.Size(430, 64);
            this.txtHardDriveInformation.TabIndex = 34;
            // 
            // groupBoxWindowsUpdates
            // 
            this.groupBoxWindowsUpdates.Controls.Add(this.txtHotFixInformation);
            this.groupBoxWindowsUpdates.Controls.Add(this.lblHotFixesInstalled);
            this.groupBoxWindowsUpdates.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWindowsUpdates.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxWindowsUpdates.Location = new System.Drawing.Point(469, 338);
            this.groupBoxWindowsUpdates.Name = "groupBoxWindowsUpdates";
            this.groupBoxWindowsUpdates.Size = new System.Drawing.Size(436, 103);
            this.groupBoxWindowsUpdates.TabIndex = 43;
            this.groupBoxWindowsUpdates.TabStop = false;
            this.groupBoxWindowsUpdates.Text = "Windows Updates";
            // 
            // txtHotFixInformation
            // 
            this.txtHotFixInformation.BackColor = System.Drawing.Color.Black;
            this.txtHotFixInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHotFixInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotFixInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtHotFixInformation.Location = new System.Drawing.Point(9, 30);
            this.txtHotFixInformation.Multiline = true;
            this.txtHotFixInformation.Name = "txtHotFixInformation";
            this.txtHotFixInformation.ReadOnly = true;
            this.txtHotFixInformation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHotFixInformation.Size = new System.Drawing.Size(421, 66);
            this.txtHotFixInformation.TabIndex = 37;
            // 
            // lblHotFixesInstalled
            // 
            this.lblHotFixesInstalled.AutoSize = true;
            this.lblHotFixesInstalled.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotFixesInstalled.Location = new System.Drawing.Point(6, 16);
            this.lblHotFixesInstalled.Name = "lblHotFixesInstalled";
            this.lblHotFixesInstalled.Size = new System.Drawing.Size(104, 13);
            this.lblHotFixesInstalled.TabIndex = 36;
            this.lblHotFixesInstalled.Text = "Hot Fixes Installed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(19, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Black;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtStatus.Location = new System.Drawing.Point(60, 451);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(257, 15);
            this.txtStatus.TabIndex = 45;
            // 
            // lblGetServerInfo
            // 
            this.lblGetServerInfo.AutoSize = true;
            this.lblGetServerInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetServerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblGetServerInfo.Location = new System.Drawing.Point(6, 4);
            this.lblGetServerInfo.Name = "lblGetServerInfo";
            this.lblGetServerInfo.Size = new System.Drawing.Size(101, 17);
            this.lblGetServerInfo.TabIndex = 46;
            this.lblGetServerInfo.Text = "Get Server Info";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMinimize.Location = new System.Drawing.Point(875, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 23);
            this.btnMinimize.TabIndex = 47;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(827, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "About";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(917, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblGetServerInfo);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxWindowsUpdates);
            this.Controls.Add(this.groupBoxStorage);
            this.Controls.Add(this.groupBoxOperatingSystem);
            this.Controls.Add(this.groupBoxCPUAndMemory);
            this.Controls.Add(this.groupBoxMachineInformation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Server Info";
            this.Load += new System.EventHandler(this.v_Load);
            this.groupBoxMachineInformation.ResumeLayout(false);
            this.groupBoxMachineInformation.PerformLayout();
            this.groupBoxCPUAndMemory.ResumeLayout(false);
            this.groupBoxCPUAndMemory.PerformLayout();
            this.groupBoxOperatingSystem.ResumeLayout(false);
            this.groupBoxOperatingSystem.PerformLayout();
            this.groupBoxStorage.ResumeLayout(false);
            this.groupBoxStorage.PerformLayout();
            this.groupBoxWindowsUpdates.ResumeLayout(false);
            this.groupBoxWindowsUpdates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxMachineInformation;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.Label lblUUID;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.GroupBox groupBoxCPUAndMemory;
        private System.Windows.Forms.TextBox txtProcessorCores;
        private System.Windows.Forms.Label lblProcessorCores;
        private System.Windows.Forms.TextBox txtProcessor;
        private System.Windows.Forms.Label lblProcessor;
        private System.Windows.Forms.GroupBox groupBoxOperatingSystem;
        private System.Windows.Forms.TextBox txtOSArchitecture;
        private System.Windows.Forms.Label lblOSArchitecture;
        private System.Windows.Forms.TextBox txtLastReboot;
        private System.Windows.Forms.Label lbLastReboot;
        private System.Windows.Forms.TextBox txtOSInstallationDate;
        private System.Windows.Forms.Label lblOSInstallationDate;
        private System.Windows.Forms.TextBox txtBuildNumber;
        private System.Windows.Forms.Label lblBuildNumber;
        private System.Windows.Forms.TextBox txtOSSubVersion;
        private System.Windows.Forms.Label lblOSSubVersion;
        private System.Windows.Forms.TextBox txtOSVersion;
        private System.Windows.Forms.Label lblOSVersion;
        private System.Windows.Forms.GroupBox groupBoxStorage;
        private System.Windows.Forms.Label lblHardDriveInformation;
        private System.Windows.Forms.TextBox txtHardDriveInformation;
        private System.Windows.Forms.GroupBox groupBoxWindowsUpdates;
        private System.Windows.Forms.TextBox txtHotFixInformation;
        private System.Windows.Forms.Label lblHotFixesInstalled;
        private System.Windows.Forms.Label lblDetailedMemory;
        private System.Windows.Forms.TextBox txtDetailedMemory;
        private System.Windows.Forms.TextBox txtMaxRAMCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRAMInstalled;
        private System.Windows.Forms.Label lblRAMIntalled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblGetServerInfo;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label3;
    }
}

