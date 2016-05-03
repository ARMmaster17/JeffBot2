using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JeffBot2BAPI;
using JeffBot2BAPI.Controllers;

namespace JeffBot2BAPI.Tests.Controllers
{
    [TestClass]
    public class BuildControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            BuildController controller = new BuildController();

            // Act
            string result = controller.Get("Hello");

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void Post()
        {
            // Arrange
            BuildController controller = new BuildController();

            // Act
            string result = controller.Post("Hello");

            // Assert
        }
    }
}
