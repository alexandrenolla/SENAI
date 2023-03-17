namespace ex6.Classes;
internal class Produto
{
    public string nome;
    protected string cor;
    private double _peso;
    private double _preco;

    public void verificarEstoque()
    {
        Console.WriteLine($"Verificando estoque, acessando o método da classe produto.");
        
    }
    protected void vender()
    {
        Console.WriteLine($"Vendendo produto, acessando método vender da classe produto");
        
    }
    private void descartar()
    {
        Console.WriteLine($"Descartando o produto, acessando o método da classe produto");
        
    }
    protected void alterarAtributosPrivados(double peso2, double preco)
    {
        _peso = peso2;
        Console.WriteLine($"Variável peso do escopo da classe: {_peso}");
        
    }
}