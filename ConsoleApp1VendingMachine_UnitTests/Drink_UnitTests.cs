using ConsoleApp1VendingMachine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleApp1VendingMachine_UnitTests
{
    public class Drink_UnitTests
    {
        Product Drink = new Drink("--", 5);
        [Fact]
        public void UseTest()
        {
            string use = Drink.Use();
            Assert.Equal("Drink the Drink", use);
        }
        [Fact]
        public void ExamineTest()
        {
            string use = Drink.Examine();
            Assert.Equal("5 | --", use);
        }
    }
}
