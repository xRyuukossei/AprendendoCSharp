﻿using System;

namespace Aula80Ex01Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main Diagonal: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i,i] + " ");
            }

            Console.WriteLine();

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers " + count);
        }
    }
}