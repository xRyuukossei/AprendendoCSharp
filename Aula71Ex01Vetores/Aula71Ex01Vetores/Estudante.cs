namespace Aula71Ex01Vetores
{
    class Estudante
    {
        public string Nome;
        public string Email;
        public int Quarto;

        public override string ToString()
        {
            return Quarto
                + ": "
                + Nome
                + ", "
                + Email;
        }

    }
}
