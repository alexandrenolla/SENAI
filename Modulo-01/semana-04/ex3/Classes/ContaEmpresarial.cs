namespace ex3.Classes
{
    public class ContaEmpresarial : ContaBancaria
    {
        public ContaEmpresarial(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoPessoaEnum.JURIDICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo pessoa jurídica.");
            }
        }
    }
}