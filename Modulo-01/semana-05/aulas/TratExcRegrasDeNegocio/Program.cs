using TratExcRegrasDeNegocio.Classes;

Evento evento = new Evento();

evento.QtdIngressosVendidos = 15;
evento.QtdLugares = 12;

if (evento.QtdLugares - evento.QtdIngressosVendidos >= 0)
{
    Console.WriteLine($"Ingressos validados!");
    evento.IngressoVendido(); 
}
else
{
    throw new IngressoException("Limite de lugares disponíveis estourados para o evento.");
}
