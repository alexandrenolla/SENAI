namespace ex2.Classes
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public string EstadoCivil { get; private set; }
        public TipoPessoaEnum TipoPessoa { get; private set; }

        public Cliente(string nome, DateTime nascimento, string profissao, string estadoCivil, TipoPessoaEnum tipoPessoa)
        {
            Nome = nome;
            Nascimento = nascimento;
            Profissao = profissao;
            EstadoCivil = estadoCivil;
            TipoPessoa = tipoPessoa;

        }
    }
}
