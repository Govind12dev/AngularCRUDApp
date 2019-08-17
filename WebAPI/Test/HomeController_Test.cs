using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Controllers;

namespace WebAPI.Test
{
    [TestFixture]
    public class HomeController_Test
    {
        HomeController homeController = new HomeController();

        [Test]
        public void Index_Test()
        {
            var result = homeController.Index();
            Assert.IsNotNull(result);
        }
    }
}