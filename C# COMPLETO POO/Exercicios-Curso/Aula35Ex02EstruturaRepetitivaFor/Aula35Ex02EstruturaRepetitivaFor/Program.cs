using System;

namespace Aula35Ex02EstruturaRepetitivaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    a = a + 1;
                }
                else
                {
                    b = b + 1;
                }
            }
            Console.WriteLine($"{a} in\n{b} out");
        }
    }
}