namespace aula03.Models;

public class TipoProduto
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public virtual ICollection<Produto> Produtos { get; set; }
}