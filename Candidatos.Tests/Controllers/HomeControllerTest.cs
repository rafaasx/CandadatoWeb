using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Candidatos;
using Candidatos.Controllers;
using Candidatos.Models;

namespace Candidatos.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void HomeControllerIndex()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Candidatos", result.ViewBag.Title);
        }
    }
}