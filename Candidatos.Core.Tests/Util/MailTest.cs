using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Candidatos.Core.Util;
namespace Candidatos.Core.Tests
{
    [TestClass]
    public class MailTest
    {
       

        [TestMethod]
        public void EnviarEmailSemAssunto()
        {
            try
            {
                Mail mail = new Mail { Body = "Body", Destinatario = "rafaeltwisted@gmail.com" };
                mail.Enviar();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Assunto do e-mail não informado.", e.Message);
            }
        }

        [TestMethod]
        public void EnviarEmailSemBody()
        {
            try
            {
                Mail mail = new Mail { Assunto = "Assunto", Destinatario = "rafaeltwisted@gmail.com" };
                mail.Enviar();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Corpo do e-mail não informado.", e.Message);
            }
        }

        [TestMethod]
        public void EnviarEmailSemDestinatario()
        {
            try
            {
                Mail mail = new Mail { Assunto = "Assunto", Body = "Body"};
                mail.Enviar();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Destinatário não informado.", e.Message);
            }
        }

        [TestMethod]
        public void EnviarEmailSemSmtpConfigurado()
        {
            ConfigurationSettings.AppSettings["MailConfiguration"] = "";
            try
            {
                Mail mail = new Mail { Assunto = "Assunto", Body = "Body", Destinatario = "rafaeltwisted@gmail.com" };
                mail.Enviar();
            }
            catch (Exception e)
            {
                Assert.AreEqual("E-mail de envio não configurado.", e.Message);
            }
        }
    }
}
