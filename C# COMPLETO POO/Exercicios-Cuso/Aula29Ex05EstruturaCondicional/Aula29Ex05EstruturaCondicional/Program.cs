using System;

namespace Aula29Ex05EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int codigo = int.Parse(vet[0]);
            float quantidade = float.Parse(vet[1]);

            if (codigo == 1)
            {
                Console.WriteLine("Total: R$ " + quantidade * 4);
            }
            else if (codigo == 2)
            {
                Console.WriteLine("Total: R$ " + quantidade * 4.5);
            }
            else if (codigo == 3)
            {
                Console.WriteLine("Total: R$ " + quantidade * 5);
            }
            else if (codigo == 4)
            {
                Console.WriteLine("Total: R$ " + quantidade * 2);
            }
            else
            {
                Console.WriteLine("Total: R$ " + quantidade * 1.5);
            }

        }
    }
}