using tareaPolimor.Interfaces;

namespace tareaPolimor.Clases.Figuras
{
    public class Cuadrado : FiguraGeometrica, IPoligono
    {
        public double Lado { get; set; }
        public Cuadrado(double lado)
        {
            Lado = lado;
        }
        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }

        double IPoligono.CalcularArea()
        {
            return CalcularArea();
        }

        double IPoligono.CalcularPerimetro()
        {
            return CalcularPerimetro();
        }
    }

}
