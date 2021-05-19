using System;
using System.Collections.Generic;
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
        public static List<decimal> chosenItemsDiscounts = new List<decimal>();
        public static decimal chosenItemsTotalPrice = 0;

        List<Item> ListItems = Program.ListItems;

        public Checkout()
        {            
            InitializeComponent();
            // Disable the Add to cart and Payment Confirmed buttons:
            btnToCart.Enabled = false;
            btnPayment.Enabled = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the index from the user:
            productIDProvided = txtBxProdID.Text;

            int count = 0;

            // Find the index of that index
            foreach (Item item in ListItems)
            {
                // Find if the ID provided by the user matches an ID in the inventory:
                if (item.code == productIDProvided)
                {
                    // Enable the Add to Cart button:
                    btnToCart.Enabled = true;
                    // Find the corresponding index:
                    index = ListItems.IndexOf(item);
                    // When that index matches indeces of the items in ListItems, display those items in the form: 
                    if (ListItems.IndexOf(item) == index)
                    {
                        lblProdNameAct.Text = item.productName;
                        nuUpDownAmount.Maximum = item.stockLeft;
                        txtBoxPrice.Text = "$" + Math.Round((item.price), 2).ToString();
                        tBDiscount.Text = item.discount.ToString() + "%";
                        discountedPrice = (item.price * ((100 - item.discount) / 100));
                        tbAftDisc.Text = "$" + Math.Round(discountedPrice, 2).ToString();
                    }
                }

                else
                {
                    // If the ID provided is not in the inventory, print an error message and set the field to zero:
                    count++;
                    if (count > item.code.Length)
                    {
                        MessageBox.Show("Wrong ID. Product not found");
                        txtBxProdID.Text = "0";
                        btnToCart.Enabled = false;
                    }
                }
            }            
        }

        private void btnToCart_Click(object sender, EventArgs e)
        {
            // Make sure the user provides the right ID, amount and the product is not a duplicate
            if (txtBxProdID.Text != "0"  && txtBxProdID.Text != "" && nuUpDownAmount.Value != 0 && !lBoxIDs.Items.Contains(productIDProvided))
            {
                btnPayment.Enabled = true;
                // Add item codes to the list box:
                lBoxIDs.Items.Add(productIDProvided);
                // Save item codes in a new list:
                chosenItemsNames.Add(lblProdNameAct.Text);
                // Add chosen amounts to the list box:
                lBoxAmounts.Items.Add(nuUpDownAmount.Value);
                // Save chosen amounts in a new list:
                chosenItemsAmount.Add(Convert.ToInt32(nuUpDownAmount.Value));
                // Save prices in a new list:
                chosenItemsegularPrices.Add(decimal.Parse(txtBoxPrice.Text, System.Globalization.NumberStyles.Currency));
                chosenItemsDiscounts.Add(decimal.Parse(tBDiscount.Text.Replace("%", "")));

                // Store total in a variable, increase with every product added:
                chosenItemsTotalPrice += (nuUpDownAmount.Value * discountedPrice);
                // Display the total in the form:
                lblTotal2.Text = "$" + chosenItemsTotalPrice.ToString();
            }
            else
            {
                // If user didn't choose amount over zero, or provided 
                MessageBox.Show("Can't add to cart: wrong ID or amount");
            }
                       
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            // Show the Invoice form:
            Invoice formInvoice = new Invoice();
            formInvoice.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset all fields in the checkout form to null or zero:
            txtBxProdID.Text = "";
            lblProdNameAct.Text = "";
            nuUpDownAmount.Value = 0;
            txtBoxPrice.Text = "";
            tBDiscount.Text = "";
            tbAftDisc.Text = "";
            for (int n = lBoxIDs.Items.Count - 1; n >= 0; --n)
                lBoxIDs.Items.RemoveAt(n);
            for (int n = lBoxAmounts.Items.Count - 1; n >= 0; --n)
                lBoxAmounts.Items.RemoveAt(n);
            lblTotal2.Text = "";

            btnToCart.Enabled = false;
            btnPayment.Enabled = false;

            // Reset all lists and totals, which will go to the invoice form, to empty or zero:
            chosenItemsNames.Clear();
            chosenItemsAmount.Clear();
            chosenItemsegularPrices.Clear();
            chosenItemsDiscounts.Clear();
            chosenItemsTotalPrice = 0;
        }
    }
}
