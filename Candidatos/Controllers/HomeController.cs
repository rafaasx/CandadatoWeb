using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Candidatos.Models;
using Newtonsoft.Json;

namespace Candidatos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        [System.Web.Mvc.HttpPost]
        public ActionResult Enviar(CandidatoModels pCandidatoInfo)
        {
            if (ModelState.IsValid)
            {
                //CandidatoBLL candidatoBLL = new CandidatoBLL();
                //Retorno retorno = candidatoBLL.Enviar(pCandidatoInfo);
            }

            return View(pCandidatoInfo);
        }
    }
}
