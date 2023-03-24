namespace aulas.Classes
{
    public class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string nome, DateTime nascimento, Endereco endereco, decimal salario, string cargo) :base(nome, nascimento, endereco)
        {
            Salario = salario;
            Cargo = cargo;
        }

    //  Sobrecargas: Variações do método dentro da mesma classe.
        public void ReceberAumento()
        {
            Salario += 100;
        }
        public void ReceberAumento(decimal valor)
        {
            Salario = Salario + valor;
        }
        public void ReceberAumento(decimal novoValor, string novoCargo)
        {
            Salario = novoValor;
            Cargo = novoCargo;
        }
        
        // Sobreposição: Variações do comportamento do método herdado da classe mãe.
        public override void FazerAniversario()
        {
            Salario = Salario + Salario * 0.10M;
        //  Salario = Salario + Salario * 10 / 100;
        //  Salario = Salario + 1.10M;
            base.FazerAniversario();
        }
        public override void Descrever()
        {
            Console.WriteLine($"O Funcionário {Nome} nasceu em {Nascimento} e possui o seguinte endereço: {Endereco}. Possui um salário de {Salario} dólares e é um {Cargo}.");
            
        }
    }
}