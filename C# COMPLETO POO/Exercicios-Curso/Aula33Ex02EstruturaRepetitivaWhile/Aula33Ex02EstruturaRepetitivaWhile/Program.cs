using System;

namespace Aula33Ex02EstruturaRepetitivaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pontos = Console.ReadLine().Split(' ');

            int x = int.Parse(pontos[0]);
            int y = int.Parse(pontos[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }
                pontos = Console.ReadLine().Split(' ');
                x = int.Parse(pontos[0]);
                y = int.Parse(pontos[1]);
            }
        }
    }
}