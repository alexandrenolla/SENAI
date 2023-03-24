using aulas.Interfaces;
namespace aulas.Classes

{
    public class Circulo : IFiguraGeometrica
    {
        public double Raio { get; set; }
        public double Area()
        {
            return (Raio * Raio) * 3.14;
        }
        public double Perimetro()
        {
            return 2 * 3.14 * Raio;
        }
    }
}