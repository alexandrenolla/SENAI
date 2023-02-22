/*
Cálculo de média de aprovação
Faça um programa que receba o nome e média final de cinco alunos. Armazene em um array ou list os nomes e em outra as médias. Ao final, exiba o nome de cada aluno e a mensagem “APROVADO” para quem tiver média acima de 6 e “REPROVADO” para quem não.
 */

List <string> nomes = new List<string> {};
List <decimal> médias = new List <decimal> {};
Dictionary<string, decimal> resultado = new Dictionary<string, decimal> {};

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Digite o nome do {i}• aluno: ");
    string nome = Console.ReadLine();
    nomes.Add(nome);

    Console.WriteLine($"Digite a média do {i}• aluno: ");
    decimal média = decimal.Parse(Console.ReadLine());
    médias.Add(média);

    resultado.Add(nome, média);
}

foreach(var (key,value) in resultado)
{
    if(value >= 6)
    {
        Console.WriteLine("O aluno " + key + " está APROVADO");
    }
    else
    {
        Console.WriteLine("O aluno " + key + " está REPROVADO"); 
    }
}

