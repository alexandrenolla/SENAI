using ex1.Classes;

Produto produto1 = new Produto("Limpador", 9.90, 147);

Produto produto2 = new Produto();

Console.WriteLine($"O produto 1 tem nome: {produto1.nome},\npreço: {produto1.preco},\nquantidade: {produto1.quantidade}");

Console.WriteLine($"O produto 2 tem nome: {produto2.nome},\npreço: {produto2.preco},\nquantidade: {produto2.quantidade}");

