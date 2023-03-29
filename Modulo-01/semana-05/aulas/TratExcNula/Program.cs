try
{
    string s = null;

    if (s.Length >= 0 )
    {
        Console.WriteLine($"Quantidade de caracteres: {s.Length}.");
        
    }
}
catch (NullReferenceException ex) // Específico
{
    Console.WriteLine($"O valor da variável está vazio.");
    
}
catch (Exception ex) // Genérico
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    
}