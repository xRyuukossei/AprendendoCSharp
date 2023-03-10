using System;

namespace Aula33Ex01EstruturaRepetitivaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());

            while (s != 2002)
            {
                Console.WriteLine("Senha Invalida");
                s = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}