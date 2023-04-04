using System;

namespace Aula24Ex3EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int dif = (a * b) - (c * d);
            Console.WriteLine($"DIFERENCA = {dif}");
        }
    }
}