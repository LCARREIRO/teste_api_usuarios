using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TesteListagemDeUsuarios.Dominio.Entidade;
using TesteListagemDeUsuarios.Dominio.Repositorio;

namespace TesteListagemDeUsuarios.Web.Controllers
{
    public class UsuarioServiceController : ApiController
    {

        private readonly UsuarioRepository repository = new UsuarioRepository();
        private readonly List<UsuarioModel> Usuarios = new List<UsuarioModel>();

        // GET api/usuarioservico
        public List<UsuarioModel> Get()
        {
            foreach (var usuario in repository.GetAll)
            {
                //Pegando usuarios do banco e passando para as propriedades do objeto usuarioObj
                var usuarioObj = new UsuarioModel
                {
                    id = usuario.id,
                    first_name = usuario.first_name,
                    last_name = usuario.last_name,
                    avatar = usuario.avatar
                };

                //Pegando a posição do espaço entre o primiro e o segundo nome
                int posicao = usuarioObj.first_name.IndexOf(" ");

                //Verifica se existe espaço em branco...
                if (posicao > 0)
                {
                    string primNome, segNome, concatenar;

                    //Torna primeira letra do primeiro nome maiuscula e depois a primeira letra do segundo nome
                    primNome = usuarioObj.first_name.Substring(0, 1).ToUpper() + usuarioObj.first_name.Substring(1, posicao);
                    segNome = usuarioObj.first_name.Substring(posicao + 1, 1).ToUpper() + usuarioObj.first_name.Substring(posicao + 2);

                    //Concatena o primeiro e segundo nome
                    concatenar = string.Format("{0} {1}", primNome, segNome).ToString();
                    usuarioObj.first_name = concatenar;

                    //Torna a primeira letra do sobronome maiuscula
                    usuarioObj.last_name = usuarioObj.last_name.Substring(0, 1).ToUpper();
                }
                //Se não existir espaço em branco...
                else
                {
                    //Torna primeira letra do nome maiuscula e depois a primeira letra do sobrenome
                    usuarioObj.first_name = usuarioObj.first_name.Substring(0, 1).ToUpper() + usuarioObj.first_name.Substring(1);
                    usuarioObj.last_name = usuarioObj.last_name.Substring(0, 1).ToUpper();
                }

                //Adiciona Obj na lista
                Usuarios.Add(usuarioObj);
            }
            //Retorna Obj para o metodo GetAll
            return Usuarios;
        }

        // GET api/usuarioservice/5
        public UsuarioModel Get(int id)
        {
            var usuario = repository.GetAll;

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
