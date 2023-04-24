namespace aula01.Dtos;

public class FilmeCriacaoDto
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public DateTime DataDeLancamento { get; set; }
    public DiretorDto Diretor { get; set; }
}
public class DiretorDto
{
    public string Cpf { get; set; }
}

public class FilmeAlteracaoDto
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
}