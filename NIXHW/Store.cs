using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIXHW
{
    public class Store
    {
        public void Buy(User user, Product product)
        {
            double price = product.GetDiscount(user);
            user.ReduceBalance(price);
            Console.WriteLine($"{user.Name} bought {product.Name} for ${price}");
        }
    }
}
