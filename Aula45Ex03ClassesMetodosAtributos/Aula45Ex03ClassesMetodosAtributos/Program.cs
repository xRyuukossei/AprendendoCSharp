using System;
using System.Globalization;

namespace Aula45Ex03ClassesMetodosAtributos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.T1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.T2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.T3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nNOTA FINAL = " + aluno.CalculoDasNotas().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.AprovadoOuReprovado())
            {
                Console.WriteLine("\nAPROVADO");
            }
            else
            {
                Console.WriteLine("\nREPROVADO");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}