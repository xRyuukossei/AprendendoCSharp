﻿using System;
using System.Runtime.Serialization;

namespace Aula24Ex1EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}