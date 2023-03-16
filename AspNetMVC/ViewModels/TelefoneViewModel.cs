using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetMVC.ViewModels
{
    public class TelefoneViewModel
    {
        [Key]
        public int TelefoneId { get; set; }

        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres")]
        [DataType(DataType.PhoneNumber)]
        public string Numero { get; set; }

        [DisplayName("Telefone Fixo?")]
        public bool EhFixo { get; set; }
        
        [ScaffoldColumn(false)]
        public int PessoaId { get; set; }
    }
}