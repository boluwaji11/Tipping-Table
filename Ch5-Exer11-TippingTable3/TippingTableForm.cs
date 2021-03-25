﻿//Developer: Oyewumi, Boluwaji
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
            const double BILL_STEP = 10.00;

            double lowestBill = 0;
            double highestBill= 0;
            double tip;

            string outputLines = "Price";


            //Input Validation
            if (!(double.TryParse(txtLowestPercentage.Text, out lowestPercent) && double.TryParse(txtHighestPercentage.Text, out highestPercent) &&
                double.TryParse(txtLowestBill.Text, out lowestBill) && double.TryParse(txtHighestBill.Text, out highestBill)))
            {
                MessageBox.Show("Enter a valid number!", "Input Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return;
            }

            // Get Input from Users
            lowestPercent = Convert.ToDouble(txtLowestPercentage.Text) / 100;
            highestPercent = Convert.ToDouble(txtHighestPercentage.Text) / 100;
            lowestBill = Convert.ToDouble(txtLowestBill.Text);
            highestBill = Convert.ToDouble(txtHighestBill.Text);


            //Display Tip Rate Header Line
            //outputLines += String.Empty.PadLeft(4, ' ');
            while (lowestPercent <= highestPercent)
            {
                outputLines += String.Format("{0,9}", lowestPercent.ToString("P"));
                lowestPercent += TIP_RATE_STEP;
            }
            outputLines += "\n";

            // Display Dashed Line
            outputLines += String.Empty.PadLeft(5, ' ');
            outputLines += String.Empty.PadLeft(Convert.ToInt32(txtHighestPercentage.Text) * 2, '-');
            outputLines += "\n";

            // Reset the lowest percentage back to the user values
            lowestPercent = Convert.ToDouble(txtLowestPercentage.Text) / 100;
            
            // Generate Tip Rate Table
            for (double i = lowestBill; i <= highestBill; i += BILL_STEP)
            {
                outputLines += String.Format("{0,3} |", i);

                for (double j = lowestPercent; j <= highestPercent; j += TIP_RATE_STEP)
                {
                    tip = i * j;
                    outputLines += String.Format("{0,9}", tip.ToString("C"));
                }

                outputLines += "\n";
            }

            // Display Output
            lblOuput.Text = outputLines.ToString();

            pnlOutput.Visible = true;
        }
    }
}
