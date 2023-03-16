using aulas.Classes;
// Construtores
Pessoa pessoa1 = new Pessoa("Alexandre");

Console.WriteLine(pessoa1.nome);

Pessoa pessoa2 = new Pessoa("Maria", 25, 1.76f);

Console.WriteLine($"{pessoa2.nome},{pessoa2.idade},{pessoa2.altura}");

Pessoa pessoa3 = new Pessoa();
Console.WriteLine($"{pessoa3.nome}");

Produto produto1 = new Produto();

produto1.nome = "Calculadora";
produto1.verificarEstoque();
Console.WriteLine($"O nome de produto é: {produto1.nome}.");

Console.WriteLine($"\n");

Console.WriteLine($"------Abaixo serão valores e ações de uma classe filha;");

ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();

classeFilha.nome = "Fundos Imobiliários";
classeFilha.verificarEstoque();
classeFilha.acesso();

Console.WriteLine($"\n");

// Aula 3:
Console.WriteLine($"Aula 3 ------>");

Produto2 produto = new Produto2("TV 90 polegadas", 19990, 100);
// Chamada de método do objeto
produto.DescreverProduto();
// Chamada de método com sobrecarga
produto.DescreverProduto("R$");

// Acessando atributo pelo método acessor
Console.WriteLine(produto.GetNome());
// Alterando atributo pelo método acessor
produto.SetNome("TV 120 polegadas");
// Acessando atributo alterado
Console.WriteLine(produto.GetNome());

// Alterando atributo pela propriedade
produto.Nome = "TV 200 polegadas";
//Acessando atributo pela propriedade
Console.WriteLine(produto.Nome);


