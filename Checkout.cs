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
        public static List<decimal> chosenItemsPrices = new List<decimal>();
        public static decimal chosenItemsTotalPrice = 0;

        List<Item> ListItems = Program.ListItems;

        public Checkout()
        {            
            InitializeComponent();
            //comboBoxDiscount.Text = "0";

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
                        comboBoxDiscount.Items.Add(0);
                        comboBoxDiscount.Items.Add(item.discount); // ADDS NEW DISCOUNT FOR EVERY ADDED PRODUCT, FIX
                        discountedPrice = (item.price * ((100 - item.discount) / 100));
                        if (string.IsNullOrEmpty(comboBoxDiscount.Text))  // DOESN'T WORK YET, STILL SHOWS DISCOUNT REGARDLESS OF A CHOICE, FIX
                            tbAftDisc.Text = "$" + discountedPrice.ToString();
                        else
                            tbAftDisc.Text = item.price.ToString();
                    }
                }                
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add item codes to the list box:
            lBoxIDs.Items.Add(productIDProvided);
            // Save item codes in a new list:
            chosenItemsNames.Add(productIDProvided);
            // Add chosen amounts to the list box:
            lBoxAmounts.Items.Add(nuUpDownAmount.Value);
            // Save chosen amounts in a new list:
            chosenItemsAmount.Add(Convert.ToInt32(nuUpDownAmount.Value));
            // Save prices in a new list:
            chosenItemsPrices.Add(discountedPrice);
            // Store total in a variable, increase with every product added:
            chosenItemsTotalPrice += nuUpDownAmount.Value * discountedPrice;
            // Display the total in the form:
            lblTotal2.Text = chosenItemsTotalPrice.ToString();            
        }
    }
}
