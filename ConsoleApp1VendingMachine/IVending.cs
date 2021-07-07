using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1VendingMachine
{
    public interface IVending
    {
        decimal Purchase(string ID);
        void ShowAll();
        //int to decimal
        decimal InsertMoney(int coin);
        void EndTransaction();
    }
}
