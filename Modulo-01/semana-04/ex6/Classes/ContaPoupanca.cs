namespace ex6.Classes
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo pessoa física.");
            }
        }

        public override void Sacar(decimal valor)
        {  
             // Taxa de R$ 0,10 por saque
            decimal taxa = 0.10M;
            base.Sacar(valor);
            Saldo = Saldo - taxa;
        }

        public override void Transferir(ContaBancaria conta, decimal valor)
        {  
             // Taxa de R$ 0,05 por transferência
            decimal taxa = 0.05M;
            base.Transferir(conta, valor);
            Saldo = Saldo - taxa;
        }
    }
}