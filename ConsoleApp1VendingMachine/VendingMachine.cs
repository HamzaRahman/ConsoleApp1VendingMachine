using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1VendingMachine
{
    class VendingMachine : IVending
    {
        static int moneypool = 0;
        Dictionary<string, Product> Products = new Dictionary<string, Product>()
        {{"P1",new Drink("CocaCola",5)},
         {"P2",new Drink("Pepsi",5)},
         {"P3",new Drink("Mirinda",5)},
         {"P4",new Drink("Sprite",5)},
        };
        readonly int[] MoneyDenominations = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public void Purchase(string ID)
        {
            foreach (KeyValuePair<string, Product> kvp in this.Products)
            {
                if(kvp.Key==ID && moneypool >= kvp.Value.ProductPrice)
                {
                    kvp.Value.Use();
                }
            }
        }

        public int InsertMoney(int coin)
        {
            bool valid = true;
            
            foreach(var c in MoneyDenominations)
            {
                if(c==coin)
                {
                    valid = true;
                    break;
                }
                else
                {
                    valid = false;
                }
            }
            if(!valid)
            {
                Console.WriteLine("Invalid Ammount/Coin, Enter a valid Money Denomination");
            }
            else
            {
                moneypool = moneypool + coin;
            }
            return moneypool;
        }

        public void ShowAll()
        {
            Console.WriteLine($"{"#".PadRight(6)}{ "Product".PadRight(8) } { "Price".PadLeft(7)}");
            foreach (KeyValuePair<string, Product> kvp in this.Products)
            {
                string itemNumber = kvp.Key.PadRight(5);
                string productName = kvp.Value.ProductName.ToString().PadRight(10);
                string price = kvp.Value.ProductPrice.ToString("C").PadLeft(7);
                Console.WriteLine($"{itemNumber} {productName} Costs: {price} each");
            }
        }

        public void EndTransaction()
        {
            throw new NotImplementedException();
        }

        
    }
}
