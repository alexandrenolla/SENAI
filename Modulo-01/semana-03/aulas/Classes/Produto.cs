namespace aulas.Classes
{   // O Modificador de acesso da classe sobrescreve os modificadores dos atributos
    internal class Produto
    {   // Modificadores de acesso diferentes
        public string nome;
        protected string cor;
        private double peso, preco;

        public Produto(string nome, string cor)
        {
            this.nome = nome;
            this.cor = cor;
        }

        public Produto()
        {
        }
        public void verificarEstoque()
        {
            Console.WriteLine($"Verificando estoque, acessando o método da classe Produto.");  
        }

        protected void vender()
        {
            Console.WriteLine($"Vendendo produto, acessando o metodo vender da classe Produto.");    
        }

        private void descartar()
        {
            Console.WriteLine($"Descartando produto, acessando o método da classe Produto.");
            
        }

        protected void alteraAtributosPrivados(double peso2, double preco)
        {
            peso = peso2;
            Console.WriteLine($"Variável peso de escopo da classe: {peso}");
            
        }

        protected internal void teste()
        {
            Console.WriteLine($"Acessado.");
            
        }

    }
}