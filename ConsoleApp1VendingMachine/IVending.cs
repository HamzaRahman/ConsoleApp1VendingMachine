using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1VendingMachine
{
    public interface IVending
    {
        void Purchase();
        void ShowAll();
        int InsertMoney(int coin);
        void EndTransaction();
    }
}
