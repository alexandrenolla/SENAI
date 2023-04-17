namespace aula02.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Endereco")]
public class Endereco
{
    [Key]
    [Column("Id")]
    [Required]
    public int Id { get; set; }

    [Column("Numero")]
    [Required]
    public int Numero { get; set; }

    [Column("Logradouro")]
    [StringLength(100)]
    [Required]
    public string Logradouro { get; set; }

    [Column("Complemento")]
    public string Complemento { get; set; }

    [Column("Bairro")]
    [Required]
    public string Bairro { get; set; }

    [Column("Cidade")]
    [Required]
    public string Cidade { get; set; }

    // propriedade virtual
    public virtual Cliente Cliente { get; set; }
}