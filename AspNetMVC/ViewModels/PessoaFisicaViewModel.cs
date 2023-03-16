using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetMVC.ViewModels
{
    public class PessoaFisicaViewModel
    {
        public PessoaFisicaViewModel()
        {
            Endereco = new EnderecoViewModel();
            Telefones = new List<TelefoneViewModel> { new TelefoneViewModel(), new TelefoneViewModel() };
        }

        [Key]
        public int PessoaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MinLength(11, ErrorMessage = "Preencha todos os números")]
        public string CPF { get; set; }
        public string CPFMascarado => CPF.Insert(3, ".").Insert(7, ".").Insert(11, "-");

        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres")]
        public string RG { get; set; }
        
        public string Sexo { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public EnderecoViewModel Endereco { get; set; }

        public IList<TelefoneViewModel> Telefones { get; set; }
    }
}