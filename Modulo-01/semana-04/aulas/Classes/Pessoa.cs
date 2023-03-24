namespace aulas.Classes
{// Classe abstrata serve para quando a classe é genérica demais para se instanciar um objeto a partir dela.
 // Classes abstratas devem ser herdadas, mas não podem ser instanciadas.
    public abstract class Pessoa
    {
    //  Field -> Campo ou Atributo (Teria que escrever os Get e Set na mão lá nos métodos):
    //  public string nome;  

    //  Property -> Propriedade (Escreve os Get e Set já aqui na declaração do atributo):
    //  public string Nome
    //  {
    //      get { return Nome; }
    //      set { Nome = value; }
    //  }
                  
    // Auto property -> Propriedade automática
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public Endereco Endereco { get; set; }

        // Composição (endereço)
        public Pessoa(string nome, DateTime nascimento, Endereco endereco)
        {
            Nome = nome;
            Nascimento = nascimento;
            Endereco = endereco;
        }

        // Sobreposição -> Polimorfismo de sobrescrição.
        // A palavra chave virtual serve para permitir a sobreposição do método, sendo opcional. (Polimorfismo opcional).
        public virtual void FazerAniversario()
        {
            Nascimento = Nascimento.AddYears(1);
        }

        // Método abstrato serve para obrigar que as classes filhas façam a implementação especializada do método (Polimorfismo obrigatório).
        // Um método abstrato só pode ser declarado dentro uma classe abstrata.
        public abstract void Descrever();
    }
}