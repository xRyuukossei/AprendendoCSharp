using System;

namespace Aula29Ex04EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] horas = Console.ReadLine().Split(' ');

            int h1 = int.Parse(horas[0]);
            int h2 = int.Parse(horas[1]);

            if (h2 - h1 < 1)
            {
                Console.WriteLine("O JOGO DUROU " + ((24 - h1) + h2) + " HORA(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + (h2 - h1) + " HORA(S)");
            }
        }
    }
}