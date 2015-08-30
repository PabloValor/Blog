using System;
using NUnit.Framework;
using Blog.Controllers;

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

            // Act

            // Assert
        }
    }
}
