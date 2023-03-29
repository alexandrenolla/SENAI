namespace TDD.Classes
{
    public static class Calculadora
    {  
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        public static decimal Somar(decimal a, decimal b)
        {
            return a + b;
        }
        public static bool DivisivelPor(int dividendo, int divisor)
        {
        
            // OPERADOR TERNÁRIO:

            // Variável recebe condição ? bloco verdade : bloco falso
            
            // bool result = dividendo % divisor == 0 ? true : false;
            // return result;

            // Mais simplificado ainda:
            return dividendo % divisor == 0 ? true : false;
            
            // Mesmo efeito que:
            
            // if(dividendo % divisor == 0)
            // {
            //     return true;
            // }
            // else
            // {
            //     return false;
            // }
        }
    }
}