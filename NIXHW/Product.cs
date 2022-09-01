using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIXHW
{
    public class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public double GetDiscount(User user)
        {
            if (user.Spent < 300)
            {
                return Price;
            }
            if (user.Spent < 1000)
            {
                return Price * 0.9;
            }
            return Price * 0.8;
        }
    }
}
