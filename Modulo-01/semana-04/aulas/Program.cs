using aulas.Classes;

Funcionario tupac = new Funcionario("Tupac", DateTime.Parse("1971-09-06"), new Endereco(){
    CEP = "88056-460",
    Cidade = "Florianópolis",
    Estado = "SC",
    Numero = "99",
    Complemento = "Where the cash is"
    // Deixei o campo Logradouro vazio (string vazia)
}, 10000, "Desenvolvedor Jr.");

tupac.Descrever();
Console.WriteLine($"\n");
// Sobrecarga 
tupac.ReceberAumento(30000, "Desenvolvedor Pleno");
tupac.Descrever();


Cliente bruno = new Cliente("Bruno", DateTime.Parse("1999-01-25"), new Endereco{
    CEP = "88056-460"
}, 1904);

Console.WriteLine(bruno.Nome);
Console.WriteLine(bruno.Nascimento);
bruno.Descrever();
Console.WriteLine($"\n");

// Especialização da Pessoa: Aluno herda tudo da Pessoa + o que ele próprio implementou.
Aluno aluno = new Aluno("João", DateTime.Parse("1994-10-13"), new Endereco{
    CEP = "88056-460"
}, "Business", 1);

Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Curso);
aluno.Descrever();
Console.WriteLine($"\n");


// UPCASTING: Instanciar um objeto da classe mãe com o construtor da classe filha.
Pessoa pessoa = new Aluno("Fernando", DateTime.Parse("1980-04-20"), new Endereco{CEP = "0000-000"}, "Artes", 4);

// DOWNCASTING: 
Aluno aluno2 = (Aluno)pessoa;
Console.WriteLine(aluno2.Curso);

Console.WriteLine($"---------------------\n");

// Execução das diferentes sobreposições
Cachorro cachorro = new Cachorro();
cachorro.EmitirSom();

Gato gato = new  Gato();
gato.EmitirSom();

// Execução do método estático
Calculadora.Somar(2,2);

