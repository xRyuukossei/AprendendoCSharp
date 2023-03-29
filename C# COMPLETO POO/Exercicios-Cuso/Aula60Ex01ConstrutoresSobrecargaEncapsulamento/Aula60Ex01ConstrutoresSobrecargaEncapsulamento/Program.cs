using System;
using System.Globalization;

namespace Aula60Ex01ConstrutoresSobrecargaEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, nome);
            }

            Console.WriteLine("\nDados da Conta: " + conta);

            Console.Write("Entre um valor para depósito: ");
            double valorDepositado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDepositado);

            Console.WriteLine("\nDados da conta atualizados: " + conta);

            Console.Write("Entre um valor para saque: ");
            double valorSacado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSacado);

            Console.WriteLine("\nDados da conta atualizados: " + conta);
        }
    }
}