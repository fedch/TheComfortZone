using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
//Timur's Part
namespace TheComfortZone
{
    //This is the class for all the users, admin and sales staff  
    public class UserClass 
    {
        public string adminlogin, adminpass, saleslogin, salespass;

        //Function to get data from txt file
        public void getdata()
        {
            
        TextReader tr;
            //read file
            using (tr = new StreamReader(@"users.txt"))
            {
                //read each line and apply to string
                adminlogin = tr.ReadLine();
                adminpass = tr.ReadLine();
                saleslogin = tr.ReadLine();
                salespass = tr.ReadLine();
            }
        }
       
    }



}

    




