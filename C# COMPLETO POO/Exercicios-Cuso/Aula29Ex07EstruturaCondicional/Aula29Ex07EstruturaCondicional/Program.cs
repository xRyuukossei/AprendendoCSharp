using System;
using System.Runtime.CompilerServices;

namespace Aula29Ex07EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pontos = Console.ReadLine().Split(' ');

            float p1 = float.Parse(pontos[0]);
            float p2 = float.Parse(pontos[1]);

            if (p1 == 0 && p2 != 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (p2 == 0 && p1 != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (p1 < 0.0 && p2 < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (p1 > 0.0 && p2 > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (p1 < 0.0 && p2 > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (p1 > 0.0 && p2 < 0.0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}