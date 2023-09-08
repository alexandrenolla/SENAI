using System.ComponentModel.DataAnnotations;
using FichaCadastroAPI.Model;

namespace FichaCadastroAPI.DTOs
{
    public class PutTelefoneDTO
    {

        [MaxLength(2, ErrorMessage = "Este campo aceita até 02 caracteres.")]
        [MinLength(2, ErrorMessage = "Favor digitar DDD completo.")]
        public string DDD { get; set; } 

        [MaxLength(9, ErrorMessage = "Este campo aceita até 9 caracteres.")]
        [MinLength(9, ErrorMessage = "Favor digitar número completo.")]
        public string Numero { get; set; }
        
        public bool Ativo { get; set; }

        public virtual FichaModel Ficha { get; set; }
    }
}