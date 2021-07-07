using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1VendingMachine
{
    public abstract class Product
    {

        string ProductName;
        decimal ProductPrice;
        public Product(string productName, decimal price)
        {
            this.ProductName = productName;
            this.ProductPrice = price;
        }
        public abstract void Examine();
        public abstract void Use();
    }
}
