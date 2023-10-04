namespace tareaPolimor.Clases
{
    public class FiguraGeometrica
    {
        public double? Area { get; protected set; }
        public double? Perimetro { get; protected set; }

        public virtual double CalcularArea()
        {
            return 0;
        }

        public virtual double CalcularPerimetro()
        {
            return 0;
        }
    }
}
