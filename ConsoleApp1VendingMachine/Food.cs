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
            throw new NotImplementedException();
        }

        public override void Use()
        {
            Console.WriteLine("Eat the Snack");
        }
    }
}
