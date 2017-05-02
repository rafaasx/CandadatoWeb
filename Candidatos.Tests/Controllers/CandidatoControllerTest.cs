using System;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using Candidatos.Controllers;
using Candidatos.Core.Util;
using Candidatos.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Candidatos.Tests.Controllers
{
    [TestClass]
    public class CandidatoControllerTest
    {

        [TestMethod]
        public void EnviarCandidatoSemNome()
        {
            CandidatoModels candidato = new CandidatoModels
            {
                Email = "rafaeltwisted@gmail.com",
                Css = 5,
                Html = 5,
                Javascript = 8
            };
            CandidatoController controller = new CandidatoController();
            controller.ModelState.Clear();
            IHttpActionResult result = controller.PostCandidato(candidato);
            BadRequestErrorMessageResult badRequestErrorMessageResult = result as BadRequestErrorMessageResult;
            Assert.IsNotNull(badRequestErrorMessageResult);
            Assert.AreEqual("Nome é obrigatório", badRequestErrorMessageResult.Message);
        }

        [TestMethod]
        public void EnviarCandidato()
        {
            CandidatoModels candidato = new CandidatoModels
            {
                Nome = "Rafael Xavier",
                Email = "rafaeltwisted@gmail.com",
                Css = 5,
                Html = 5,
                Javascript = 8
            };
            CandidatoController controller = new CandidatoController();
            controller.ModelState.Clear();
            IHttpActionResult result = controller.PostCandidato(candidato);
            OkNegotiatedContentResult<CandidatoModels> okNegotiatedContentResult = result as OkNegotiatedContentResult<CandidatoModels>;
            Assert.IsNotNull(okNegotiatedContentResult);
            Assert.AreEqual(candidato.Nome, okNegotiatedContentResult.Content.Nome);
            Assert.AreEqual(candidato.Android, okNegotiatedContentResult.Content.Android);
            Assert.AreEqual(candidato.Css, okNegotiatedContentResult.Content.Css);
            Assert.AreEqual(candidato.Django, okNegotiatedContentResult.Content.Django);
            Assert.AreEqual(candidato.Email, okNegotiatedContentResult.Content.Email);
            Assert.AreEqual(candidato.Html, okNegotiatedContentResult.Content.Html);
            Assert.AreEqual(candidato.Ios, okNegotiatedContentResult.Content.Ios);
            Assert.AreEqual(candidato.Javascript, okNegotiatedContentResult.Content.Javascript);
            Assert.AreEqual(candidato.Python, okNegotiatedContentResult.Content.Python);

        }

        [TestMethod]
        public void EnviarCandidatoFrontEnd()
        {
            CandidatoModels candidato = new CandidatoModels
            {
                Nome = "Rafael Xavier",
                Email = "rafaeltwisted@gmail.com",
                Css = 5,
                Html = 5,
                Javascript = 8
            };
            CandidatoController controller = new CandidatoController();
            controller.ModelState.Clear();
            IHttpActionResult result = controller.PostCandidato(candidato);
            OkNegotiatedContentResult<CandidatoModels> okNegotiatedContentResult = result as OkNegotiatedContentResult<CandidatoModels>;
            Assert.IsNotNull(okNegotiatedContentResult);
            Assert.IsTrue(candidato.FrontEnd);
            Assert.IsFalse(candidato.BackEnd);
            Assert.IsFalse(candidato.Mobile);
            Assert.IsFalse(candidato.Programador);

        }


        [TestMethod]
        public void EnviarCandidatoBackEnd()
        {
            CandidatoModels candidato = new CandidatoModels
            {
                Nome = "Rafael Xavier",
                Email = "rafaeltwisted@gmail.com",
                Django = 5,
                Python = 7
            };
            CandidatoController controller = new CandidatoController();
            controller.ModelState.Clear();
            IHttpActionResult result = controller.PostCandidato(candidato);
            OkNegotiatedContentResult<CandidatoModels> okNegotiatedContentResult = result as OkNegotiatedContentResult<CandidatoModels>;
            Assert.IsNotNull(okNegotiatedContentResult);
            Assert.IsFalse(candidato.FrontEnd);
            Assert.IsTrue(candidato.BackEnd);
            Assert.IsFalse(candidato.Mobile);
            Assert.IsFalse(candidato.Programador);

        }

        [TestMethod]
        public void EnviarCandidatoMobile()
        {
            CandidatoModels candidato = new CandidatoModels
            {
                Nome = "Rafael Xavier",
                Email = "rafaeltwisted@gmail.com",
                Ios = 9,
                Android = 0
            };
            CandidatoController controller = new CandidatoController();
            controller.ModelState.Clear();
            IHttpActionResult result = controller.PostCandidato(candidato);
            OkNegotiatedContentResult<CandidatoModels> okNegotiatedContentResult = result as OkNegotiatedContentResult<CandidatoModels>;
            Assert.IsNotNull(okNegotiatedContentResult);
            Assert.IsFalse(candidato.FrontEnd);
            Assert.IsFalse(candidato.BackEnd);
            Assert.IsTrue(candidato.Mobile);
            Assert.IsFalse(candidato.Programador);

        }

        [TestMethod]
        public void EnviarCandidatoProgramador()
        {
            CandidatoModels candidato = new CandidatoModels
            {
                Nome = "Rafael Xavier",
                Email = "rafaeltwisted@gmail.com",
                Css = 0,
                Android = 1,
                Django = 2,
                Html = 3,
                Ios = 4,
                Python = 5,
                Javascript = 6
            };
            CandidatoController controller = new CandidatoController();
            controller.ModelState.Clear();
            IHttpActionResult result = controller.PostCandidato(candidato);
            OkNegotiatedContentResult<CandidatoModels> okNegotiatedContentResult = result as OkNegotiatedContentResult<CandidatoModels>;
            Assert.IsNotNull(okNegotiatedContentResult);
            Assert.IsFalse(candidato.FrontEnd);
            Assert.IsFalse(candidato.BackEnd);
            Assert.IsFalse(candidato.Mobile);
            Assert.IsTrue(candidato.Programador);

        }

        [TestMethod]
        public void EnviarCandidatoHardcore()
        {
            CandidatoModels candidato = new CandidatoModels
            {
                Nome = "Rafael Xavier",
                Email = "rafaeltwisted@gmail.com",
                Css = 10,
                Android = 10,
                Django = 10,
                Html = 10,
                Ios = 10,
                Python = 10,
                Javascript = 10
            };
            CandidatoController controller = new CandidatoController();
            controller.ModelState.Clear();
            IHttpActionResult result = controller.PostCandidato(candidato);
            OkNegotiatedContentResult<CandidatoModels> okNegotiatedContentResult = result as OkNegotiatedContentResult<CandidatoModels>;
            Assert.IsNotNull(okNegotiatedContentResult);
            Assert.IsTrue(candidato.FrontEnd);
            Assert.IsTrue(candidato.BackEnd);
            Assert.IsTrue(candidato.Mobile);
            Assert.IsFalse(candidato.Programador);

        }
    }
}