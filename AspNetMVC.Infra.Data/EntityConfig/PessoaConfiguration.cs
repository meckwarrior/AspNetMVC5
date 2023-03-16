using AspNetMVC.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace AspNetMVC.Infra.Data.EntityConfig
{   
    public class PessoaConfiguration : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            HasKey(p => p.PessoaId);

            HasMany(p => p.Telefones)
                .WithRequired(t => t.Pessoa);

            HasOptional(p => p.Endereco);

            Property(p => p.Email)
                .HasMaxLength(100);

            ToTable("Pessoas");
                
        }
    }
}
