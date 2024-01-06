using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.IO;

namespace zmsNetwork
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private void pic_connection_Click(object sender, EventArgs e)
        {
            //Connect to the DNS
            if (cmb_listdns.SelectedItem != null)
            {
                switch (cmb_listdns.SelectedIndex)
                {
                    case 0://403
                        Set("10.202.10.202", "10.202.10.102");
                        break;
                    case 1://shecan
                        Set("178.22.122.100", "185.51.200.2");
                        break;
                    case 2://radar
                        Set("10.202.10.10", "10.202.10.11");
                        break;
                    case 3://electro
                        Set("78.157.42.100", "78.157.42.101");
                        break;
                    case 4://begzar
                        Set("185.55.226.26", "185.55.225.25");
                        break;
                    case 5://google
                        Set("8.8.8.8", "8.8.4.4");
                        break;
                    case 6://dnsloudflare
                        Set("1.1.1.1", "1.0.0.1");
                        break;
                    case 7://quad9
                        Set("9.9.9.9", "149.112.112.112");
                        break;
                    case 8://opendns
                        Set("208.67.222.222", "208.67.220.220");
                        break;
                    case 9://403 2
                        Set("10.202.10.102", "10.202.10.202");
                        break;
                    case 10://opendns 2
                        Set("208.67.220.220", "208.67.222.222");
                        break;
                    case 11://quad9 2
                        Set("149.112.112.112", "9.9.9.9");
                        break;
                    case 12://shecan 2
                        Set("185.51.220.2", "178.22.122.100");
                        break;
                    case 13://radar 2
                        Set("10.202.10.11", "10.202.10.10");
                        break;
                    case 14://electro 2
                        Set("78.157.42.101", "78.157.42.100");
                        break;
                    case 15://electro 3
                        Set("78.157.42.100", "78.157.42.110");
                        break;
                    case 16://electro 4
                        Set("78.157.42.110", "78.157.42.100");
                        break;
                    case 17://begzar 2
                        Set("185.55.225.25", "185.55.226.26");
                        break;
                    case 18://dnsloudflare 2
                        Set("1.1.1.2", "1.0.0.2");
                        break;
                    case 19://dnsloudflare 3
                        Set("1.1.1.3", "1.0.0.3");
                        break;
                    case 20://dns1
                        Set("194.36.174.161", "178.22.122.100");
                        break;
                    case 21://dns2
                        Set("78.157.42.100", "178.22.122.100");
                        break;
                    case 22://dns3
                        Set("78.157.42.101", "178.22.122.100");
                        break;
                    case 23://dns4
                        Set("78.157.42.110", "178.22.122.100");
                        break;
                    case 24://dns5
                        Set("37.152.182.112", "0.0.0.0");
                        break;
                    case 25://dns6
                        Set("178.22.122.100", "0.0.0.0");
                        break;
                    case 26://dns7
                        Set("185.51.200.2", "0.0.0.0");
                        break;
                    case 27://dns8
                        Set("88.135.36.247", "0.0.0.0");
                        break;
                    case 28://dns9
                        Set("532.63.8.717", "262.84.647.7");
                        break;
                    case 29://dns10
                        Set("109.96.8.51", "78.157.42.101");
                        break;
                    case 30://dns11
                        Set("109.96.8.51", "78.157.42.100");
                        break;
                    case 31://dns12
                        Set("109.96.8.51", "78.157.42.110");
                        break;
                    case 32://dns13
                        Set("156.154.70.1", "156.154.71.1");
                        break;
                    case 33://dns14
                        Set("156.154.71.1", "156.154.70.1");
                        break;
                    case 34://dns15
                        Set("91.239.100.100", "89.233.43.71");
                        break;
                    case 35://dns16
                        Set("109.69.8.51", "74.82.42.42");
                        break;
                    case 36://dns17
                        Set("109.69.8.51", "0.0.0.0");
                        break;
                    case 37://dns18
                        Set("74.82.42.42", "0.0.0.0");
                        break;
                    case 38://dns19
                        Set("4.4.4.4", "4.2.2.4");
                        break;
                    case 39://dns20
                        Set("91.239.100.100", "0.0.0.0");
                        break;
                    case 40://dns21
                        Set("195.46.39.39", "195.46.39.40");
                        break;
                    case 41://dns22
                        Set("195.46.39.40", "195.46.39.39");
                        break;
                    case 42://dns23
                        Set("10.44.8.8", "8.8.8.8");
                        break;
                    case 43://dns24
                        Set("199.85.127.10", "199.85.126.10");
                        break;
                    case 44://dns25
                        Set("199.85.126.10", "199.85.127.10");
                        break;
                    case 45://dns26
                        Set("77.88.8.8", "77.88.8.1");
                        break;
                    case 46://dns27
                        Set("8.20.247.20", "8.26.56.26");
                        break;
                    case 47://dns28
                        Set("77.88.8.1", "77.88.8.8.");
                        break;
                    case 48://dns29
                        Set("8.8.8.8", "4.2.2.4");
                        break;
                    default:
                        //Nothing :)
                        break;
                }

                //Change Ui
                File.WriteAllText("C:\\Users\\Public\\Documents\\lastconnection.txt", cmb_listdns.Text);
                pic_connect.Visible = false;
                pic_disconnect.Visible = true;
                lbl_status.Text = "   Connected";
                BackColor = Color.Brown;
                lbl_status.ForeColor = Color.LightSalmon;
                lbl_listdns.ForeColor = Color.LightSalmon;
                lbl_exit.BackColor = Color.LightSalmon;
                lbl_exit.ForeColor = Color.Brown;
                cmb_listdns.BackColor = Color.IndianRed;
                cmb_listdns.Enabled = false;
                btn_lastconnection.ForeColor = Color.LightSalmon;
                btn_lastconnection.Visible = false;
            }
            else
            {
                if (MessageBox.Show("Error : You must Select DNS", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else { }
            }
        }

        private void pic_disconnect_Click(object sender, EventArgs e)
        {
            //Disconnect DNS
            Unset();

            //Change Ui to Default
            pic_disconnect.Visible = false;
            pic_connect.Visible = true;
            lbl_status.Text = "Not Connected";
            BackColor = Color.FromArgb(35, 25, 66);
            lbl_status.ForeColor = Color.FromArgb(190, 149, 196);
            lbl_listdns.ForeColor = Color.FromArgb(190, 149, 196);
            lbl_exit.BackColor = Color.FromArgb(190, 149, 196);
            lbl_exit.ForeColor = Color.FromArgb(35, 25, 66);
            cmb_listdns.BackColor = Color.FromArgb(94, 84, 142);
            cmb_listdns.Enabled = true;
            btn_lastconnection.ForeColor = Color.FromArgb(190, 149, 196);
            btn_lastconnection.Visible = false;
        }
        private void cmb_listdns_KeyUp(object sender, KeyEventArgs e)
        {
            cmb_listdns.Text = null;
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Unset();
            Application.Exit();
        }
        public bool isconnect = false;
        public static NetworkInterface GetActiveEthernetOrWifiNetworkInterface()
        {
            var Nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(
                a => a.OperationalStatus == OperationalStatus.Up &&
                (a.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || a.NetworkInterfaceType == NetworkInterfaceType.Ethernet) &&
                a.GetIPProperties().GatewayAddresses.Any(g => g.Address.AddressFamily.ToString() == "InterNetwork"));

            return Nic;
        }
        public static void Set(string DnsString1, string DnsString2)
        {
            string[] Dns = { DnsString1, DnsString2 };
            var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
            if (CurrentInterface == null) return;

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Caption"].ToString().Contains(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = Dns;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }
        public static void Unset()
        {
            var CurrentInterface = GetActiveEthernetOrWifiNetworkInterface();
            if (CurrentInterface == null) return;

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Caption"].ToString().Contains(CurrentInterface.Description))
                    {
                        ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        if (objdns != null)
                        {
                            objdns["DNSServerSearchOrder"] = null;
                            objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                        }
                    }
                }
            }
        }
    }
}