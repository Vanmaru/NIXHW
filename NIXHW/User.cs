using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIXHW
{
    public class User
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public double Spent { get; set; }
        public User(string name, double balance, double spent)
        {
            Name = name;
            Balance = balance;
            Spent = spent;
        }
        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }
    }
}
