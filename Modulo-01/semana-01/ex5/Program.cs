/*
Sequência de Fibonacci
Faça um algoritmo que receba um número inteiro que será a quantidade de números calculados pela sequência de Fibonacci. Em seguida, exiba a sequência no terminal. 
Ex: Se receber o número 7, você irá exibir a sequência “1 2 3 5 8 13 21” que contém ao todo 7 números.
*/

// Declarando as variáveis
int x = 1;
int y = 0;
int z = 0;

// Pedindo um número para o Usuário
Console.Write($"Digite um número: ");
int numero = int.Parse(Console.ReadLine());

// Criando a sequência de Fibonacci
Console.Write("A sequência de Fibonnaci é: ");
for (int i = 0; i < numero; i++)
{
    z = x + y;
    Console.Write(" " + z + " ");
    y = x;
    x = z;
}