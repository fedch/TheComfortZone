using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TheComfortZone
{
    static class Program
    {
        public static List<Item> ListItems = new List<Item>();
        [STAThread]
        static void Main()
        {
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
                    ListItems.Add(new Item(tempArray[0], tempArray[1], int.Parse(tempArray[2]), tempArray[3], decimal.Parse(tempArray[4]), decimal.Parse(tempArray[5])));
                }
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            //Application.Run(new Checkout());
        }        
    }
}
