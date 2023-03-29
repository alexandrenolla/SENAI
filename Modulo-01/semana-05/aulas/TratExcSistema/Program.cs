using TratExcSistema.Classes;

/* EXCEÇÕES DE SISTEMA */

try
{
    //Código
    // Estudante estudante1 = null;
    // string nomeEstudante = estudante1.Nome;
    // Console.WriteLine(nomeEstudante);
    Console.WriteLine($"Digite um número:");
    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado de {numero} x 10 é {numero * 10}.");  
}
catch(FormatException ex) // Captura específica do erro.
{
    Console.WriteLine($"Erro específico capturado: {ex.Message}");
    
}
catch(Exception ex) // ex: Variável da exceção
{
    //Código de tratamento de erro
    Console.WriteLine($"Erro capturado. {ex}");   
}
finally
{
    //Código de "limpeza" final. Dando erro ou não, o finnaly será executado.
    Console.WriteLine($"Somente números.");   
}
Console.WriteLine($"----------------------------\nExeções 2:\n");
int x = 2;
int y = 0;

try
{
    Console.WriteLine($"x / y é igual: {x/y}");
}
catch(DivideByZeroException ex) // Do mais específico
{
    Console.WriteLine($"Explicação do erro de divisão por zero: {ex.Message}");
}
catch(ArithmeticException ex)
{
    Console.WriteLine($"Explicação de erro: {ex.Message} ");  
}
catch(Exception ex) // Para o mais genérico
{
    Console.WriteLine($"Explicação de erro genérico: {ex.Message}");  
}