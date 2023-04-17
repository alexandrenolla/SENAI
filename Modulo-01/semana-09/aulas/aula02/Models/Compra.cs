namespace aula02.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Compra")]
public class Compra
{
    [Key]
    [Column("Id")]
    [Required]
    public int Id { get; set; }

    [Column("Quantidade")]
    [Required]
    public int Quantidade { get; set; }

    [Column("Preco")]
    [Required]
    public decimal Preco { get; set; }

    [Column("Cliente_Id")]
    [Required]
    public int ClienteId { get; set; }
    [ForeignKey("ClienteId")]
    public virtual Cliente ClienteCompra { get; set; }


    [Column("Produto_Id")]
    [Required]
    public int ProdutoId { get; set; }
    // Propriedade virtual para indicação de relacionamento
    [ForeignKey("ProdutoId")]
    public virtual Produto ProdutoCompra { get; set; }
}