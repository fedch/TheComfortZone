using System;
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
            lblTime.Text = DateTime.Now.ToString("h:mm:ss tt");

            // Display all added products and corresponding information
            for (int i = 0; i < Checkout.chosenItemsNames.Count; i++)
            {
                lbProducts.Items.Add(Checkout.chosenItemsNames[i]);
                lbQty.Items.Add(Checkout.chosenItemsAmount[i]);
                lbPrice.Items.Add("$" + Checkout.chosenItemsegularPrices[i]);
                lbTotal.Items.Add("$" + Checkout.chosenItemsegularPrices[i] * Checkout.chosenItemsAmount[i]);
                lbDiscount.Items.Add("-$" + ((Checkout.chosenItemsegularPrices[i] * Checkout.chosenItemsDiscounts[i]) / 100)* Checkout.chosenItemsAmount[i]);
            }

            // Display total, with and without GST:
            lblBalDue.Text = "$" + Checkout.chosenItemsTotalPrice.ToString();
            decimal gst = Math.Round((Checkout.chosenItemsTotalPrice * 3 / 23), 2);
            lblSubTotalNum.Text = "$" + Math.Round((Checkout.chosenItemsTotalPrice - gst), 2).ToString();
            lblGSTNum.Text = "$" + Math.Round((gst), 2).ToString();

            lblTotalFinalNum.Text = "$" + Math.Round((Checkout.chosenItemsTotalPrice), 2).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        { 
            // Add an event to close this form:
            this.Close();
        }
    }
}
