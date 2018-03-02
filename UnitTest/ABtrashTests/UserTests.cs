using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABtrash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABtrash.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void FullNameTest()
        {
            //Arrange
            var currentUser = new User();
            currentUser.FirstName = " Harry";
            currentUser.LastName = "Munchkin";
            var expected = "Harry Munchkin";


            //Act
            var actual = currentUser.FullName();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}