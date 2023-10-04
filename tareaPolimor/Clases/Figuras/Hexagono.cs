using tareaPolimor.Interfaces;

namespace tareaPolimor.Clases.Figuras
{
    public class Hexagono : FiguraGeometrica, IPoligono
    {
        public double Lado { get; set; }

        public Hexagono(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return (3 * Math.Sqrt(3) * Lado * Lado) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 6 * Lado;
        }
    }
}
