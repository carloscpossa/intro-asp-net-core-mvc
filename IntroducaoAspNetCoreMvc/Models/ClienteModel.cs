using System.ComponentModel.DataAnnotations;

namespace IntroducaoAspNetCoreMvc.Models
{
    public class ClienteModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome do cliente é obrigatório")]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Display(Name = "Documento")]        
        public string CPF { get; set; }

        [EmailAddress]
        [Required]
        [Display(Name = "Email")]
        public string EnderecoEmail { get; set; }

        public int Idade { get; set; }

    }
}
