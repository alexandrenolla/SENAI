using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FichaCadastroAPI.Base;

namespace FichaCadastroAPI.Model
{
    [Table("Telefone")]
   public class TelefoneModel : RelacionalBase
   {    
        [Required]
        public string DDD { get; set; }

        [Required]
        public string Numero { get; set; }

        
        [Required]
        public bool Ativo { get; set; }

        [Required]
        public virtual FichaModel Ficha { get; set; }
        
   }
}