namespace aula02.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Produto")]
public class Produto
{
    [Key]
    [Column("Id")]
    [Required]
    public int Id { get; set; }

    [Column("Nome")]
    [StringLength(100)]
    [Required]
    public string Nome { get; set; }

    [Column("Categoria")]
    [StringLength(50)]
    [Required]
    public string Categoria { get; set; }

    [Column("Preco_Unitario", TypeName="decimal(9,2)")]
    [Required]
    public decimal PrecoUnitario { get; set; }
    
     // muitas compras
    public virtual ICollection<Compra> Compras { get; set; }

    //propriedades publicas
    public virtual ICollection<PromocaoProduto> Promocoes { get; set; }
}