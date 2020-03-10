using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace DellServiceTag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String dellServiceTag;
        String expressCode;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load Service Tag
            ManagementClass wmi = new ManagementClass("Win32_Bios");
            foreach (ManagementObject bios in wmi.GetInstances())
            {
                dellServiceTag = bios.Properties["Serialnumber"].Value.ToString().Trim();
            }
            Display.Text = dellServiceTag;
            expressCode = base36decode(dellServiceTag).ToString("###-###-###-##");
            ExpressTxtBox.Text = expressCode;
        }

        private void DriversLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dell.com/support/home/us/en/04/product-support/servicetag/" + dellServiceTag + "/drivers");
        }

        private void warrantyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dell.com/support/home/us/en/04/product-support/servicetag/" + dellServiceTag +"/overview");
        }

        private long base36decode(string inputString)
        {
            string clist = "0123456789abcdefghijklmnopqrstuvwxyz";
            inputString = Reverse(inputString.ToLower());
            long result = 0;
            int pos = 0;
            foreach (char c in inputString)
            {
                result += clist.IndexOf(c) * (long)Math.Pow(36, pos);
                pos++;
            }
            return result;
        }

        private string Reverse(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        
    }
}
      