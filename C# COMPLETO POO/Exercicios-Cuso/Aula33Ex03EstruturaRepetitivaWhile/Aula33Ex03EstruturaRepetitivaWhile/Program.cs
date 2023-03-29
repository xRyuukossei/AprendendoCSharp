using System;

namespace Aula33Ex03EstruturaRepetitivaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), a = 0, g = 0, d = 0;

            while (n != 4)
            {
                if (n == 1)
                {
                    a = a + 1;
                }
                else if (n == 2)
                {
                    g = g + 1;
                }
                else if (n == 3)
                {
                    d = d + 1;
                }
                else
                {
                    n = int.Parse(Console.ReadLine());
                }
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"MUITO OBRIGADO \nAlcool: {a}\nGasolina: {g}\nDiesel: {d}");
        }
    }
}