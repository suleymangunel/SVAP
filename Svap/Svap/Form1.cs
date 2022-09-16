using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.IO;

namespace StartVM
{
    public partial class Form1 : Form
    {
        bool SvapState = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ListVMsBTN_Click(object sender, EventArgs e)
        {
            const int Unknown = 0;
            const int Enabled = 2;
            const int Disabled = 3;
            const int Paused = 32768;
            const int Suspended = 32769;
            const int Starting = 32770;
            const int Snapshotting = 32771;
            const int Saving = 32773;
            const int Stopping = 32774;
            const int Pausing = 32776;
            const int Resuming = 32777;

            ManagementScope scope = new ManagementScope(@"root\virtualization", null);
            string query = string.Format("select * from Msvm_ComputerSystem Where Caption = 'Virtual Machine'");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, new ObjectQuery(query));
            ManagementObjectCollection computers = searcher.Get();
            //ManagementObject computer = null;
            string ElementName = null;
            UInt16 uiEnabledState = 0;
            string EnabledState = null;
            string GUID = null;

            VMTV.Nodes.Clear();
            VMsChkLst.Items.Clear();

            foreach (ManagementObject instance in computers)
            {
                ElementName = instance.GetPropertyValue("ElementName").ToString();
                uiEnabledState = (UInt16)instance.GetPropertyValue("EnabledState");
                GUID = instance.GetPropertyValue("Name").ToString();
                switch (uiEnabledState)
                {
                    case Unknown:
                        EnabledState = "Unknown";
                        break;
                    case Enabled:
                        EnabledState = "Enabled";
                        break;
                    case Disabled:
                        EnabledState = "Disabled";
                        break;
                    case Paused:
                        EnabledState = "Paused";
                        break;
                    case Suspended:
                        EnabledState = "Suspended";
                        break;
                    case Starting:
                        EnabledState = "Starting";
                        break;
                    case Snapshotting:
                        EnabledState = "Snapshotting";
                        break;
                    case Saving:
                        EnabledState = "Saving";
                        break;
                    case Stopping:
                        EnabledState = "Stopping";
                        break;
                    case Pausing:
                        EnabledState = "Pausing";
                        break;
                    case Resuming:
                        EnabledState = "Resuming";
                        break;
                }
                VMTV.Nodes.Add(ElementName, ElementName);
                VMTV.Nodes[ElementName].Nodes.Add("State:" + EnabledState);
                VMTV.Nodes[ElementName].Nodes.Add("GUID:" + GUID);
                VMsChkLst.Items.Add(ElementName);
            }
        }

        private void PingTextBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[32];
                int bekleme = ((int)PingDurNUD1.Value) * 1000;
                PingOptions Po = new PingOptions(128, true);
                Ping ping = new Ping();
                PingReply pingReply = ping.Send(NameTxt1.Text, bekleme, buffer, Po);

                if (!(pingReply == null))
                {
                    switch (pingReply.Status)
                    {
                        case IPStatus.Success:
                            MessageBox.Show(string.Format("Accessed {0}: bytes={1} time={2}ms TTL={3}\r\n", pingReply.Address, pingReply.Buffer.Length, pingReply.RoundtripTime, pingReply.Options.Ttl));
                            break;
                        case IPStatus.TimedOut:
                            MessageBox.Show("Request timeout.");
                            break;
                        default:
                            MessageBox.Show(string.Format("Request fault: {0}", pingReply.Status.ToString()));
                            break;
                    }
                }
                else
                    MessageBox.Show("Unknown Connection Error...");
            }
            catch (PingException ex)
            {
                MessageBox.Show(string.Format("Connection Error: {0}", ex.Message));
            }
            catch (SocketException ex)
            {
                MessageBox.Show(string.Format("Connection Error: {0}", ex.Message));
            }
        }

        private void PingTextBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[32];
                int bekleme = ((int)PingDurNUD2.Value) * 1000;
                PingOptions Po = new PingOptions(128, true);
                Ping ping = new Ping();
                PingReply pingReply = ping.Send(NameTxt2.Text, bekleme, buffer, Po);

                if (!(pingReply == null))
                {
                    switch (pingReply.Status)
                    {
                        case IPStatus.Success:
                            MessageBox.Show(string.Format("Accessed {0}: bytes={1} time={2}ms TTL={3}\r\n", pingReply.Address, pingReply.Buffer.Length, pingReply.RoundtripTime, pingReply.Options.Ttl));
                            break;
                        case IPStatus.TimedOut:
                            MessageBox.Show("Request timeout.");
                            break;
                        default:
                            MessageBox.Show(string.Format("Request fault: {0}", pingReply.Status.ToString()));
                            break;
                    }
                }
                else
                    MessageBox.Show("Unknown Connection Error...");
            }
            catch (PingException ex)
            {
                MessageBox.Show(string.Format("Connection Error: {0}", ex.Message));
            }
            catch (SocketException ex)
            {
                MessageBox.Show(string.Format("Connection Error: {0}", ex.Message));
            }
        }

        private void PingTextBtn3_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[32];
                int bekleme = ((int)PingDurNUD3.Value) * 1000;
                PingOptions Po = new PingOptions(128, true);
                Ping ping = new Ping();
                PingReply pingReply = ping.Send(NameTxt3.Text, bekleme, buffer, Po);

                if (!(pingReply == null))
                {
                    switch (pingReply.Status)
                    {
                        case IPStatus.Success:
                            MessageBox.Show(string.Format("Accessed {0}: bytes={1} time={2}ms TTL={3}\r\n", pingReply.Address, pingReply.Buffer.Length, pingReply.RoundtripTime, pingReply.Options.Ttl));
                            break;
                        case IPStatus.TimedOut:
                            MessageBox.Show("Request timeout.");

                            break;
                        default:
                            MessageBox.Show(string.Format("Request fault: {0}", pingReply.Status.ToString()));
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Unknown Connection Error...");
                }
            }
            catch (PingException ex)
            {
                MessageBox.Show(string.Format("Connection Error: {0}", ex.Message));

            }
            catch (SocketException ex)
            {
                MessageBox.Show(string.Format("Connection Error: {0}", ex.Message));
            }
        }

        private void StartServiceBtn_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)PingCycleNUD1.Value * 1000;
            timer1.Enabled = checkBox1.Checked;
            timer2.Interval = (int)PingCycleNUD2.Value * 1000;
            timer2.Enabled = checkBox2.Checked;
            timer3.Interval = (int)PingCycleNUD3.Value * 1000;
            timer3.Enabled = checkBox3.Checked;
            if (timer1.Enabled || timer2.Enabled || timer3.Enabled)
            {
                LogTxt.Text += "["+DateTime.Now.ToString() + "] - " + "Service Started" + "\r\n";
                SvapState = true;
                contextMenuStrip1.Items["StartStopCtxt"].Text = "Stop";
                notifyIcon1.Icon = Icon.FromHandle(((Bitmap)imageList1.Images["servicerunning.ico"]).GetHicon());
            }
        }

        private void StopServiceBtn_Click(object sender, EventArgs e)
        {
            LogTxt.Text += "["+DateTime.Now.ToString() + "] - " + "Service Stopped" + "\r\n";
            SvapState = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            contextMenuStrip1.Items["StartStopCtxt"].Text = "Start";
            notifyIcon1.Icon = Icon.FromHandle(((Bitmap)imageList1.Images["servicestopped.ico"]).GetHicon());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pnl1.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pnl2.Enabled = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pnl3.Enabled = checkBox3.Checked;
        }

        private void LoadCfgBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "SvapSettings.txt";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            int sayac = -1;
            string[][] JobInfo = new string[100][];

            int posIP = 0;
            int posCycle = 1;
            int posDuration = 2;
            int posRetry = 3;
            int posVM = 0;

            //IP # Cycle # VM
            string satir = " ";
            //FileStream fStream = File.Open(DosyaAdi, FileMode.Open, FileAccess.Read);
            Stream fStream = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((fStream = openFileDialog1.OpenFile()) != null)
                {
                    TextReader toku = new StreamReader(fStream, System.Text.Encoding.GetEncoding("windows-1254"));
                    satir = toku.ReadLine(); //Başlık satırını atlamak için
                    satir = toku.ReadLine();
                    sayac++;
                    JobInfo[sayac] = new string[3];
                    string[] words = satir.Split('#');
                    words.CopyTo(JobInfo[sayac], 0);
                    NameTxt1.Text = JobInfo[sayac][posIP].ToString();
                    PingCycleNUD1.Value = Convert.ToDecimal(JobInfo[sayac][posCycle]);
                    PingDurNUD1.Value = Convert.ToDecimal(JobInfo[sayac][posDuration]);

                    satir = toku.ReadLine();
                    sayac++;
                    JobInfo[sayac] = new string[3];
                    words = satir.Split('#');
                    words.CopyTo(JobInfo[sayac], 0);
                    NameTxt2.Text = JobInfo[sayac][posIP].ToString();
                    PingCycleNUD2.Value = Convert.ToDecimal(JobInfo[sayac][posCycle]);
                    PingDurNUD2.Value = Convert.ToDecimal(JobInfo[sayac][posDuration]);

                    satir = toku.ReadLine();
                    sayac++;
                    JobInfo[sayac] = new string[3];
                    words = satir.Split('#');
                    words.CopyTo(JobInfo[sayac], 0);
                    NameTxt3.Text = JobInfo[sayac][posIP].ToString();
                    PingCycleNUD3.Value = Convert.ToDecimal(JobInfo[sayac][posCycle]);
                    PingDurNUD3.Value = Convert.ToDecimal(JobInfo[sayac][posDuration]);

                    VMsChkLst.Items.Clear();
                    satir = toku.ReadLine(); //Başlık satırını atlamak için
                    while (satir != null)
                    {
                        satir = toku.ReadLine();
                        if (satir != null)
                        {
                            sayac++;
                            VMsChkLst.Items.Add(satir.Trim(), true);
                        }
                    }
                    toku.Close();
                    LogTxt.Text += "[" + DateTime.Now.ToString() + "] - " + "Configuration File Loaded" + "\r\n";
                }
            }
        }

        private void SaveCfgBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "SvapSettings.txt";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            Stream fStream = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((fStream = saveFileDialog1.OpenFile()) != null)
                {
                    TextWriter tyaz = new StreamWriter(fStream, System.Text.Encoding.GetEncoding("windows-1254"));

                    tyaz.Write("----------IP/Name # Cycle # Duration ---------- \r\n");
                    tyaz.Write(NameTxt1.Text + "#" + PingCycleNUD1.Value.ToString() + "#" + PingDurNUD1.Value.ToString() + "\r\n");
                    tyaz.Write(NameTxt2.Text + "#" + PingCycleNUD2.Value.ToString() + "#" + PingDurNUD2.Value.ToString() + "\r\n");
                    tyaz.Write(NameTxt3.Text + "#" + PingCycleNUD3.Value.ToString() + "#" + PingDurNUD3.Value.ToString() + "\r\n");
                    tyaz.Write("---------- Virtual Machine Name---------- \r\n");
                    for (int sayac = 0; sayac < VMsChkLst.CheckedItems.Count; sayac++)
                    {
                        tyaz.Write(VMsChkLst.CheckedItems[sayac].ToString() + "\r\n");
                    }

                    tyaz.Close();
                    fStream.Close();
                    tyaz.Dispose();
                    fStream.Dispose();
                    LogTxt.Text += "[" + DateTime.Now.ToString() + "] - " + "Configuration File Saved" + "\r\n";
                }
            }
        }

        private void StartVM(string vmName)
        {
            const int Enabled = 2;
            try
            {
                ManagementScope scope = new ManagementScope(@"root\virtualization", null);
                ManagementObject vm = Utility.GetTargetComputer(vmName, scope);
                ManagementBaseObject inParams = vm.GetMethodParameters("RequestStateChange");
                inParams["RequestedState"] = Enabled;
                ManagementBaseObject outParams = vm.InvokeMethod("RequestStateChange", inParams, null);

                if ((UInt32)outParams["ReturnValue"] == ReturnCode.Started)
                {
                    if (Utility.JobCompleted(outParams, scope))
                    {
                        MsgLbl.Text = string.Format("{0} state was changed successfully.", vmName);
                        LogTxt.Text += "[" + DateTime.Now.ToString() + "] - " + MsgLbl.Text + "\r\n";
                    }
                    else
                    {
                        MsgLbl.Text = string.Format("Failed to change virtual system state {0}", vmName);
                        LogTxt.Text += "[" + DateTime.Now.ToString() + "] - " + MsgLbl.Text + "\r\n";
                    }
                }
                else if ((UInt32)outParams["ReturnValue"] == ReturnCode.Completed)
                {
                    MsgLbl.Text = string.Format("{0} state was changed successfully.", vmName);
                    LogTxt.Text += "[" + DateTime.Now.ToString() + "] - " + MsgLbl.Text + "\r\n";
                }
                else
                {
                    MsgLbl.Text = string.Format("Change virtual system ({0}) state failed with error {1}", vmName, outParams["ReturnValue"]);
                    LogTxt.Text += "[" + DateTime.Now.ToString() + "] - " + MsgLbl.Text + "\r\n";
                }
            }
            catch
            {
                MsgLbl.Text = string.Format("Failed to start virtual machine: {0}" + vmName);
                LogTxt.Text += "[" + DateTime.Now.ToString() + "] - " + MsgLbl.Text + "\r\n";
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] buffer = new byte[32];
            PingOptions Po = new PingOptions(128, true);
            Ping ping = new Ping();
            PingReply pingReply = null;
            try
            {
                int bekleme = ((int)PingDurNUD1.Value) * 1000;
                pingReply = ping.Send(NameTxt1.Text,bekleme, buffer, Po);
                if (pingReply.Status != IPStatus.Success)
                    for (int sayac = 0; sayac < VMsChkLst.CheckedItems.Count; sayac++)
                        StartVM(VMsChkLst.Items[sayac].ToString().Trim());
            }
            catch
            {
                for (int sayac = 0; sayac < VMsChkLst.CheckedItems.Count; sayac++)
                    StartVM(VMsChkLst.Items[sayac].ToString().Trim());
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            byte[] buffer = new byte[32];
            PingOptions Po = new PingOptions(128, true);
            Ping ping = new Ping();
            PingReply pingReply = null;
            try
            {
                int bekleme = ((int)PingDurNUD2.Value) * 1000;
                pingReply = ping.Send(NameTxt2.Text, bekleme, buffer, Po);
                if (pingReply.Status != IPStatus.Success)
                    for (int sayac = 0; sayac < VMsChkLst.CheckedItems.Count; sayac++)
                        StartVM(VMsChkLst.Items[sayac].ToString().Trim());
            }
            catch
            {
                for (int sayac = 0; sayac < VMsChkLst.CheckedItems.Count; sayac++)
                    StartVM(VMsChkLst.Items[sayac].ToString().Trim());
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            byte[] buffer = new byte[32];
            PingOptions Po = new PingOptions(128, true);
            Ping ping = new Ping();
            PingReply pingReply = null;
            try
            {
                int bekleme = ((int)PingDurNUD3.Value) * 1000;
                pingReply = ping.Send(NameTxt3.Text, bekleme, buffer, Po);
                if (pingReply.Status != IPStatus.Success)
                    for (int sayac = 0; sayac < VMsChkLst.CheckedItems.Count; sayac++)
                        StartVM(VMsChkLst.Items[sayac].ToString().Trim());
            }
            catch
            {
                for (int sayac = 0; sayac < VMsChkLst.CheckedItems.Count; sayac++)
                    StartVM(VMsChkLst.Items[sayac].ToString().Trim());
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartStopCtxt_Click(object sender, EventArgs e)
        {
            if (!SvapState)
                StartServiceBtn_Click(sender, e);
            else
                StopServiceBtn_Click(sender, e);
        }

        private void ClearLogBTN_Click(object sender, EventArgs e)
        {
            LogTxt.Text = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((linkLabel1.Text + "/default.aspx"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    static class ResourceType
    {
        public const UInt16 Other = 1;
        public const UInt16 ComputerSystem = 2;
        public const UInt16 Processor = 3;
        public const UInt16 Memory = 4;
        public const UInt16 IDEController = 5;
        public const UInt16 ParallelSCSIHBA = 6;
        public const UInt16 FCHBA = 7;
        public const UInt16 iSCSIHBA = 8;
        public const UInt16 IBHCA = 9;
        public const UInt16 EthernetAdapter = 10;
        public const UInt16 OtherNetworkAdapter = 11;
        public const UInt16 IOSlot = 12;
        public const UInt16 IODevice = 13;
        public const UInt16 FloppyDrive = 14;
        public const UInt16 CDDrive = 15;
        public const UInt16 DVDdrive = 16;
        public const UInt16 Serialport = 17;
        public const UInt16 Parallelport = 18;
        public const UInt16 USBController = 19;
        public const UInt16 GraphicsController = 20;
        public const UInt16 StorageExtent = 21;
        public const UInt16 Disk = 22;
        public const UInt16 Tape = 23;
        public const UInt16 OtherStorageDevice = 24;
        public const UInt16 FirewireController = 25;
        public const UInt16 PartitionableUnit = 26;
        public const UInt16 BasePartitionableUnit = 27;
        public const UInt16 PowerSupply = 28;
        public const UInt16 CoolingDevice = 29;


        public const UInt16 DisketteController = 1;
    }

    static class ResourceSubType
    {
        public const string DisketteController = null;
        public const string DisketteDrive = "Microsoft Synthetic Diskette Drive";
        public const string ParallelSCSIHBA = "Microsoft Synthetic SCSI Controller";
        public const string IDEController = "Microsoft Emulated IDE Controller";
        public const string DiskSynthetic = "Microsoft Synthetic Disk Drive";
        public const string DiskPhysical = "Microsoft Physical Disk Drive";
        public const string DVDPhysical = "Microsoft Physical DVD Drive";
        public const string DVDSynthetic = "Microsoft Synthetic DVD Drive";
        public const string CDROMPhysical = "Microsoft Physical CD Drive";
        public const string CDROMSynthetic = "Microsoft Synthetic CD Drive";
        public const string EthernetSynthetic = "Microsoft Synthetic Ethernet Port";

        //logical drive
        public const string DVDLogical = "Microsoft Virtual CD/DVD Disk";
        public const string ISOImage = "Microsoft ISO Image";
        public const string VHD = "Microsoft Virtual Hard Disk";
        public const string DVD = "Microsoft Virtual DVD Disk";
        public const string VFD = "Microsoft Virtual Floppy Disk";
        public const string videoSynthetic = "Microsoft Synthetic Display Controller";
    }

    static class OtherResourceType
    {
        public const string DisketteController = "Microsoft Virtual Diskette Controller";

    }
    static class ReturnCode
    {
        public const UInt32 Completed = 0;
        public const UInt32 Started = 4096;
        public const UInt32 Failed = 32768;
        public const UInt32 AccessDenied = 32769;
        public const UInt32 NotSupported = 32770;
        public const UInt32 Unknown = 32771;
        public const UInt32 Timeout = 32772;
        public const UInt32 InvalidParameter = 32773;
        public const UInt32 SystemInUser = 32774;
        public const UInt32 InvalidState = 32775;
        public const UInt32 IncorrectDataType = 32776;
        public const UInt32 SystemNotAvailable = 32777;
        public const UInt32 OutofMemory = 32778;
    }


    class Utility
    {
        static class JobState
        {
            public const UInt16 New = 2;
            public const UInt16 Starting = 3;
            public const UInt16 Running = 4;
            public const UInt16 Suspended = 5;
            public const UInt16 ShuttingDown = 6;
            public const UInt16 Completed = 7;
            public const UInt16 Terminated = 8;
            public const UInt16 Killed = 9;
            public const UInt16 Exception = 10;
            public const UInt16 Service = 11;
        }
        /// <summary>
        /// Common utility function to get a service object
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="serviceName"></param>
        /// <returns></returns>
        public static ManagementObject GetServiceObject(ManagementScope scope, string serviceName)
        {

            scope.Connect();
            ManagementPath wmiPath = new ManagementPath(serviceName);
            ManagementClass serviceClass = new ManagementClass(scope, wmiPath, null);
            ManagementObjectCollection services = serviceClass.GetInstances();

            ManagementObject serviceObject = null;

            foreach (ManagementObject service in services)
            {
                serviceObject = service;
            }
            return serviceObject;
        }

        public static ManagementObject GetHostSystemDevice(string deviceClassName, string deviceObjectElementName, ManagementScope scope)
        {
            string hostName = System.Environment.MachineName;
            ManagementObject systemDevice = GetSystemDevice(deviceClassName, deviceObjectElementName, hostName, scope);
            return systemDevice;
        }


        public static ManagementObject GetSystemDevice
        (
            string deviceClassName,
            string deviceObjectElementName,
            string vmName,
            ManagementScope scope)
        {
            ManagementObject systemDevice = null;
            ManagementObject computerSystem = Utility.GetTargetComputer(vmName, scope);

            ManagementObjectCollection systemDevices = computerSystem.GetRelated
            (
                deviceClassName,
                "Msvm_SystemDevice",
                null,
                null,
                "PartComponent",
                "GroupComponent",
                false,
                null
            );

            foreach (ManagementObject device in systemDevices)
            {
                if (device["ElementName"].ToString().ToLower() == deviceObjectElementName.ToLower())
                {
                    systemDevice = device;
                    break;
                }
            }

            return systemDevice;
        }



        public static bool JobCompleted(ManagementBaseObject outParams, ManagementScope scope)
        {
            bool jobCompleted = true;

            //Retrieve msvc_StorageJob path. This is a full wmi path
            string JobPath = (string)outParams["Job"];
            ManagementObject Job = new ManagementObject(scope, new ManagementPath(JobPath), null);
            //Try to get storage job information
            Job.Get();
            while ((UInt16)Job["JobState"] == JobState.Starting
                || (UInt16)Job["JobState"] == JobState.Running)
            {
                Console.WriteLine("In progress... {0}% completed.", Job["PercentComplete"]);
                System.Threading.Thread.Sleep(1000);
                Job.Get();
            }

            //Figure out if job failed
            UInt16 jobState = (UInt16)Job["JobState"];
            if (jobState != JobState.Completed)
            {
                UInt16 jobErrorCode = (UInt16)Job["ErrorCode"];
                Console.WriteLine("Error Code:{0}", jobErrorCode);
                Console.WriteLine("ErrorDescription: {0}", (string)Job["ErrorDescription"]);
                jobCompleted = false;
            }
            return jobCompleted;
        }


        public static ManagementObject GetTargetComputer(string vmElementName, ManagementScope scope)
        {
            string query = string.Format("select * from Msvm_ComputerSystem Where ElementName = '{0}'", vmElementName);

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, new ObjectQuery(query));

            ManagementObjectCollection computers = searcher.Get();

            ManagementObject computer = null;

            foreach (ManagementObject instance in computers)
            {
                computer = instance;
                break;
            }
            return computer;
        }

        public static ManagementObject GetVirtualSystemSettingData(ManagementObject vm)
        {
            ManagementObject vmSetting = null;
            ManagementObjectCollection vmSettings = vm.GetRelated
            (
                "Msvm_VirtualSystemSettingData",
                "Msvm_SettingsDefineState",
                null,
                null,
                "SettingData",
                "ManagedElement",
                false,
                null
            );

            if (vmSettings.Count != 1)
            {
                throw new Exception(String.Format("{0} instance of Msvm_VirtualSystemSettingData was found", vmSettings.Count));
            }

            foreach (ManagementObject instance in vmSettings)
            {
                vmSetting = instance;
                break;
            }

            return vmSetting;
        }


        enum ValueRole
        {
            Default = 0,
            Minimum = 1,
            Maximum = 2,
            Increment = 3
        }
        enum ValueRange
        {
            Default = 0,
            Minimum = 1,
            Maximum = 2,
            Increment = 3
        }


        //
        // Get RASD definitions
        //
        public static ManagementObject GetResourceAllocationsettingDataDefault
        (
            ManagementScope scope,
            UInt16 resourceType,
            string resourceSubType,
            string otherResourceType
            )
        {
            ManagementObject RASD = null;

            string query = String.Format("select * from Msvm_ResourcePool where ResourceType = '{0}' and ResourceSubType ='{1}' and OtherResourceType = '{2}'",
                             resourceType, resourceSubType, otherResourceType);

            if (resourceType == ResourceType.Other)
            {
                query = String.Format("select * from Msvm_ResourcePool where ResourceType = '{0}' and ResourceSubType = null and OtherResourceType = {1}",
                                             resourceType, otherResourceType);
            }
            else
            {
                query = String.Format("select * from Msvm_ResourcePool where ResourceType = '{0}' and ResourceSubType ='{1}' and OtherResourceType = null",
                                             resourceType, resourceSubType);
            }

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, new ObjectQuery(query));

            ManagementObjectCollection poolResources = searcher.Get();

            //Get pool resource allocation ability
            if (poolResources.Count == 1)
            {
                foreach (ManagementObject poolResource in poolResources)
                {
                    ManagementObjectCollection allocationCapabilities = poolResource.GetRelated("Msvm_AllocationCapabilities");
                    foreach (ManagementObject allocationCapability in allocationCapabilities)
                    {
                        ManagementObjectCollection settingDatas = allocationCapability.GetRelationships("Msvm_SettingsDefineCapabilities");
                        foreach (ManagementObject settingData in settingDatas)
                        {

                            if (Convert.ToInt16(settingData["ValueRole"]) == (UInt16)ValueRole.Default)
                            {
                                RASD = new ManagementObject(settingData["PartComponent"].ToString());
                                break;
                            }
                        }
                    }
                }
            }

            return RASD;
        }


        public static ManagementObject GetResourceAllocationsettingData
        (
            ManagementObject vm,
            UInt16 resourceType,
            string resourceSubType,
            string otherResourceType
            )
        {
            //vm->vmsettings->RASD for IDE controller
            ManagementObject RASD = null;
            ManagementObjectCollection settingDatas = vm.GetRelated("Msvm_VirtualSystemsettingData");
            foreach (ManagementObject settingData in settingDatas)
            {
                //retrieve the rasd
                ManagementObjectCollection RASDs = settingData.GetRelated("Msvm_ResourceAllocationsettingData");
                foreach (ManagementObject rasdInstance in RASDs)
                {
                    if (Convert.ToUInt16(rasdInstance["ResourceType"]) == resourceType)
                    {
                        //found the matching type
                        if (resourceType == ResourceType.Other)
                        {
                            if (rasdInstance["OtherResourceType"].ToString() == otherResourceType)
                            {
                                RASD = rasdInstance;
                                break;
                            }
                        }
                        else
                        {
                            if (rasdInstance["ResourceSubType"].ToString() == resourceSubType)
                            {
                                RASD = rasdInstance;
                                break;
                            }
                        }
                    }
                }

            }
            return RASD;
        }
    }

}
