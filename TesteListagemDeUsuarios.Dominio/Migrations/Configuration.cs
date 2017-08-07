namespace TesteListagemDeUsuarios.Dominio.Migrations
{
    using System.Data.Entity.Migrations;    
    using TesteListagemDeUsuarios.Dominio.Entidade;
    using TesteListagemDeUsuarios.Dominio.Repositorio;

    internal sealed class Configuration : DbMigrationsConfiguration<TesteListUsersDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TesteListUsersDbContext context)
        {
            context.Usuarios.AddOrUpdate(
            p => p.first_name,
            context.Usuarios.Add(new UsuarioModel { id = 1, first_name = "george", last_name = "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/calebogden/128.jpg" }),
            context.Usuarios.Add(new UsuarioModel { id = 2, first_name = "lucille", last_name = "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/josephstein/128.jpg" }),
            context.Usuarios.Add(new UsuarioModel { id = 3, first_name = "oscar", last_name = "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/olegpogodaev/128.jpg" }),
            context.Usuarios.Add(new UsuarioModel { id = 4, first_name = "eve", last_name = "holt", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/marcoramires/128.jpg" }),
            context.Usuarios.Add(new UsuarioModel { id = 5, first_name = "gob", last_name = "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/stephenmoon/128.jpg" }),
            context.Usuarios.Add(new UsuarioModel { id = 6, first_name = "tracey", last_name = "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/bigmancho/128.jpg" }),
            context.Usuarios.Add(new UsuarioModel { id = 7, first_name = "michael", last_name = "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/follettkyle/128.jpg" }),
            context.Usuarios.Add(new UsuarioModel { id = 8, first_name = "lindsay", last_name = "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/araa3185/128.jpg" }),
            context.Usuarios.Add(new UsuarioModel { id = 9, first_name = "tobias", last_name = "funke", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/vivekprvr/128.jpg" }),
            context.Usuarios.Add(new UsuarioModel { id = 10, first_name = "byron", last_name = "holt", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/russoedu/128.jpg" }),
            context.Usuarios.Add(new UsuarioModel { id = 11, first_name = "george michael", last_name = "bluth", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/mrmoiree/128.jpg" }),
            context.Usuarios.Add(new UsuarioModel { id = 12, first_name = "maeby", last_name = "funke", avatar = "https://s3.amazonaws.com/uifaces/faces/twitter/hebertialmeida/128.jpg" })
            );
        }
    }
}
