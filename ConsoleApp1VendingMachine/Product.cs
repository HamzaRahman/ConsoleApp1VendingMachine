using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1VendingMachine
{
    public abstract class Product
    {

        string productName;
        decimal productPrice;
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }
        public decimal ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                productPrice = value;
            }
        }

        public Product(string productName, decimal price)
        {
            this.ProductName = productName;
            this.ProductPrice = price;
        }
        public abstract void Examine();
        public abstract void Use();
    }
}
