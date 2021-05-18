using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TheComfortZone
{
    public partial class Admin : Form
    {

        List<Item> ListItems = Program.ListItems;

        public Admin()
        {

            InitializeComponent();
           
            LoadList();
            
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        public void LoadList()
        {
            foreach (Item item in ListItems)
            {
                ListViewItem lvItem = new ListViewItem(item.productName);

                lvItem.SubItems.Add(item.code);
                lvItem.SubItems.Add(item.stockLeft.ToString());
                lvItem.SubItems.Add(item.color);
                lvItem.SubItems.Add("$"+item.price.ToString());
                lvItem.SubItems.Add(item.discount.ToString() + "%");

                listView1.Items.Add(lvItem);

            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxCode.Text;
            tableLayoutPanel1.Enabled = true;

            MessageBox.Show("The number of items has to be grater than 0");

            bool exiss = ListItems.Any(y => y.code == code);


            if (exiss)
            {

            }
            Item item = ListItems.Find(x => x.code.StartsWith(code));
           

            labelName.Text = item.productName;
            textBoxSlefkt.Text = item.stockLeft.ToString();
            textBoxPrice.Text = item.price.ToString();
            textBoxDiscount.Text = item.discount.ToString();
            labelColour.Text = item.color;
        }
    }
}
