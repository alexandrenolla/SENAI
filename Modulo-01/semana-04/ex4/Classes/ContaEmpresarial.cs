namespace ex4.Classes
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
                throw new ArgumentException("Cliente precisa ser do tipo jurídica.");
            }
            
            LimiteEmprestimo = limiteEmprestimo;
            TaxaJuros = taxaJuros;
            ValorUsado = valorUsado;
            CNPJ = cnpj;
        }
    }
}