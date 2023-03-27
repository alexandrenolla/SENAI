namespace ex6.Classes
{
    public class ContaEmpresarial : ContaBancaria
    {
        public decimal LimiteEmprestimo { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public bool PossuiEmprestimo { get; private set; }
        public decimal ValorUsado { get; private set; }
        public string CNPJ { get; private set; }

        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal limiteEmprestimo, decimal taxaJuros, decimal valorUsado, string cnpj) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoPessoaEnum.JURIDICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo pessoa jurídica.");
            }

            LimiteEmprestimo = limiteEmprestimo;
            TaxaJuros = taxaJuros;
            ValorUsado = valorUsado;
            CNPJ = cnpj;
        }

        public override void Sacar(decimal valor)
        {
            // Taxa de R$ 1,00 por saque
            decimal taxa = 1.0M;
            base.Sacar(valor);
            Saldo = Saldo - taxa;
        }

        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            // Taxa de R$ 0,50 por transferência
            decimal taxa = 0.50M;
            base.Transferir(conta, valor);
            Saldo = Saldo - taxa;
        }

        public void FazerEmprestimo(decimal emprestimo)
        {   
            if (PossuiEmprestimo == true)
            {
                Console.WriteLine($"Já possui um empréstimo em aberto.");
                
            }
            else if (emprestimo > LimiteEmprestimo)
            {
                Console.WriteLine($"Limite insuficiente. Seu limite é de R$ {LimiteEmprestimo}.");
                
            }
            else if (emprestimo <= 0)
            {
                Console.WriteLine($"O valor precisa ser maior do que 0.");
                
            }else
            {
                base.Depositar(emprestimo);
                PossuiEmprestimo = true;
                ValorUsado = emprestimo;
                
                Console.WriteLine($"Empréstimo no valor de R$ {emprestimo} realizado com sucesso. Aproveite!");   
            }
        }

        public void PagarEmprestimo()
        {
            decimal total = ValorUsado + (ValorUsado * TaxaJuros / 100);

            if (total > Saldo)
            {
                Console.WriteLine($"Saldo insuficiente para realizar o pagamento.");
                
            }else
            {
                Sacar(total);
                PossuiEmprestimo = false;
                ValorUsado = 0;
                Console.WriteLine($"Parabéns, você quitou o empréstimo no valor de {total}! Limite liberado novamente.");
            }            
        }
    }
}