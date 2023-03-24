namespace aulas.Classes
{
    public class Gato : Mamifero // Herança
    {
        //Sobreposição
        public override void EmitirSom()
        {
            Console.WriteLine($"Miau!");
            
        }
    }
}