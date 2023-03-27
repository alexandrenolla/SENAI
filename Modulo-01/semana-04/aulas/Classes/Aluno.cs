namespace aulas.Classes
{   // Aluno extends (herda) Pessoa
    public class Aluno : Pessoa
    {
        public string Curso { get; set; }
        public int Semestre { get; set; }

        public Aluno(string nome, DateTime nascimento, Endereco endereco, string curso, int semestre) : base(nome, nascimento, endereco)
        {
            Curso = curso;
            Semestre = semestre;
        }

        public override void Descrever()
        {
            Console.WriteLine($"O aluno {Nome} nasceu em {Nascimento}, reside em {Endereco.MostrarEndereco()} e cursa {Curso}, atualmente no {Semestre}• semestre.");
            
        }
    }
}