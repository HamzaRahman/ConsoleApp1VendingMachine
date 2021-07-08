using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1VendingMachine;
using Xunit;

namespace ConsoleApp1VendingMachine_UnitTests
{
    public class Product_UnitTests
    {
        
        
        
        
        Product_Mock PUT = new Product_Mock("Test", 5);
        [Fact]
        public void UseTest()
        {
            string use = PUT.Use();
            Assert.Equal("Product Class Unit Test Succesful", use);
        }
        [Fact]
        public void ExamineTest()
        {
            string use = PUT.Examine();
            Assert.Equal("5 | Test", use);
        }
    }
}
