using System;
using System.Globalization;

namespace Aula29Ex08EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), a = 0.08, b = 0.18, c = 0.28;

            if (n <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (n > 2000 && n <= 3000)
            {
                Console.WriteLine("R$ " + ((n - 2000) * a).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (n > 3000 && n <= 4500)
            {
                Console.WriteLine("R$ " + ((1000 * a) + ((n - 3000) * b)).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("R$ " + ((1000 * a) + (1500 * b) + (n - 4500) * c).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}