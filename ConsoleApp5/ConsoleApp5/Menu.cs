using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Menu
    {
        public string FoodName { get; set; }
        public int FoodId { get; set; }
        public double FoodPrice { get; set; }
        public double FinalPrice
        {
            get { return FoodPrice + Gst; }
        }
        public double Gst
        {
            get { return (15 / 100) * FoodPrice; }
        }

        public Menu(string _foodname, int _foodid, double _foodprice)
        {
            FoodName = _foodname;
            FoodId = _foodid;
            FoodPrice = _foodprice;
        }
   
    }
}
