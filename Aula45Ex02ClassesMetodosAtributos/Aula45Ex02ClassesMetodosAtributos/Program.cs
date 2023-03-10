using System;
using System.Globalization;

namespace Aula45Ex02ClassesMetodosAtributos
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nFuncionário: " + func);

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double porcento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            func.AumentarSalario(porcento);

            Console.WriteLine("\nDados atualizados: " + func);
        }
    }
}
