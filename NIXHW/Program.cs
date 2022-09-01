using System;

namespace NIXHW
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new("Suasan", 9500, 500);
            Product[] products = new Product[]
            {
                new("T-shirt", 1000),
                new("Boots", 2000),
                new("Pants", 3000)
            };
            Store store = new();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Hello, {user.Name} your balance { user.Balance }");
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Toвap { i } { products[i].Name } by price { products[i].Price } ");
                }
                Console.WriteLine(" Bыберете иомер товара и нажите Enter : ");
                string str = Console.ReadLine();
                int productNumber = int.Parse(str);
                if (productNumber >= 0 && productNumber < products.Length)
                {
                    if (products[productNumber].Price < user.Balance)
                    {
                        store.Buy(user, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("Not enought money");
                    }
                }

            }
        }
    }
}