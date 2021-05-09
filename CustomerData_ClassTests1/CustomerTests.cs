// Create a C# application that calculates and displays electricity bills for unique customers with the following data: administrative charge $12 and a charge of $0.07 for each kWh used.
// April 28, 2021; Ceti Zyko

// Project "CustomerData_ClassTest" - Project file that contains tests for CalculateBillTotal (CalculateCharge) in CustomerData_Class (Customer) class. All tests are correct, and passed.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;
using System;
using System.Collections.Generic;
using System.Text;



namespace lab2.Tests
{
    [TestClass()]
    public class CustomerTests // Class that contains tests for TotalBillTest (CalculateCharge) in CustomerData_Class (Customer class), tests are correct, and all tests pass
    {
        [TestMethod()] // Test - the total Bill is calculated correctly after the inputs are enetered in.
        public void CalculateBillTotalTest()
        {

            // Arrange

            decimal inputkWh = 100m;
            decimal totalBill = 19m;
            Customer c = new Customer();


            // Action
            var result = c.CalculateBillTotal(inputkWh);


            // Assert

            Assert.AreEqual(totalBill, result);
        }

        [TestMethod()] // Test1 - the admin charge is $12 while 0 kWh is consumed.
        public void CalculateBillTotalTest1()
        {
            // Arrange

            decimal inputkWh = 0m;
            decimal totalBill = 12m;
            Customer c = new Customer();


            // Action
            var result = c.CalculateBillTotal(inputkWh);


            // Assert

            Assert.AreEqual(totalBill, result);
        }

        [TestMethod()] // Test2 - the total Bill is calculated correctly after the input kWh is enetered a negative value.
        public void CalculateBillTotalTest2()
        {

            // Arrange

            decimal inputkWh = -100m;
            decimal totalBill = 5m;
            Customer c = new Customer();


            // Action
            var result = c.CalculateBillTotal(inputkWh);


            // Assert

            Assert.AreEqual(totalBill, result);
        }
    }
}



