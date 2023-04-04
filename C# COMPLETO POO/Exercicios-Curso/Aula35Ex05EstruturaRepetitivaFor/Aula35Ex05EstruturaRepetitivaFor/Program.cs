using System;

namespace Aula35Ex05EstruturaRepetitivaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 1, n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);
        }
    }
}