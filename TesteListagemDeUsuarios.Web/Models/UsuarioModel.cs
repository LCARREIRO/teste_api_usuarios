using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteListagemDeUsuarios.Web.Models
{
    public class UsuarioModel
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Nome")]
        public string first_name { get; set; }

        [Display(Name = "Sobrenome")]

        public string last_name { get; set; }

        [Display(Name = "Foto")]
        public string avatar { get; set; }
    }
}