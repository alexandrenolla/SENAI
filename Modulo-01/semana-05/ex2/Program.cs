using System;
using System.IO;

FileInfo arquivo = null;
try
{
    Console.WriteLine($"Digite o nome do arquivo que deseja criar:");
    string nomeArquivo = Console.ReadLine();
    arquivo = new FileInfo(nomeArquivo);
    using (StreamWriter gravadorTexto = File.AppendText(nomeArquivo))
    {
        gravadorTexto.WriteLine("Texto dentro do arquivo.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    
}
finally
{
    Console.WriteLine($"Encerrando programa...\n");
    arquivo = null;
    
}