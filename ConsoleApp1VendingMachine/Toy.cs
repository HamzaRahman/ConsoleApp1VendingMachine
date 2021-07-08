using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1VendingMachine
{
    public class Toy : Product
    {
        public Toy(string productName, decimal price) : base(productName, price)
        {

        }
        public override string Examine()
        {
            string message = (Convert.ToString(this.ProductPrice)+" | "+ this.ProductName);
            Console.WriteLine(message);
            return message;
        }

        public override string Use()
        {
            string message = "Play with Toy";
            Console.WriteLine(message);
            return message;
        }
    }
}
