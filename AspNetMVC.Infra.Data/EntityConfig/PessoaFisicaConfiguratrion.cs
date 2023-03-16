using AspNetMVC.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC.Infra.Data.EntityConfig
{
    public class PessoaFisicaConfiguration : EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaConfiguration()
        {

            HasIndex(p => p.CPF)
                .IsUnique();

            Property(p => p.Nome)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.CPF)
                .HasMaxLength(11)
                .IsRequired();

            Property(p => p.RG)
                .HasMaxLength(20);

            Property(p => p.Sexo)
                .HasMaxLength(1)
                .IsFixedLength()
                .IsUnicode(false);

            Property(p => p.DataNascimento)
                .HasColumnType("Date");


            ToTable("PessoasFisicas");
                
        }
    }
}
