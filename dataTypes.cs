// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); // Saída de dados, impressão em tela.

int numeroInteiro = 10; // Declaração de variável inteira, recebendo o valor 10.
long numeroMaior = 109999L; // Declaração de variável long, recebendo valor 10999
float numeroQuebrado = 6.8f; // Declaração de variável do tipo float
double numeroQuebradoMaior = 101.99999; // Declaração de variável do tipo double
char letra = 'z'; // Declaração de variável do tipo char (um caracter)
string texto = "A turma Estreito é a melhor."; // Declaração de variável do tipo string, recebendo uma frase
bool variavelBooleano = true; // Declaração de variável do tipo boolean, recebendo um valor verdadeiro
DateTime data = DateTime.Now; // Declaração de variável do tipo datetime, recebendo a data atual
DateTime outraData = new DateTime(2023, 01, 31); // Declaração de variável do tipo datetime, recebendo a data imposta
texto.ToUpper(); // Convertendo o texto para letras maiúsculas
Console.WriteLine("Frase com letras maiúsculas: " + texto.ToUpper());

string nomeCompleto; // Declaração de variável sem valor
Console.Write("Digite o seu nome:"); // Instrução ao usuário, impressão em tela
nomeCompleto = Console.ReadLine(); // Aguardando o usuário digitar no terminal
Console.WriteLine("Seu nome é: " + nomeCompleto); // Concatenando o texto com o valor da variável.
