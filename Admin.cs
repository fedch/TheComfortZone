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
//Diana Vanessa Gonzalez class admin 

namespace TheComfortZone
{
    public partial class Admin : Form
    {
        //list of items
        List<Item> items1;


        //Admin Constructor with a list of items as a parameter
        public Admin(List<Item> items)
        {   
            //assignate the value of list of the parameter to the list of the class 
            items1 = items;
            InitializeComponent();
            LoadList();
            
        }

        //loads the list of items in the form 
        public void LoadList()
        {
            foreach (Item item in items1)
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






        //Find the item with the specific code  and enables the options for updating the item
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            //Find the item with the specific code 
            string code = textBoxCode.Text;
            bool exiss = items1.Any(y => y.code == code);

            //If the item exists display infomration 
            if (exiss)
            {

                Item item = items1.Find(x => x.code.StartsWith(code));


                labelName.Text = item.productName;
                textBoxSlefkt.Text = item.stockLeft.ToString();
                textBoxPrice.Text = item.price.ToString();
                textBoxDiscount.Text = item.discount.ToString();
                labelColour.Text = item.color;

                //enables panel
                tableLayoutPanel1.Enabled = true;

            }
            //print message if the item does not exist
            else
            {
                MessageBox.Show("The code does not exist");
            }
        }









        //Gets the values on the text box and updates the item 

        private void button1_Click(object sender, EventArgs e)
        {

            string code = textBoxCode.Text;
            //Find the item with the specific code 
            Item item = items1.Find(x => x.code.StartsWith(code));

            //assigns the new values to the atributes of the item 
            item.price = decimal.Parse( textBoxPrice.Text);
            item.stockLeft = int.Parse(textBoxSlefkt.Text);
            item.discount = decimal.Parse(textBoxDiscount.Text);



            updateItem(item);

        }


        //Shows in the listview the updated values of the item
        public void updateItem(Item item)
        {
            int position = items1.IndexOf(item);

            var lvi = listView1.Items[position];

            lvi.SubItems[0].Text = item.productName;
            lvi.SubItems[1].Text = item.code;
            lvi.SubItems[2].Text = item.stockLeft.ToString();
            lvi.SubItems[3].Text = item.color;
            lvi.SubItems[4].Text = "$" + item.price.ToString();
            lvi.SubItems[5].Text = item.discount.ToString() + "%";
            
        }


        //close and save, close the form and updates the text file with the new information for each item
        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter(@"Items1.txt"))
            {

                
                foreach(Item item in items1)
                {
                    //Item|Code|Stock Left|Color|Price|Discount
                    streamWriter.WriteLine(item.productName + "|" + item.code + "|" + item.stockLeft + "|" + item.color + "|" + item.price + "|" + item.discount); 
                }


                this.Close();
            }

        }
    }
}
