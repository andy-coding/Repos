using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABProj.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void UpdateUserTest()
        {
            //Arrange
            var currentUser = new User("bob","harris");
            var expected = "Mary Blige was created.";

            //Act
            var actual = currentUser.UpdateUser("Mary", "Blige");


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}