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

    }
}
