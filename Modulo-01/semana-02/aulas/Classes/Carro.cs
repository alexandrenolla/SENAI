namespace aulas.Classes
{
    public class Carro
    {   // Campo
        public string cor;
        public string marca;
        public string modelo;
        
        public TipoCarroEnum tipoCarro;
        // Método
        public void Acelerar()
        {
            Console.WriteLine("O carro está acelerando.");
        }

        /* Método com parâmetro opcional
        Parâmetro default caso o valor seja nulo ou vazio: */
        public void AlterarCor(string? novaCor = "Branco")
        {   
            cor = novaCor;
        }
    }
    
}