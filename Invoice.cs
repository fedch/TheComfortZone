using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TheComfortZone
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();            
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // Show current date and time:
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblTime.Text = DateTime.Now.ToString("h:mm tt");

            // Display all added products and corresponding information
            for (int i = 0; i < Checkout.chosenItemsNames.Count; i++)
            {
                lbProducts.Items.Add(Checkout.chosenItemsNames[i]);
                lbQty.Items.Add(Checkout.chosenItemsAmount[i]);
                lbPrice.Items.Add("$" + Checkout.chosenItemsegularPrices[i]);
                lbTotal.Items.Add("$" + Checkout.chosenItemsegularPrices[i] * Checkout.chosenItemsAmount[i]);
                lbDiscount.Items.Add("-$" + ((Checkout.chosenItemsegularPrices[i] * Checkout.discounts[i]) / 100));
            }

            // Display total, with and without GST:
            lblBalDue.Text = "$" + Checkout.chosenItemsTotalPrice.ToString();
            decimal gst = Math.Round((Checkout.chosenItemsTotalPrice * 3 / 23), 2);
            lblSubTotalNum.Text = "$" + (Checkout.chosenItemsTotalPrice - gst).ToString();
            lblGSTNum.Text = "$" + gst.ToString();

            lblTotalFinalNum.Text = Checkout.chosenItemsTotalPrice.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Add event to close this form:
            this.Close();
        }
    }
}
