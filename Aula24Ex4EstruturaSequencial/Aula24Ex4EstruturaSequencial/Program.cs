using System;
using System.Globalization;

namespace Aula24Ex4EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            float t, s = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            t = h * s;

            Console.WriteLine("NUMBER = " + n.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("SALARY = U$ " + t.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}