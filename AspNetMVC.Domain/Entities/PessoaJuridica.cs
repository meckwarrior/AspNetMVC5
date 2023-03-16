namespace AspNetMVC.Domain.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
    }
}
