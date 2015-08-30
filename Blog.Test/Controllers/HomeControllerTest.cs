using System;
using NUnit.Framework;
using Blog.Controllers;
using Moq;
using Aplication.Abstractions;
using System.Web.Mvc;

namespace Blog.Test
{
    [TestFixture]
    public class HomeControllerTest
    {
        /// <summary>
        /// Test for action methods from HomeController
        /// </summary>
        [Test]
        public void ReturnIndexWhenIndexActionIsCalled()
        {
            // Arrange
            const string viewNameExpected = "Index";
            Mock<IHomeService> homeServiceMock = new Mock<IHomeService>();
            Mock<HomeController> HomeControllerMock = new Mock<HomeController>(homeServiceMock.Object);
            HomeController controller = HomeControllerMock.Object;  

            // Act
            var result = (ViewResult)controller.Index();

            // Assert
            Assert.AreEqual(viewNameExpected, result); 
        }
    }
}
