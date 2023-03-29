namespace TratExcRegrasDeNegocio.Classes
{
    public class Evento
    {
        public int QtdLugares { get; set; }
        public int QtdIngressosVendidos { get; set; }

        public Evento()
        {

        }

        public void IngressoVendido()
        {
            Console.WriteLine($"Ingresso vendido com sucesso.");
            
        }
    }
}