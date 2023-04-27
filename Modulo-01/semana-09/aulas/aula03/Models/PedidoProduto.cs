namespace aula03.Models;

public class PedidoProduto
{
    public int Id { get; set; }
    public int Produto_Id { get; set; }
    public int Pedido_Id { get; set; }
    public virtual Produto Produto { get; set; }
    public virtual Pedido Pedido { get; set; }
}