namespace TratExcRegrasDeNegocio.Classes
{
    public class IngressoException : Exception
    {
        public IngressoException()
        {

        }
        public IngressoException(string mensagem) : base(mensagem)
        {

        }
        public IngressoException(string mensagem, Exception causaException) : base(mensagem, causaException)
        {
            
        }
    }
}