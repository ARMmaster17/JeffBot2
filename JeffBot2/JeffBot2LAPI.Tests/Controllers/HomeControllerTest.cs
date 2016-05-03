using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JeffBot2LAPI;
using JeffBot2LAPI.Controllers;

namespace JeffBot2LAPI.Tests.Controllers
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
            string result = controller.Index();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
