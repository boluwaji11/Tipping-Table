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
            double dinnerPrice = 10.00;
            double tipRate;
            double tip;

            while (tipRate <= MAXRATE)
            {

            }
        }
    }
}
