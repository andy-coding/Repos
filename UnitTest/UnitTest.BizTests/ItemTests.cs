using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Tests
{
    [TestClass()]
    public class ItemTests
    {
        [TestMethod()]
        public void MyMethodTest()
        {
            // Arrange
            var currentItem = new Item();
            currentItem.ItemName = "Item1";
            currentItem.ItemId = 2;
            var expected = "Boo Item1 2";

            // Act
            var actual = currentItem.MyMethod();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}