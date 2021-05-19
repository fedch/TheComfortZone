using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
//Timurs Part
namespace TheComfortZone
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        
        public static string a, b;
        public void login_Load(object sender, EventArgs e)
        {
           

        }

        //Authorise user once the login button is clicked
        public void button1_Click(object sender, EventArgs e)
        {
            UserClass U = new UserClass();
            U.getdata();
            a = tbUserId.Text;
            b = tbUserPass.Text;
            //if admin authorised, open menu
            if (a == U.adminlogin && b == U.adminpass)
            {
                this.Hide();
                menu W = new menu();
                //Greet Admin
                MessageBox.Show("Welcome Admin!");
                W.Show();
            }
            //if sales authorised, open menu
            else if (a == U.saleslogin && b == U.salespass)
            {
                this.Hide();
                menu W = new menu();
                //Greet Sales Staff
                MessageBox.Show("Welcome Salesman!");
                W.Show();
            }
            //If there's no input in textbox
            else if (a == "" || b == "")
            {
                //Display error message
                MessageBox.Show("User id or password is missing");

            }
            //if input is incorrect
            else if (a != U.saleslogin || b != U.salespass)
            {
                //display error message
                MessageBox.Show("Invalid ID or Password");

            }
        }
    }
}

