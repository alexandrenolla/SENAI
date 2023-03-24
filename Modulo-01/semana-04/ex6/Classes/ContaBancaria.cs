namespace ex6.Classes
{
    public class ContaBancaria
    {
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public decimal Saldo { get; protected set; }

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            Cliente = cliente;
            // Opcional visto que o decimal já inicia em 0.
            Saldo = 0;
        }

        public virtual void Sacar(decimal valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine($"Saldo insuficiente.");
                
            }
            else if (valor <= 0)
            {
                Console.WriteLine($"Valor precisa ser maior que 0.");
            }else
            {
                Saldo = Saldo - valor;            
            }
        }
        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"Valor precisa ser maior que 0.");
            }else
            {
                Saldo = Saldo + valor; 
            }  
        }

        public virtual void Transferir(ContaBancaria conta, decimal valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine($"Saldo insuficiente.");
                
            }
            else if (valor <= 0)
            {
                Console.WriteLine($"O valor precisa ser maior que 0.");
                
            }else
            {
                Saldo = Saldo - valor;
                conta.Depositar(valor);

                Console.WriteLine($"R$ {valor} transferido com sucesso.");
            }        
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: R$ {Saldo}");
            
        }
    }
}