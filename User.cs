using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TheComfortZone
{
    //This is the class for all the users, admin and sales staff would be heritance? 
    public class UserClass 
    {
        public string adminlogin, adminpass, saleslogin, salespass;
        public void getdata()
        {
            
        TextReader tr;

            using (tr = new StreamReader(@"users.txt"))
            {
                adminlogin = tr.ReadLine();
                adminpass = tr.ReadLine();
                saleslogin = tr.ReadLine();
                salespass = tr.ReadLine();
            }
        }
       
    }



}

    




