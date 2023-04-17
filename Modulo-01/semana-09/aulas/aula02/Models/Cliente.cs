using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aula02.Models;

[Table("Cliente")]
public class Cliente
{
    [Key]
    [Column("Id")]
    [Required]
    public int Id { get; set; }
    
    [Column("Nome")]
    [StringLength(150)]
    [Required]
    public string Nome { get; set; }

    [Column("Endereco_Id")]
    [Required]
    public int EnderecoId { get; set; }
    // propriedades virtuais
    [ForeignKey("EnderecoId")]
    public virtual Endereco EnderecoDeEntrega { get; set; }
    // muitas compras
    public virtual ICollection<Compra> Compras { get; set; }
}