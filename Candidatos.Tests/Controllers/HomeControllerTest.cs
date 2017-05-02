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
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }

        [TestMethod]
        public void ValidarEnvioCorreto()
        {
            
            CandidatoModels Candidato = new CandidatoModels
            {
                Nome = "Rafael Xavier",
                Email = "rafaeltwisted@gmail.com",
                Css = 5,
                Html = 5,
                Javascript = 8,
                Android = 1,
                Django = 9,
                Ios = 5,
                Python = 3
            };
            HomeController controller = new HomeController();
            controller.ViewData.ModelState.Clear();
            var ret = controller.Enviar(Candidato);

            Assert.IsTrue(controller.ViewData.ModelState.Count == 0);
        }

        [TestMethod]
        public void ValidarEnvioSemNome()
        {

            CandidatoModels Candidato = new CandidatoModels
            {
                Email = "rafaeltwisted@gmail.com",
                Css = 5,
                Html = 5,
                Javascript = 8,
                Android = 1,
                Django = 9,
                Ios = 5,
                Python = 3
            };
            HomeController controller = new HomeController();
            controller.ViewData.ModelState.Clear();
            var ret = controller.Enviar(Candidato);

            Assert.IsTrue(controller.ViewData.ModelState.Count == 0);
        }
    }
}