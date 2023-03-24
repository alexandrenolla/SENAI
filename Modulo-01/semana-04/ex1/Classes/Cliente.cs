namespace ex1.Classes
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public string EstadoCivil { get; private set; }
        public TipoPessoa TipoPessoa { get; private set; }

        public Cliente(string nome, DateTime nascimento, string profissao, string estadoCivil, TipoPessoa tipoPessoa)
        {
            Nome = nome;
            Nascimento = nascimento;
            Profissao = profissao;
            EstadoCivil = estadoCivil;
            TipoPessoa = tipoPessoa;

        }
    }
}
