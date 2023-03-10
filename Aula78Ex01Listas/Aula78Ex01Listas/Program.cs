using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex1Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> funcionario = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionario.Add(new Employee(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increaase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            Employee aumentoSalarial = funcionario.Find(x => x.Id == idIncrease);

            if (aumentoSalarial != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aumentoSalarial.increaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee obj in funcionario)
            {
                Console.WriteLine(obj);
            }

        }
    }
}