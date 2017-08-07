using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteListagemDeUsuarios.Dominio.Entidade;
using TesteListagemDeUsuarios.Dominio.Mapeamento;

namespace TesteListagemDeUsuarios.Dominio.Repositorio
{
    public class TesteListUsersDbContext : DbContext
    {
        public TesteListUsersDbContext()
            : base("conStringTeste")
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }   
}

