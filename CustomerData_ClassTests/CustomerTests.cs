using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CalculateBillTotalTest() // It is the "CalaculateCharge" as per word docs' name
        {
            // Test for method "CalaculateCharge" in Class CustomerData

            // Arrange

            decimal inputkWh = 100m;
            decimal totalkWh = 19m;

            // Act

            var result = CalculateBillTotal(inputkWh);

            // Assert

            Assert.AreEqual(totalkWh, result);
        }
    }
}