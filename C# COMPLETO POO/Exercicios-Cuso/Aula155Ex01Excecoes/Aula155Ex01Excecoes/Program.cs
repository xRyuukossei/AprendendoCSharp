﻿using Aula155Ex01Excecoes.Entities;
using Aula155Ex01Excecoes.Entities.Exceptions;
using System.Globalization;

namespace Aula155Ex01Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Withdraw(amount);
                Console.WriteLine("New Balance: " + acc.Balance);
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unxpected error: " + e.Message);
            }
        }
    }
}