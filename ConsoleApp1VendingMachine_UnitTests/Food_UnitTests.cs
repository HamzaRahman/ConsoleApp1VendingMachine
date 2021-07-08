using ConsoleApp1VendingMachine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleApp1VendingMachine_UnitTests
{
    public class Food_UnitTests
    {
        Product Food = new Food("--", 5);
        [Fact]
        public void UseTest()
        {
            string use = Food.Use();
            Assert.Equal("Eat the Snack", use);
        }
        [Fact]
        public void ExamineTest()
        {
            string use = Food.Examine();
            Assert.Equal("5 | --", use);
        }
    }
}
