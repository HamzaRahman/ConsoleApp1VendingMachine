using ConsoleApp1VendingMachine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleApp1VendingMachine_UnitTests
{
    public class Toy_UnitTests
    {
        Product Toy = new Toy("--", 5);
        [Fact]
        public void UseTest()
        {
            string use = Toy.Use();
            Assert.Equal("Play with Toy", use);
        }
        [Fact]
        public void ExamineTest()
        {
            string use = Toy.Examine();
            Assert.Equal("5 | --", use);
        }
    }
}
