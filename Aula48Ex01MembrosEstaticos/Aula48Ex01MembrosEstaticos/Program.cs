﻿using System;
using System.Globalization;

namespace Ex1MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = "
                + ConversorDeMoeda.Conversao(dolar, quantidade).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}