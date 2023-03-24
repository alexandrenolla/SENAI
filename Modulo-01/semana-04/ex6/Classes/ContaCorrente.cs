namespace ex6.Classes
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo pessoa física.");
            }
        }

        public override void Sacar(decimal valor)
        {
            // Taxa de R$ 0,50 por saque
            valor = valor + 0.50M;
            base.Sacar(valor);
        }

        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            // Taxa de R$ 0,25 por transferência
            valor = valor + 0.25M;
            base.Transferir(conta, valor);
        }
    }
}