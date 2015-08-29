using System;
using NUnit.Framework;
using Blog.Controllers;

namespace Blog.Test
{
    [TestFixture]
    public class BlogTest
    {
        /// <summary>
        /// Test for action methods from HomeController
        /// </summary>
        [Test]
        public void TestHomeController()
        {
            int number = 2;

            Assert.AreEqual(2, number);
        }
    }
}
