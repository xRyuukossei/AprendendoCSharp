using System;
using System.Globalization;

namespace Ex1MembrosEstaticos
{
    public static class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double Conversao(double dolar, double quantidade)
        {
            double total = quantidade * dolar;
            return total + total * Iof / 100.0;
        }
    }
}
