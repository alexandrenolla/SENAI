namespace aulas.Classes
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public float altura;
        // Construtor vazio
        public Pessoa()
        {

        }
        // Construtor com parâmetro nome obrigatório na instanciação
        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public Pessoa(string nome, int idade, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }
    }    
}