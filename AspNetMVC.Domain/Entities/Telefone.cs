namespace AspNetMVC.Domain.Entities
{
    public class Telefone
    {
        public int TelefoneId { get; set; }
        public string Numero { get; set; }
        public bool EhFixo { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
