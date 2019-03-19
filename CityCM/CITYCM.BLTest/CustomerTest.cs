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

        [TestMethod]
         public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Julius";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Brutus";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Maximus";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
