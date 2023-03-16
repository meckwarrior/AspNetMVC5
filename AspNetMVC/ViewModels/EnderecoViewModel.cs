using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetMVC.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int EnderecoId { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [DisplayName("Logradouro/Nome")]
        public string Descricao { get; set; }
        
        [MaxLength(10, ErrorMessage = "Máximo 50 caracteres")]
        public string Numero { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Complemento { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Bairro { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Cidade { get; set; }

        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres")]
        public string Estado { get; set; }
        
        [DataType(DataType.PostalCode)]
        public string CEP { get; set; }
    }
}