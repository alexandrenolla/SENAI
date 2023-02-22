namespace aulas.Classes
{
    public class Produto 
    {
        private string _nome;

        private decimal _preco;

        private int _quantidade;


        public Produto(string nome, decimal preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public void DescreverProduto()
        {
            Console.WriteLine($"O nome do produto é {_nome}. O seu preco é {_preco} e ele tem atualmente {_quantidade} unidades.");
        }
    }
}