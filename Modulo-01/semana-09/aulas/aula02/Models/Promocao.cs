namespace aula02.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Promocao")]
public class Promocao
{
    
    [Key]
    [Column("Id")]
    [Required]
    public int Id { get; set; }

    [Column("Descricao")]
    [StringLength(100)]
    [Required]
    public string Descricao { get; set; }

    [Column("Data_Inicio")]
    [Required]
    public DateTime DataInicio { get; set; }

    [Column("Data_Termino")]
    [Required]
    public DateTime DataTermino { get; set; }
    
    //propriedades publicas
    public virtual ICollection<PromocaoProduto> Produtos { get; set; }
}