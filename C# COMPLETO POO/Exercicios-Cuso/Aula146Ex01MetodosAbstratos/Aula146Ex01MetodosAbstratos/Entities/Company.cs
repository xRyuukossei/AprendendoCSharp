namespace Aula146Ex01MetodosAbstratos.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberEmployee { get; set; }

        public Company() { }
        public Company(string name, double anualIncome, int numberEmployee)
            : base(name, anualIncome)
        {
            NumberEmployee = numberEmployee;
        }

        public override double TaxesPaid()
        {
            double tax = 0;
            if (NumberEmployee < 10)
            {
                tax = (AnualIncome * 0.16);
            }
            else
            {
                tax = (AnualIncome * 0.14);
            }

            return tax;
        }
    }
}
