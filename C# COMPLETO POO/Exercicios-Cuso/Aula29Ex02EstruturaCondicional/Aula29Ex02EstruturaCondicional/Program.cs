using System;

namespace Aula29Ex02EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int resto, n = int.Parse(Console.ReadLine());

            resto = n %= 2;

            if (resto == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

        }
    }
}