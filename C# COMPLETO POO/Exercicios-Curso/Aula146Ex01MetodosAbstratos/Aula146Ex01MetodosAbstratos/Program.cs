using Aula146Ex01MetodosAbstratos.Entities;
using System.Globalization;

namespace Aula146Ex01MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployess = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberEmployess));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Name 
                    + ": $ "
                    + taxPayer.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}