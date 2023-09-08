using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FichaCadastroAPI.Base;

namespace FichaCadastroAPI.Model
{
    [Table("Ficha")]
    public class FichaModel : RelacionalBase
    {
        [Column(TypeName = "VARCHAR"), Required, StringLength(120)]
        public string Nome { get; set; }
        
        [Column(TypeName = "VARCHAR"), Required, StringLength(120)]
        public string Email { get; set; }
        
        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public virtual List<DetalheModel> Detalhes { get; set; }

        [Required]
        public virtual List<TelefoneModel> Telefones { get; set; }
    }
}