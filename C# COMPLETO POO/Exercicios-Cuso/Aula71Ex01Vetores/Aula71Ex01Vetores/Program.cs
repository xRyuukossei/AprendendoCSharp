using System;
using System.Globalization;

namespace Aula71Ex01Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be Rented? ");
            int r = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Estudante[] estudante = new Estudante[10];

            for (int i = 0; i < r; i++)
            {
                Console.WriteLine("\nRent #" + (i + 1));
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                estudante[quarto] = new Estudante { Nome = nome, Email = email, Quarto = quarto };
            }

            Console.WriteLine("\nBusy rooms:");

            for (int i = 0; i < 10; i++)
                if (estudante[i] != null)
                {
                    Console.WriteLine(estudante[i]);
                }
        }
    }
}