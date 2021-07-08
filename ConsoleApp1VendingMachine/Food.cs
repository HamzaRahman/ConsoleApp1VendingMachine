using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1VendingMachine
{
    public class Food : Product
    {
        public Food(string productName, decimal price) : base(productName, price)
        {

        }
        public override string Examine()
        {
            string message = (Convert.ToString(this.ProductPrice) + " | " + this.ProductName);
            Console.WriteLine(message);
            return message;
        }

        public override string Use()
        {
            string message = "Eat the Snack";
            Console.WriteLine(message);
            return message;
        }
    }
}
