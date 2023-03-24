namespace ex5.Classes
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

        public void FazerEmprestimo(decimal emprestimo)
        {   
            if (PossuiEmprestimo == true)
            {
                Console.WriteLine($"Já possui um empréstimo em aberto.");
                
            }
            else if (emprestimo > LimiteEmprestimo)
            {
                Console.WriteLine($"Limite insuficiente. Seu limite é de R$ {LimiteEmprestimo}.");
                
            }else
            {
                Saldo = Saldo + emprestimo;
                PossuiEmprestimo = true;
                ValorUsado = emprestimo;
            }
        }

        public void PagarEmprestimo()
        {   
            decimal total = ValorUsado * (TaxaJuros / 100);
            if (total < Saldo)
            {
                Console.WriteLine($"Saldo insuficiente. Seu empréstimo é de R$ {total}.");   
            } else
            {   
                Sacar(total);
                PossuiEmprestimo = false;
                ValorUsado = 0;

                Console.WriteLine($"Pagamento no valor de {total} realizado com sucesso! Limite de empréstimo liberado novamente: {LimiteEmprestimo}.");
                
            }
        }
    }
}