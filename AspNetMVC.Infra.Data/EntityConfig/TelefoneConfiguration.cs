using AspNetMVC.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC.Infra.Data.EntityConfig
{
    public class TelefoneConfiguration : EntityTypeConfiguration<Telefone>
    {
        public TelefoneConfiguration()
        {
            HasKey(p => p.TelefoneId);

            Property(p => p.Numero)
                .HasMaxLength(30);

            Property(p => p.EhFixo)
                .IsRequired();

            HasRequired(p => p.Pessoa)
                .WithMany()
                .HasForeignKey(p => p.PessoaId);
        }
    }
}
