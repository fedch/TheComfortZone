using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

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

        public void button1_Click(object sender, EventArgs e)
        {
            UserClass U = new UserClass();
            U.getdata();
            a = tbUserId.Text;
            b = tbUserPass.Text;
            if (a == U.saleslogin && b == U.salespass || a == U.adminlogin && b == U.adminpass)
            {

                menu W = new menu();

                W.Show();
            }
            else if (a == "" || b == "")
            {
                MessageBox.Show("User id or password is missing");

            }
            else if (a != U.saleslogin || b != U.salespass)
            {
                MessageBox.Show("Invalid ID or Password");

            }
        }
    }
}

