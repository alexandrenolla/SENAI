namespace ex6.Classes;

internal class ProdutoFinanceiro : Produto
{
    public void acesso()
    {
        ProdutoFinanceiro PF1 = new ProdutoFinanceiro();
        PF1.nome = "Ações";
        PF1.cor = "Azul";
        Console.WriteLine($"Nome: {PF1.nome}\nCor: {PF1.cor}");
        
        PF1.vender();
        PF1.verificarEstoque();
        PF1.alterarAtributosPrivados(99,100.0);
    }
}