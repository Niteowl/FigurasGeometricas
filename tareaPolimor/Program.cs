
using tareaPolimor.Clases.Figuras;
class Program
{
    static void Main(string[] args)
    {
        // Crear instancias para las figuras y asignar valor de lados

        Cuadrado cuadrado = new Cuadrado(2);

        Circulo circulo = new Circulo(10);

        TrianguloEquilatero triangulo = new TrianguloEquilatero(3);

        Hexagono hexagono = new Hexagono(8);

        // Calcular y mostrar el área y el perimetro de cada figura

        Console.WriteLine("Cuadrado: valor del lado: " + cuadrado.Lado);
        Console.WriteLine("Área: " + cuadrado.CalcularArea());
        Console.WriteLine("Perímetro: " + cuadrado.CalcularPerimetro());
        Console.WriteLine();

        Console.WriteLine("Círculo: valor del radio: " + circulo.Radio);
        Console.WriteLine("Área: " + circulo.CalcularArea());
        Console.WriteLine("Perímetro: " + circulo.CalcularPerimetro());
        Console.WriteLine();

        Console.WriteLine("Triángulo: valor del lado: " + triangulo.Lado);
        Console.WriteLine("Área: " + triangulo.CalcularArea());
        Console.WriteLine("Perímetro: " + triangulo.CalcularPerimetro());
        Console.WriteLine();

        Console.WriteLine("Hexagono: valor del lado: " + hexagono.Lado);
        Console.WriteLine("Área: " + hexagono.CalcularArea());
        Console.WriteLine("Perímetro: " + hexagono.CalcularPerimetro());
    }
}

