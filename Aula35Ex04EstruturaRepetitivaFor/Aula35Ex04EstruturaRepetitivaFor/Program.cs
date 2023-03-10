using System;
using System.Globalization;

namespace Aula35Ex04EstruturaRepetitivaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i < n; i++)
            {
                string[] p = Console.ReadLine().Split(' ');

                double p1 = double.Parse(p[0], CultureInfo.InvariantCulture);
                double p2 = double.Parse(p[1], CultureInfo.InvariantCulture);
                if (p2 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine(p1 / p2);
                }
            }
        }
    }
}