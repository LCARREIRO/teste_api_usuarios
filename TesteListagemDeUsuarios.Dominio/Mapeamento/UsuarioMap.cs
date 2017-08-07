using System.Data.Entity.ModelConfiguration;
using TesteListagemDeUsuarios.Dominio.Entidade;

namespace TesteListagemDeUsuarios.Dominio.Mapeamento
{
    public class UsuarioMap:EntityTypeConfiguration<UsuarioModel>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");

            HasKey(u => u.id);

            Property(u => u.first_name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(u => u.last_name)
               .IsRequired()
               .HasColumnType("varchar");

            Property(u => u.avatar)
               .IsRequired()
               .HasColumnType("varchar")
               .HasMaxLength(100);
        }
    }
}
