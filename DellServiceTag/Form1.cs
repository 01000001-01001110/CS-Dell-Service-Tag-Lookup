//Dell Service Lookup Tool. 
//Written by: Alan Newingham
//Date: 3/10/2020
//Application finds the service tag from bios using System.Management; 
//Converts the service tag to express service code. 
//Interjects the service tag into the Dell site links to open warranty information, and Drivers info. 
//Adding today 3/11/2020 - Link to Dell Tech Direct 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;

namespace DellServiceTag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Define strings.
        String dellServiceTag;
        String expressCode;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load Service Tag. Grab service tag from bios. 
            ManagementClass wmi = new ManagementClass("Win32_Bios");
            //Formatting the service tag.
            foreach (ManagementObject bios in wmi.GetInstances())
            {
                dellServiceTag = bios.Properties["Serialnumber"].Value.ToString().Trim();
            }
            //Display the service tag of the computer. 
            Display.Text = dellServiceTag;
            //Convert the serial number to base36 and format the output accordingly. 
            expressCode = base36decode(dellServiceTag).ToString("###########");
            //Display express service code in this Form.
            ExpressTxtBox.Text = expressCode;
        }
        //Let's get the drivers and interject the service tag. 
        private void DriversLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //With "using System.Diagnostics;" at the top of this the "System.Diagnostics.Process.Start" can be reduced to "Process.Start"
            System.Diagnostics.Process.Start("https://www.dell.com/support/home/us/en/04/product-support/servicetag/" + dellServiceTag + "/drivers");
        }
        //Lets get the system information and interject the service tag as needed in the URL. 
        private void warrantyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //With "using System.Diagnostics;" at the top of this is just "Process.Start"
            Process.Start("https://www.dell.com/support/home/us/en/04/product-support/servicetag/" + dellServiceTag + "/overview");
        }
        //Link to Dell TechDirect.
        private void TechDirectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //With "using System.Diagnostics;" at the top of this is just "Process.Start"
            Process.Start("https://techdirect.dell.com/portal/Login.aspx");
        }

        //Decode the service tag to the express service code. 
        private long base36decode(string inputString)
        {
            //Define the characters that will be in this array. 
            string clist = "0123456789abcdefghijklmnopqrstuvwxyz";
            //Change input service tag to all lowercase, back to front.
            inputString = Reverse(inputString.ToLower());
            long result = 0;
            int pos = 0;
            foreach (char c in inputString)
            //Do math, theroy and practice from https://stackoverflow.com/questions/33729397/how-to-convert-a-floating-point-number-to-base36-in-c-sharp-in-the-same-way-as-j
            {
                result += clist.IndexOf(c) * (long)Math.Pow(36, pos);
                pos++;
            }
            //Result = express service code. 
            return result;
        }
        //Reverse information needed to complete the base36decode.
        private string Reverse(string input)
        {
            //Flip this shit around.
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

       
    }
}
      