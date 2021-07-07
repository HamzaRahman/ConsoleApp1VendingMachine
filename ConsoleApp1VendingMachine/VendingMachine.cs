using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1VendingMachine
{
    class VendingMachine : IVending
    {
        static int moneypool = 0;
        readonly int[] MoneyDenominations = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public void Purchase()
        {
            
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
            throw new NotImplementedException();
        }

        public void EndTransaction()
        {
            throw new NotImplementedException();
        }

        
    }
}
