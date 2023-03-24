namespace aulas.Classes
{   // Classes estaticas são classes utilitárias, ou seja, servem para definir métodos que podem ser utilizados diretamente em qualquer local do sistema. 
    // Classes estaticas não podem ser instanciadas.
    public static class Calculadora
    {   
        // Métodos estaticos só podem ser definidos dentro de uma classe estatica
        public static decimal Somar(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        // Sobrecarga
        public static float Somar(float num1, float num2)
        {
            return num1 + num2;
        }
        public static int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}