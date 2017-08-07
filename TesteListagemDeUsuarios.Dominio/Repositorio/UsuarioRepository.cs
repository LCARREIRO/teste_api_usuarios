using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TesteListagemDeUsuarios.Dominio.Entidade;

namespace TesteListagemDeUsuarios.Dominio.Repositorio
{
    public class UsuarioRepository
    {
        private readonly TesteListUsersDbContext Repostirory = new TesteListUsersDbContext();

        public List<UsuarioModel> GetAll
        {
            get { return Repostirory.Usuarios.ToList(); }
        }
    }
}
