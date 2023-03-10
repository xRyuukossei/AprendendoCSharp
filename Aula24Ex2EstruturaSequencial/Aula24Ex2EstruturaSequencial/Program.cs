using System;
using System.Globalization;

namespace Aula24Ex2EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, area, raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * (raio * raio);
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}