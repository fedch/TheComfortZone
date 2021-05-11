using System;
using System.Collections.Generic;
using System.Text;

namespace TheComfortZone
{
    class Item
    {
        //atributes 
        public string productName { get; set; }
        public string code { get; set; }
        public int stockLeft;
        public string color;
        public decimal price;
        public decimal discount;


        //constructor 

        public Item(string productName, string code, int stockleft , string color, decimal price, decimal discount)
        {
            this.productName = productName;
            this.code = code;
            this.stockLeft = stockleft;
            this.color = color;
            this.price = price;
            this.discount = discount; 



        }


        //methods 



        //read , edit and save the txt file 

    }
}
