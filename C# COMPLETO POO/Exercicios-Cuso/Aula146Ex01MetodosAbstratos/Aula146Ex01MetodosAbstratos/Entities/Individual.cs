﻿namespace Aula146Ex01MetodosAbstratos.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() { }
        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            double tax = 0;
            if (AnualIncome < 20000.00)
            {
                tax = (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                tax = (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }

            return tax;
        }
    }
}
