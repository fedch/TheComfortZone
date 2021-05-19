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
        

        

        public menu()
        {
            InitializeComponent();
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

                    Admin f2 = new Admin();

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

                    Checkout f3 = new Checkout();

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
