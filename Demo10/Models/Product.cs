using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10.Models
{
    public class Product
    {
        string name;
        int price;
        int quantity;
        public string GetInfo(string name)
        {
            return name;




        }
        public string GetInfo(string name, int price)
        {

            return name + ", price " + price;

        }


        public string GetInfo(string name , int price , int quantity)
        {
         
            return "Name: "+ name + " price, " + price +"Qty "+ quantity;



        }
    }
}
