using System;
using CityCM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CITYCM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Donald",
                LastName = "Duck"
            };
            string expected = "Duck, Donald";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "Donald"
            };
            string expected = "Donald";

            string actual = customer.FullName;

            Assert.AreEqual(actual, expected);
        }
    }
}
