using ex6.Classes;

Produto produto1 = new Produto();
produto1.nome = "Carro";
produto1.verificarEstoque();
Console.WriteLine($"O nome do produto é: {produto1.nome}");

ProdutoFinanceiro produtoFilho = new ProdutoFinanceiro();
produtoFilho.nome = "Fundos Imobiliários";
produtoFilho.verificarEstoque();
produtoFilho.acesso();