using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetMVC.ViewModels
{
    public class PessoaJuridicaViewModel
    {
        public PessoaJuridicaViewModel()
        {
            Endereco = new EnderecoViewModel();
            Telefones = new List<TelefoneViewModel> {new TelefoneViewModel(), new TelefoneViewModel() };
        }

        [Key]
        public int PessoaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo CNPJ")]
        [MinLength(14, ErrorMessage = "Preencha todos os números")]
        public string CNPJ { get; set; }

        public string CNPJMascarado => CNPJ.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");

        [Required(ErrorMessage = "Preencha o campo Razao Social")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        
        [ScaffoldColumn(false)]
        public char Tipo { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public EnderecoViewModel Endereco { get; set; }

        public IList<TelefoneViewModel> Telefones { get; set; }
    }
}