using System;
using Candidatos.Core.Util;

namespace Candidatos.Core.BLL
{
    public class CandidatoBLL
    {
        /// <summary>
        /// Enviar e-mail para o candidato
        /// </summary>
        /// <param name="pCandidato"></param>
        /// <returns></returns>
        //public void Enviar(CandidatoModels pCandidato)
        //{
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(pCandidato?.Nome) && !string.IsNullOrEmpty(pCandidato?.Email))
        //        {
        //            Mail mail = new Mail { EmailPara = pCandidato.Email, Assunto = "Obrigado por se candidatar!" };
        //            const int media = 7;
        //            if (pCandidato.Html >= media || pCandidato.Css >= media ||
        //                pCandidato.Javascript >= media)
        //            {
        //                mail.Body = Body(pCandidato.Nome, "programador Front - End");
        //                mail.Enviar();
        //            }
        //            if (pCandidato.Python >= media || pCandidato.Django >= media)
        //            {
        //                mail.Body = Body(pCandidato.Nome, "programador Back - End");
        //                mail.Enviar();
        //            }
        //            if (pCandidato.Android >= media || pCandidato.Ios >= media)
        //            {
        //                mail.Body = Body(pCandidato.Nome, "programador Mobile");
        //                mail.Enviar();
        //            }
        //            if (pCandidato.Html < media && pCandidato.Css < media && pCandidato.Javascript < media &&
        //                pCandidato.Android < media && pCandidato.Ios < media && pCandidato.Python < media &&
        //                pCandidato.Django < media)
        //            {
        //                mail.Body = Body(pCandidato.Nome, "programador");
        //                mail.Enviar();
        //            }
        //            //return new Retorno(true, string.Format("Obrigado {0}.<br><br>Enviamos um e-mail para {1} confirmando sua candidatura.",
        //            //    pCandidato.Nome, pCandidato.Email));
        //        }
        //        else
        //        {
        //            throw new Exception("É obrigatório informar o nome e e-mail do candidato.");
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception();
        //        //return new Retorno(false, string.Format("Ops! Tivemos um problema com sua candidatura :( <br>Tente novamente mais tarde.<br><br>{0}", e.Message));
        //    }

        //}

        private string Mensagem(string pNome, string pFuncao)
        {
            return string.Format("Olá {0}. <br><br>Obrigado por se candidatar, assim que tivermos uma vaga disponível" +
                            " para {1} entraremos em contato.", pNome, pFuncao);
        }
    }
}
