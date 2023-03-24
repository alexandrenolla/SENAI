using aulas.Interfaces;
namespace aulas.Classes

{
    public class Triangulo : IFiguraGeometrica
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }
        public double Base { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return (Base * Altura) / 2;
        }
        public double Perimetro()
        {
            return LadoA + LadoB + LadoC;
        }
    }
}