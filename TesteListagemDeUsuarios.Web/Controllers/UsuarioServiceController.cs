using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TesteListagemDeUsuarios.Web.Models;

namespace TesteListagemDeUsuarios.Web.Controllers
{
    public class UsuarioServiceController : ApiController
    {
        private readonly UsuarioModel[] Usuarios = new UsuarioModel[]
        {
                new UsuarioModel {id = 1, first_name = "george", last_name= "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/calebogden/128.jpg" },
                new UsuarioModel {id = 2, first_name = "lucille", last_name= "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/josephstein/128.jpg" },
                new UsuarioModel {id = 3, first_name = "oscar", last_name= "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/olegpogodaev/128.jpg" },
                new UsuarioModel {id = 4, first_name = "eve", last_name= "holt", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/marcoramires/128.jpg" },
                new UsuarioModel {id = 5, first_name = "gob", last_name= "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/stephenmoon/128.jpg" },
                new UsuarioModel {id = 6, first_name = "tracey", last_name= "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/bigmancho/128.jpg" },
                new UsuarioModel {id = 7, first_name = "michael", last_name= "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/follettkyle/128.jpg" },
                new UsuarioModel {id = 8, first_name = "lindsay", last_name= "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/araa3185/128.jpg" },
                new UsuarioModel {id = 9, first_name = "tobias", last_name= "funke", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/vivekprvr/128.jpg" },
                new UsuarioModel {id = 10, first_name = "byron", last_name= "holt", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/russoedu/128.jpg" },
                new UsuarioModel {id = 11, first_name = "george michael", last_name= "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/mrmoiree/128.jpg" },
                new UsuarioModel {id = 12, first_name = "maeby", last_name= "funke", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/hebertialmeida/128.jpg" }
        };

        // GET api/usuarioservico
        public UsuarioModel[] Get()
        {
            foreach (var item in Usuarios)
            {
                int posicao = item.first_name.IndexOf(" ");

                if (posicao > 0)
                {
                    string primNome;
                    string segNome;
                    string concatenar;

                    primNome = item.first_name.Substring(0, 1).ToUpper() + item.first_name.Substring(1, posicao);
                    segNome = item.first_name.Substring(posicao + 1, 1).ToUpper() + item.first_name.Substring(posicao + 2);
                    concatenar = string.Format("{0} {1}", primNome, segNome).ToString();

                    item.first_name = concatenar;
                    item.last_name = item.last_name.Substring(0, 1).ToUpper();
                }
                else
                {
                    item.first_name = item.first_name.Substring(0, 1).ToUpper() + item.first_name.Substring(1);
                    item.last_name = item.last_name.Substring(0, 1).ToUpper();
                }
            }
            return Usuarios;
        }

        // GET api/usuarioservice/5
        public UsuarioModel Get(int id)
        {
            var usuario = Usuarios;
        
            return usuario.SingleOrDefault(x => x.id == id);
        }

        // POST api/usuarioservice
        public void Post([FromBody]string value)
        {
        }

        // PUT api/usuarioservice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/usuarioservice/5
        public void Delete(int id)
        {
        }
    }
}
