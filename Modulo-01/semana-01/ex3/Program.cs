/* 
Separador de números ímpares e pares
Faça um programa que receba do usuário dez números inteiros e execute os seguintes passos:
a) Separe em duas listas sendo um somente números ímpares e o outro números pares.
b) Coloque os números de cada lista em ordem crescente.
c) Exiba como resultado o número de elementos em cada lista e a soma dos valores de cada um. Ex: “A lista de números ímpares possui 5 números e a soma deles é igual a 47”
*/

List <int> pares = new List <int> {};
List <int> ímpares = new List <int> {};


for(int i=1; i <= 10; i++)
{
    Console.WriteLine($"Digite o {i}• número inteiro.");
    int numero = int.Parse(Console.ReadLine());
    if(numero % 2 == 0)
    {
        pares.Add(numero);
    }
    else
    {
        ímpares.Add(numero);
    }
}

pares.Sort();
ímpares.Sort();

Console.WriteLine($"Existem {pares.Count()} de elementos na lista de pares");
Console.WriteLine("A soma dos números pares resulta em: " + pares.Sum());

Console.WriteLine($"Existem {pares.Count()} de elementos na lista de pares");
Console.WriteLine("A soma dos números ímpares resulta em: " + ímpares.Sum());