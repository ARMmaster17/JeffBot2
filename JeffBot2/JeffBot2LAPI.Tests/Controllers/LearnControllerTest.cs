using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JeffBot2LAPI;
using JeffBot2LAPI.Controllers;

namespace JeffBot2LAPI.Tests.Controllers
{
    [TestClass]
    public class LearnControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            LearnController controller = new LearnController();

            // Act
            string result = controller.Get("Test");

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            LearnController controller = new LearnController();

            // Act
            controller.Post("value");

            // Assert
        }
    }
}
