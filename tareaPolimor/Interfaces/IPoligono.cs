
namespace tareaPolimor.Interfaces
{
    internal interface IPoligono
    {
        double CalcularArea();
        double CalcularPerimetro();

        public double Lado { get; }
    }
}
