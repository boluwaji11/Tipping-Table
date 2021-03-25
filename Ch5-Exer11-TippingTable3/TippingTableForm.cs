//Developer: Oyewumi, Boluwaji
//Course: MIS 5315 – Spring 2021
//Assignment: Ch5-Ex11-TippingTable3
//Description: This program creates a table of the tipping prices for a restaurant

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_Exer11_TippingTable3
{
    public partial class TippingTableForm : Form
    {
        public TippingTableForm()
        {
            InitializeComponent();
        }

        private void TippingTableForm_Load(object sender, EventArgs e)
        {
            // Set Default Values
            txtLowestPercentage.Text = "10";
            txtHighestPercentage.Text = "25";
            txtLowestBill.Text = "10";
            txtHighestBill.Text = "200";

            // Clear Output Panel
            pnlOutput.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all values
            txtLowestPercentage.Text = "";
            txtHighestPercentage.Text = "";
            txtLowestBill.Text = "";
            txtHighestBill.Text = "";
            pnlOutput.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declare variables
            double lowestPercent = 0;
            double highestPercent = 0;
            const double TIP_RATE_STEP = 0.05;
            string outputLines = "";
            

            //Input and Validation
            if (!(double.TryParse(txtLowestPercentage.Text, out lowestPercent) && double.TryParse(txtHighestPercentage.Text, out highestPercent)))
            {
                MessageBox.Show("Enter a number.", "Input Error");
            }

            // Input
            lowestPercent = (Convert.ToDouble(txtLowestBill.Text)) / 100;
            highestPercent = (Convert.ToDouble(txtHighestPercentage.Text)) / 100;


            //Display Tip Rate Header Line

            while (lowestPercent <= highestPercent)
            {
                outputLines += String.Format("{0,8}", lowestPercent.ToString("F"));
                lowestPercent += TIP_RATE_STEP;
            }

            // Display Dashed Line

            // Generate Tip Rate Table
            lblOuput.Text = outputLines.ToString();

            pnlOutput.Visible = true;
        }
    }
}
