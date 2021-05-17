using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TheComfortZone
{
    public partial class Checkout : Form
    {
        public static string productIDProvided;
        public static double discountAppl;
        int index;
        public decimal discountedPrice;
        public static List<string> chosenItemsNames = new List<string>();
        public static List<int> chosenItemsAmount = new List<int>();
        public static List<decimal> chosenItemsegularPrices = new List<decimal>();
        public static List<decimal> chosenItemsDiscountedPrices = new List<decimal>();
        public static decimal chosenItemsTotalPrice = 0;

        List<Item> ListItems = Program.ListItems;

        public Checkout()
        {            
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the index from the user:
            productIDProvided = txtBxProdID.Text;

            // Find the index of that index
            foreach (Item item in ListItems)
            {
                if (item.code == productIDProvided)
                {
                    index = ListItems.IndexOf(item);
                    if (ListItems.IndexOf(item) == index)
                    {
                        lblProdNameAct.Text = item.productName;
                        nuUpDownAmount.Maximum = item.stockLeft;
                        txtBoxPrice.Text = "$" + item.price.ToString();
                        tBDiscount.Text = item.discount.ToString() + "%";
                        discountedPrice = (item.price * ((100 - item.discount) / 100));
                        tbAftDisc.Text = "$" + discountedPrice.ToString();
                    }
                }                
            }            
        }

        private void btnToCart_Click(object sender, EventArgs e)
        {
            // Add item codes to the list box:
            lBoxIDs.Items.Add(productIDProvided);
            // Save item codes in a new list:
            chosenItemsNames.Add(lblProdNameAct.Text);
            // Add chosen amounts to the list box:
            lBoxAmounts.Items.Add(nuUpDownAmount.Value);
            // Save chosen amounts in a new list:
            chosenItemsAmount.Add(Convert.ToInt32(nuUpDownAmount.Value));
            // Save prices in a new list:
            chosenItemsegularPrices.Add(Convert.ToDecimal(txtBoxPrice.Text));
            chosenItemsDiscountedPrices.Add(discountedPrice);

            // Store total in a variable, increase with every product added:
            chosenItemsTotalPrice += nuUpDownAmount.Value * discountedPrice;
            // Display the total in the form:
            lblTotal2.Text = chosenItemsTotalPrice.ToString();            
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            Invoice formInvoice = new Invoice();
            formInvoice.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }
    }
}
