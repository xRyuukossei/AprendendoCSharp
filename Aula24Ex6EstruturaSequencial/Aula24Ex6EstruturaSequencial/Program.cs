using System;
using System.Globalization;

namespace Aula24Ex6EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double triangulo, circulo, trapezio, quadrado, retangulo;

            triangulo = (a * c) / 2;
            circulo = (3.14159 * (c * c));
            trapezio = ((a + b) * c) / 2;
            quadrado = b * b;
            retangulo = (a * b);

            Console.WriteLine(triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}