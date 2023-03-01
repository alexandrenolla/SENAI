namespace ex5.Classes
{
    public class ContaBancaria
    {
        public int numero;
        public int agencia;
        public string titular;
        public decimal saldo = 0;
        public TipoContaEnum TipoConta;    

        public void Depositar(decimal deposito)
        {
            if(deposito <= 0)
            {
                Console.WriteLine("O valor do depósito precisa ser maior do que 0.");    
            }else
            {
                saldo = saldo + deposito;
            }
        }

        public void Sacar(decimal saque)
        {
            if(saque <= 0)
            {
                Console.WriteLine("O valor do saque precisa ser maior do que 0.");    
            } else if(saque > saldo)
            {
                Console.WriteLine("Valor de saque maior do que o saldo.");    
            } else
            {
                saldo = saldo - saque;
            }
        }
    }
}