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
            for (int i = 0; i < Checkout.chosenItemsNames.Count; i++)
            {
                lbProducts.Items.Add(Checkout.chosenItemsNames[i]);
                lbQty.Items.Add(Checkout.chosenItemsAmount[i]);
                lbPrice.Items.Add("$" + Checkout.chosenItemsDiscountedPrices[i]);
                lbTotal.Items.Add(Checkout.chosenItemsegularPrices[i]); // FIX, SHOULD PROVIDE TOTAL FOR CHOSEN AMOUNT MINUS DISCOUNT
            }                
        }
    }
}
