﻿namespace AspNetMVC.Domain.Entities
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Descricao { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
    }
}
