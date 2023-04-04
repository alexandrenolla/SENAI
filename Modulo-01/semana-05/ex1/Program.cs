try
{
    Console.WriteLine($"Digite o primeiro número decimal:");
    decimal num1 = decimal.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o segundo número decimal:");
    decimal num2 = decimal.Parse(Console.ReadLine());
    decimal resultado = num1 / num2;
    Console.WriteLine($"O resultado da divisão de {num1} com {num2} é: {resultado}"); 
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Divisões por zero não são possíveis: {ex.Message}"); 
}
catch (FormatException ex)
{
    Console.WriteLine($"Você deve inserir apenas números decimais. {ex.Message}"); 
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}"); 
}
finally
{
    decimal num1 = 0;
    decimal num2 = 0;
}