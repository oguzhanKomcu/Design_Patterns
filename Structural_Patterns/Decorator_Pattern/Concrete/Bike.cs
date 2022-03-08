using Decorator_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Concrete
{
    public class Bike : IAdditional_Feature
    {


        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }


        public void AddDescription(string desc)
        {
            Description = "Model: " + Model + " Brand: " + Brand + " Current Price: " + Price.ToString() + " " + desc;
        }



        public void PrintDetail()
        {
            Console.WriteLine(Description);
        }

        public void AddPrice(decimal price)
        {
            Price = Price+price;
        }
    }
}

        
