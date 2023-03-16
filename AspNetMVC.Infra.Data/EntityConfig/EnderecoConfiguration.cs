using AspNetMVC.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(p => p.EnderecoId);

            Property(p => p.Descricao)
                .HasMaxLength(100);

            Property(p => p.Numero)
                .HasMaxLength(10);

            Property(p => p.Complemento)
                .HasMaxLength(50);

            Property(p => p.Bairro)
                .HasMaxLength(50);

            Property(p => p.Cidade)
                .HasMaxLength(50);

            Property(p => p.Estado)
                .HasMaxLength(2)
                .IsFixedLength();

            Property(p => p.CEP)
                .HasMaxLength(8);
        }
    }
}
