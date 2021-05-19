using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections;
//Timurs Part
namespace TheComfortZone
{
    
    public partial class menu : Form
    {



        public List<Item> ListItemsFinal = new List<Item>();

        public menu()
        {
            InitializeComponent();
            using (StreamReader streamReader = new StreamReader(@"Items1.txt"))
            {

                string line = string.Empty;
                string[] tempArray = new string[100];
                line = streamReader.ReadLine();

                //Initialize the List of items

                //Loop for reading the file 
                while ((line = streamReader.ReadLine()) != null)
                {
                    tempArray = line.Split('|');

                    //Adding items into the different lists
                    ListItemsFinal.Add(new Item(tempArray[0], tempArray[1], int.Parse(tempArray[2]), tempArray[3], decimal.Parse(tempArray[4]), decimal.Parse(tempArray[5])));
                }
            }
        }

        

        public void menu_Load(object sender, EventArgs e)
        {
            
        }
    

        
        //Admin Activities button
        private void button1_Click(object sender, EventArgs e)
        {
            //new object
            login L = new login();
            UserClass U = new UserClass();
            //call funcion from User class
            U.getdata();
            {
                //Authorise login details for admin and open the form
                if (login.a == U.adminlogin && login.b == U.adminpass)
                {

                    Admin f2 = new Admin(ListItemsFinal);

                    f2.Show();
                }
                
                //If it's sales staff diplay error message
                else if (login.a != U.adminlogin || login.b != U.adminpass)
                {
                    MessageBox.Show("Access Denied.");

                }
            }
        }

        //Button for Checkout Process
        private void button2_Click(object sender, EventArgs e)
        {
            //new object
            login L = new login();
            UserClass U = new UserClass();
            //call funtion from User class
            U.getdata();
            {
                //Authorise login details (Extra layer of protection)
                if (login.a == U.saleslogin && login.b == U.salespass || login.a == U.adminlogin && login.b == U.adminpass)
                {

                    Checkout f3 = new Checkout(ListItemsFinal);

                    f3.Show();
                }
                
            }
        }
        //Button to create new user login object "Change User"
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f = new login();

            f.Show();
        }
    }
   
}
