namespace ex2.Classes
{
    public class ContaBancaria
    {
        public int numero;
        public int agencia;
        public string titular;
        public decimal saldo = 0;
        public TipoContaEnum TipoConta;

        public ContaBancaria(string titular, int agencia, int numero, TipoContaEnum TipoConta)
        {
            this.titular = titular;
            this.agencia = agencia;
            this.numero = numero;
            this.TipoConta = TipoConta;
        }    

        public void Depositar(decimal valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine("O valor do depósito precisa ser maior do que 0.");    
            }else
            {
                saldo = saldo + valor;
            }
        }

        public void Sacar(decimal valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine("O valor do saque precisa ser maior do que 0."); 
                   
            } else if(valor > saldo)
            {
                Console.WriteLine("Valor de saque maior do que o saldo.");
                    
            } else
            {
                saldo = saldo - valor;
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: {saldo}");
        }
    }
}