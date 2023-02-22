// Crie um programa que receba do usuário uma lista de frutas com no máximo 15 itens. Organize as frutas em ordem alfabética e exiba a lista.

List <string> frutas = new List<string>{};

for (int i = 1; i <= 15; i ++)
{
    Console.WriteLine($"Digite a {i}• fruta.");
    string fruta = Console.ReadLine();
    frutas.Add(fruta);
}

frutas.Sort();
Console.WriteLine("As frutas digitas são, em ordem alfabética:");
foreach(string fruta in frutas)
{
    Console.WriteLine(fruta);
}