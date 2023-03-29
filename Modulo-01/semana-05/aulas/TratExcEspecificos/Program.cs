try
{
    string texto = "5.52";
    int numero = Convert.ToInt32(texto);

    int resultado = 100/numero;
    Console.WriteLine($"O resultado de 100 divido por {numero} é: {resultado}");
    
}
catch (DivideByZeroException ex) // Específico 1
{
    Console.WriteLine($"O número digitado não pode ser zero. Digite outro valor.");
}
catch (FormatException ex) // Específico 2
{
    Console.WriteLine($"O valor digitado deve ser um número inteiro e não pode ser vazio. Tente novamente.");   
}
catch(Exception ex) // Genérico
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}.");
}