namespace aulas.Classes
{   // Classe ProdutoFinanceiro é filha da classe Produto, herdando os atributos e métodos da classe mãe
    internal class ProdutoFinanceiro : Produto
    {
        public void acesso()
        {   //Instanciação dentro da classe filha, portanto há acessos aos atributos com modificadores de acesso Protected
            ProdutoFinanceiro PF1 = new ProdutoFinanceiro();
            PF1.nome = "Produto dentro classe produto financeiro";
            PF1.cor = "Laranja";
            Console.WriteLine($"Nome: {PF1.nome}, cor: {PF1.cor}");
            PF1.vender();
            PF1.verificarEstoque();
            PF1.alteraAtributosPrivados(99, 100.0);
            
        }
    }
}