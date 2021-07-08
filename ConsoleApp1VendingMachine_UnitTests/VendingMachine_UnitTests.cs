using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1VendingMachine;
using Xunit;

namespace ConsoleApp1VendingMachine_UnitTests
{
    public class VendingMachine_UnitTests
    {
        VendingMachine VM = new VendingMachine();
        //Check if item gets purchased by checking if price according to that item is charged.
        [Theory]
        [InlineData("P6")]
        public void PurchaseAndRemainingMoneyTest(string ID)
        {
            VM.InsertMoney(10);
            decimal RemainingMoney = VM.Purchase(ID);
            Assert.Equal(6.23M, RemainingMoney);
            VendingMachine.moneypool = 0;
        }
        [Theory]
        [InlineData(5)]
        public void InsertMoneyTest(int coin)
        {
            decimal addedmoney = VM.InsertMoney(coin);
            Assert.Equal(5, addedmoney);
            VendingMachine.moneypool = 0;
        }
        [Theory]
        [InlineData("P6")]
        public void ReturnRemainingMoneyTest(string ID)
        {
            VM.InsertMoney(10);
            VM.Purchase(ID);
            var RemainingMoney = VM.EndTransaction();
            Assert.Equal(6, RemainingMoney["kr"]);
            Assert.Equal(23, RemainingMoney["ore"]);
            VendingMachine.moneypool = 0;
        }
    }
}
