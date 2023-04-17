namespace aula03.Models;

public class Estoque
{
    public int Id { get; set; }
    public int Quantidade { get; set; }
    public virtual Produto Produto { get; set; }
}