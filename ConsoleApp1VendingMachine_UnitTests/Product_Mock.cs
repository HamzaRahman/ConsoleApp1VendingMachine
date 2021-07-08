using ConsoleApp1VendingMachine;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1VendingMachine_UnitTests
{
    public class Product_Mock : Product
    {
        public Product_Mock(string productName, decimal price) : base(productName, price)
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
            string message = "Product Class Unit Test Succesful";
            Console.WriteLine(message);
            return message;
        }
    }
}
