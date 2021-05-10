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
        
        List <string> users= new List<string>();
        List<string> passwords = new List<string>();
        private void login_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("users.txt");
            string line = "";
            while ((line = sr.ReadLine())!=null) {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                passwords.Add(components[1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (users.Contains(textBox1.Text) && passwords.Contains(textBox2.Text) && Array.IndexOf(users.ToArray(), textBox1.Text) == Array.IndexOf(passwords.ToArray(), textBox2.Text)){
                menu m = new menu();
                m.ShowDialog();

            }
            else
                MessageBox.Show("The username and/or password is incorrect");
        }
    }
}
