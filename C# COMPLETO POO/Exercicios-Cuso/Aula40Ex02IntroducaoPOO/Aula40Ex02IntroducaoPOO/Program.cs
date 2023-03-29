using System;
using System.Globalization;

namespace Aula40Ex02IntroducaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario A = new Funcionario();
            Funcionario B = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");

            Console.Write("Nome: ");
            A.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            A.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");

            Console.Write("Nome: ");
            B.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            B.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (A.Salario + B.Salario) / 2.0;

            Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}