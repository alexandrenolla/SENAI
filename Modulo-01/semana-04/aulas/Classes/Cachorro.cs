namespace aulas.Classes
{
    public class Cachorro : Mamifero // Herança
    {
        // Sobreposição
        public override void EmitirSom()
        {
            Console.WriteLine($"Au Au");
        }
    }
}