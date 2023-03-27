namespace aulas.Classes
{   // Client extends (herda) Pessoa
    public class Cliente : Pessoa
    {
        public int Cadastro { get; set; }
        public Cliente(string nome, DateTime nascimento, Endereco endereco, int cadastro) : base(nome, nascimento, endereco)
        {
            Cadastro = Cadastro;
        }

        public override void Descrever()
        {
            Console.WriteLine($"O cliente {Nome} nasceu em {Nascimento}, reside no {Endereco.MostrarEndereco()} e possui cadastro número {Cadastro}.");
            
        }
    }   
}