using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Candidatos.Models
{
    public class CandidatoModels
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        public int Html { get; set; }
        public int Css { get; set; }
        public int Javascript { get; set; }
        public int Python { get; set; }
        public int Django { get; set; }
        public int Ios { get; set; }
        public int Android { get; set; }
        public bool FrontEnd { get; set; }
        public bool BackEnd { get; set; }
        public bool Mobile { get; set; }
        public bool Programador { get; set; }
    }
}