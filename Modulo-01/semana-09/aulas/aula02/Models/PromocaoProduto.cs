namespace aula02.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Promocao_Produto")]
public class PromocaoProduto
{
    [Key]
    [Column("Id")]
    [Required]
    public int Id { get; set; }
    
    
    [Column("Produto_Id")]
    [Required]
    public int ProdutoId { get; set; }
    //propriedades virtuais(forgeign keys)
    [ForeignKey ("ProdutoId")]
    public Produto Produto { get; set; }


    [Column("Promocao_Id")]
    [Required]
    public int PromocaoId { get; set; }

    [ForeignKey ("PromocaoId")]
    public Promocao Promocao { get; set; }

}