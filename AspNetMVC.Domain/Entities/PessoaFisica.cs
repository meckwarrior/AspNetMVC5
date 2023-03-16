using System;

namespace AspNetMVC.Domain.Entities
{
    public class PessoaFisica : Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
