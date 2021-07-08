using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1VendingMachine
{
    //Setting to public
    public class VendingMachine : IVending
    {
        //int to decimal
        public static decimal moneypool = 0;
        Dictionary<string, Product> Products = new Dictionary<string, Product>()
        {{"P1",new Drink("CocaCola",5)},
         {"P2",new Drink("Pepsi",5)},
         {"P3",new Drink("Mirinda",5)},
         {"P4",new Drink("Sprite",5)},

         {"P5",new Food("Chocolate",5.4M)},
         {"P6",new Food("Chips",3.77M)},

         {"P7",new Toy("Car",5.4M)},
         {"P8",new Toy("Doll",5.4M)},
        };
        readonly int[] MoneyDenominations = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public decimal Purchase(string ID)
        {
            if(Products.ContainsKey(ID))
            {
                if(moneypool >= Products[ID].ProductPrice)
                {
                    Products[ID].Use();
                    moneypool = moneypool - Products[ID].ProductPrice;
                }
                else
                {
                    Console.WriteLine("Not Enough Money, Please Add More Money");
                }
            }
            else
            {
                Console.WriteLine("InValid Choice, Try Again");
            }
            return moneypool;
        }
        //int to decimal
        public decimal InsertMoney(int coin)
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
                string price = kvp.Value.ProductPrice.ToString().PadLeft(7);
                Console.WriteLine($"{itemNumber} {productName} Costs: {price}kr each");
            }
        }

        public Dictionary<string, decimal> EndTransaction()
        {
            Dictionary<string, decimal> Change = new Dictionary<string, decimal>();
            int kr = 0;
            int ore = 0;
            if (moneypool > 0)
            {
                while (moneypool > 0)
                {
                    if (moneypool >= 1)
                    {
                        kr++;
                        moneypool = moneypool - 1;
                    }
                    else if (moneypool >= 0.10M)
                    {
                        ore = ore+10;
                        moneypool = moneypool - 0.10M;
                    }
                    else if (moneypool >= 0.01M)
                    {
                        ore++;
                        moneypool = moneypool - 0.01M;
                    }
                }
                Change.Add("kr", kr);
                Change.Add("ore", ore);
                Console.WriteLine("Here's Your Change: {0}kr {1}ores",kr,ore);
            }
            else
            {
                Console.WriteLine("No money to return");
            }
            return Change;
        }
        public void Examine(string ID)
        {
            if (Products.ContainsKey(ID))
            {
                Console.WriteLine("Price:{0}kr Name:{1}",Convert.ToString(Products[ID].ProductPrice), Products[ID].ProductName);
            }
            else
            {
                Console.WriteLine("InValid ID.");
            }
        }

        
    }
}
