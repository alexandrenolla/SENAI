FileInfo arquivo = null;

try
{
    Console.WriteLine($"Digite o nome e extensão do arquivo que você quer criar:");
    string nomeArquivo = Console.ReadLine();

    arquivo = new FileInfo(nomeArquivo);

    using(StreamWriter gravadorFluxo = File.AppendText(nomeArquivo))
    {
        gravadorFluxo.WriteLine("Texto dentro do arquivo.");
    }
}
catch (ArgumentException ex) // Específico
{
    Console.WriteLine($"Ocorreu um erro. {ex.Message}"); 
}
catch (Exception ex) // Genérico
{
    Console.WriteLine($"Ocorreu um erro. {ex}");
}
finally
{
    Console.WriteLine($"Encerrando programa.\n");
    // arquivo = null;
    // Console.Clear();
}