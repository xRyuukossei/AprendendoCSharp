using System;
using System.Globalization;

namespace Aula24Ex5EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet1 = Console.ReadLine().Split(' ');

            int p1 = int.Parse(vet1[0]);
            int n1 = int.Parse(vet1[1]);
            float c1 = float.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');

            int p2 = int.Parse(vet2[0]);
            int n2 = int.Parse(vet2[1]);
            float c2 = float.Parse(vet2[2], CultureInfo.InvariantCulture);

            float soma = n1 * c1 + n2 * c2;

            Console.WriteLine("VALOR A PAGAR: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}