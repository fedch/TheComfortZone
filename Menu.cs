using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections;

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
    

        

        private void button1_Click(object sender, EventArgs e)
        {
            login L = new login();
            UserClass U = new UserClass();
            U.getdata();
            {

                if (login.a == U.adminlogin && login.b == U.adminpass)
                {

                    Admin f2 = new Admin();

                    f2.Show();
                }
                
                else if (login.a != U.adminlogin || login.b != U.adminpass)
                {
                    MessageBox.Show("Access Denied.");

                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            login L = new login();
            UserClass U = new UserClass();
            U.getdata();
            {

                if (login.a == U.saleslogin && login.b == U.salespass || login.a == U.adminlogin && login.b == U.adminpass)
                {

                    Checkout f3 = new Checkout();

                    f3.Show();
                }
                
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            login f = new login();

            f.Show();
        }
    }
   
}
