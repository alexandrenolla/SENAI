using System.ComponentModel.DataAnnotations;

namespace FichaCadastroAPI.DTOs 
{
    public class PostFichaDTO
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(500, ErrorMessage = "Este campo aceita até 500 caracteres.")]
        [MinLength(5, ErrorMessage = "Favor digitar nome completo.")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Range(typeof(DateTime), "1930-01-01", "2025-12-31", ErrorMessage = "Data inválida")]
        public DateTime DataNascimento { get; set; }
        

    }
}