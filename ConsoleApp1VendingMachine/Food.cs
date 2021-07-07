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
        public override void Examine()
        {
            
            Console.WriteLine(Convert.ToString(this.ProductPrice),this.ProductName);
        }

        public override void Use()
        {
            Console.WriteLine("Eat the Snack");
        }
    }
}
