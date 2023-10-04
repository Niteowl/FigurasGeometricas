using tareaPolimor.Interfaces;

namespace tareaPolimor.Clases.Figuras
{
    using System;

    public class TrianguloEquilatero : FiguraGeometrica, IPoligono
    {
        public double Lado { get; set; }

        public TrianguloEquilatero(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return (Math.Sqrt(3) / 4) * (Lado * Lado);
        }

        public override double CalcularPerimetro()
        {
            return (3 * Lado);
        }
    }


}
