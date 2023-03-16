namespace ex3.Classes
{
    public class ContaBancaria
    {
        private int _numero;
        private int _agencia;
        private string _titular;
        private decimal _saldo = 0;
        private TipoContaEnum _TipoConta;

        public ContaBancaria(string titular, int agencia, int numero, TipoContaEnum TipoConta)
        {
            _titular = titular;
            _agencia = agencia;
            _numero = numero;
            _TipoConta = TipoConta;
        }    

        public void Depositar(decimal valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine("O valor do depósito precisa ser maior do que 0.");    
            }else
            {
                _saldo = _saldo + valor;
            }
        }

        public void Sacar(decimal valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine("O valor do saque precisa ser maior do que 0."); 
                   
            } else if(valor > _saldo)
            {
                Console.WriteLine("Valor de saque maior do que o saldo.");
                    
            } else
            {
                _saldo = _saldo - valor;
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: {_saldo}");
        }
    }
}