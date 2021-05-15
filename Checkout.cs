using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TheComfortZone
{
    public partial class Checkout : Form
    {
        public static string productIDProvided;
        public static double discountAppl;
        int index;

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
                        comboBoxDiscount.Items.Add(item.discount);
                        if (string.IsNullOrEmpty(comboBoxDiscount.Text))  // DOESN'T WORK YET, STILL SHOWS DISCOUNT REGARDLESS OF A CHOICE, FIX
                            tbAftDisc.Text = "$" + (item.price * ((100-item.discount)/100)).ToString();
                        else
                            tbAftDisc.Text = item.price.ToString();
                    }
                }                
            }            
        }
    }
}
