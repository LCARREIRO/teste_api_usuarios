using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TesteListagemDeUsuarios.Dominio.Entidade
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
