namespace aulas.Classes
{
    public class Produto2
    {   // Por convenção, atributos privados começam com "_" no nome.
        // Atributos/Campos
        private string _nome;
        private decimal _preco;
        private int _quantidade;
        
        // Auto properties são uma maneira simplificada de declarar propriedades quando não se necessita de regras particulares para os modificadores de acesso:
//1:    public int Quantidade {get; set;}
//2:    public int Quantidade {get;}
//3:    public int Quantidade {get; private set;}

        private string _loja;
        // parâmetro opcional, atribuido por "?" junto com a tipagem
        private DateTime? _vencimento;
        // Construtores
        public Produto2(string nome, decimal preco, int quantidade)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;

        _loja = "loja matriz";
        _vencimento = DateTime.Parse("2023-12-31");
    }

    public Produto2(string nome)
    {
        _nome = nome;
        _preco = 100;
        _quantidade = 10;
    }
    // Método
    public void DescreverProduto()
    {
        Console.WriteLine($"O nome do produto é {_nome}.\nO preço é {_preco}.\nA loja possui {_quantidade} unidades.\n");
        
    }
    // Sobrecarga
    public void DescreverProduto(string moeda)
    {
        Console.WriteLine($"O nome do produto é {_nome}.\nO preço é {moeda} {_preco}.\nA loja possui {_quantidade} unidades.\n");
    }    
    // métodos acessores 
    // GET e SET
    public string GetNome()
    {
        return _nome;
    }
    public decimal GetPreco()
    {
        return _preco;
    }
    public int GetQuantidade()
    {
        return _quantidade;
    }
    public void SetNome(string nome)
    {   // Validação de atribuição não vazia.
        if(!string.IsNullOrEmpty(nome))
        {
            _nome = nome;
        }
    }
    public void SetPreco(decimal preco)
    {
        if(preco > 0)
        {
            _preco = preco;
        }
    }
    public void SetQuantidade(int quantidade)
    {
        if(quantidade > 0)
        {
            _quantidade = quantidade;
        }
    }
    // Properties
    // O parâmetro do Set nas properties é o "value", equivalente ao input.
    public string Nome
    {
        get {return _nome;}
        set {
            if(!string.IsNullOrEmpty(value))
            {
                _nome = value;
            }
            }
    }
    
    }
 
}