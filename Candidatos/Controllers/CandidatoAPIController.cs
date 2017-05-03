using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Candidatos.Models;
using Candidatos.Core;
using Candidatos.Core.Util;

namespace Candidatos.Controllers
{
    public class CandidatoController : ApiController
    {
        /// <summary>
        /// Post
        /// </summary>
        /// <param name="model">Candidato</param>
        /// <returns></returns>
        [ResponseType(typeof(CandidatoModels))]
        public IHttpActionResult PostCandidato(CandidatoModels model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {

                if (string.IsNullOrEmpty(model.Nome))
                    throw new Exception("Nome não pode ser nulo.");
                if (string.IsNullOrEmpty(model.Email) || !Regex.IsMatch(model.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                    throw new Exception("E-mail não pode ser nulo ou inválido.");

                Mail mail = new Mail { Destinatario = model.Email, Assunto = "Obrigado por se candidatar!" };

                const int media = 7;
                if (model.Html >= media || model.Css >= media ||
                    model.Javascript >= media)
                {
                    mail.Body = string.Format("Olá {0}. <br><br>Obrigado por se candidatar, assim que tivermos uma vaga disponível" +
                        " para {1} entraremos em contato.", model.Nome, "programador Front - End");
                    mail.Enviar();
                    model.FrontEnd = true;
                }
                if (model.Python >= media || model.Django >= media)
                {
                    mail.Body = string.Format("Olá {0}. <br><br>Obrigado por se candidatar, assim que tivermos uma vaga disponível" +
                    " para {1} entraremos em contato.", model.Nome, "programador Back - End");
                    mail.Enviar();
                    model.BackEnd = true;
                }
                if (model.Android >= media || model.Ios >= media)
                {
                    mail.Body = string.Format("Olá {0}. <br><br>Obrigado por se candidatar, assim que tivermos uma vaga disponível" +
                    " para {1} entraremos em contato.", model.Nome, "programador Mobile");
                    mail.Enviar();
                    model.Mobile = true;
                }
                if (model.Html < media && model.Css < media && model.Javascript < media &&
                    model.Android < media && model.Ios < media && model.Python < media &&
                    model.Django < media)
                {
                    mail.Body = string.Format("Olá {0}. <br><br>Obrigado por se candidatar, assim que tivermos uma vaga disponível" +
                    " para {1} entraremos em contato.", model.Nome, "programador");
                    mail.Enviar();
                    model.Programador = true;
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(model);
        }
    }
}
