using System.ComponentModel.DataAnnotations;

namespace FichaCadastroAPI.DTOs
{
    public class PutFichaDTO
    {
        [MaxLength(500, ErrorMessage = "Este campo aceita até 500 caracteres.")]
        [MinLength(5, ErrorMessage = "Favor digitar nome completo.")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [Range(typeof(DateTime), "1930-01-01", "2025-12-31", ErrorMessage = "Data inválida")]
        public DateTime DataNascimento { get; set; }
        
    }
}