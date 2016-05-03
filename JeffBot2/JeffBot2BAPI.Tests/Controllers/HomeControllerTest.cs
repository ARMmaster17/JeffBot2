using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JeffBot2BAPI;
using JeffBot2BAPI.Controllers;

namespace JeffBot2BAPI.Tests.Controllers
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
