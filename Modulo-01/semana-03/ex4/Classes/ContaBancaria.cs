namespace ex4.Classes
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

        public ContaBancaria(string titular, TipoContaEnum TipoConta)
        {   
            _titular = titular;
            _TipoConta = TipoConta;
            // Instancia uma classe Random para gerar números aleatórios
            Random random = new Random();
            _numero = random.Next(0000,9999);
            _agencia = random.Next(0000,9999);  
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