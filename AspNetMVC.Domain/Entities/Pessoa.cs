using System;
using System.Collections.Generic;

namespace AspNetMVC.Domain.Entities
{
    public abstract class Pessoa
    {
        public int PessoaId { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public IList<Telefone> Telefones { get; set; }
    }
}
