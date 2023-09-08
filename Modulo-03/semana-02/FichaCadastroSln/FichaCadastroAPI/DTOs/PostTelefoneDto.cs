using System.ComponentModel.DataAnnotations;
using FichaCadastroAPI.Model;

namespace FichaCadastroAPI.DTOs
 {
    public class PostTelefoneDTO
    {

        [MaxLength(2, ErrorMessage = "Este campo aceita até 02 caracteres.")]
        [MinLength(2, ErrorMessage = "Favor digitar DDD completo.")]
        [Required]
        public string DDD { get; set; }

        [MaxLength(9, ErrorMessage = "Este campo aceita até 9 caracteres.")]
        [MinLength(9, ErrorMessage = "Favor digitar número completo.")]
        [Required]
        public string Numero { get; set; }

        
        [Required]
        public bool Ativo { get; set; }

        [Required]
        public virtual FichaModel Ficha { get; set; }
    }
 } 