using System;
using System.Globalization;

namespace Aula35Ex03EstruturaRepetitivaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i < n; i++)
            {
                string[] t = Console.ReadLine().Split(' ');

                double t1 = double.Parse(t[0], (CultureInfo.InvariantCulture));
                double t2 = double.Parse(t[1], (CultureInfo.InvariantCulture));
                double t3 = double.Parse(t[2], (CultureInfo.InvariantCulture));

                double result = ((t1 * 2.0) + (t2 * 3.0) + (t3 * 5.0)) / 10;

                Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}