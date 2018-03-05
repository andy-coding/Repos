using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpdesk_API_Integration;
using Helpdesk_API_Integration.Controllers;

namespace Helpdesk_API_Integration.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTest
    {
        [TestMethod()]
        public void GetCategoriesTest()
        {
            Assert.Fail();
        }
    }
}

namespace Helpdesk_API_Integration.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetCategories()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            //ViewResult result = controller.GetCategories() as ViewResult;
            //Console.WriteLine("CategoryResponse=" + CategoryResponse);

            // Assert
            //Assert.IsNotNull(result);
        }
        
    }
}
