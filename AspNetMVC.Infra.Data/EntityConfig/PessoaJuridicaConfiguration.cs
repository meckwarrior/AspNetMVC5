using AspNetMVC.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC.Infra.Data.EntityConfig
{
    public class PessoaJuridicaConfiguration : EntityTypeConfiguration<PessoaJuridica>
    {
        public PessoaJuridicaConfiguration()
        {
            HasIndex(p => p.CNPJ)
                .IsUnique();

            Property(p => p.CNPJ)
                .HasMaxLength(14)
                .IsRequired();

            Property(p => p.RazaoSocial)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.NomeFantasia)
                .HasMaxLength(50);

            ToTable("PessoasJuridicas");
        }
    }
}
