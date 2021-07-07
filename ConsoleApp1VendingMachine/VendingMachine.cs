﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1VendingMachine
{
    class VendingMachine : IVending
    {
        //int to decimal
        static decimal moneypool = 0;
        Dictionary<string, Product> Products = new Dictionary<string, Product>()
        {{"P1",new Drink("CocaCola",5)},
         {"P2",new Drink("Pepsi",5)},
         {"P3",new Drink("Mirinda",5)},
         {"P4",new Drink("Sprite",5)},

         {"P5",new Food("Chocolate",5)},
         {"P6",new Food("Chips",5)}
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

        public void EndTransaction()
        {
            throw new NotImplementedException();
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
