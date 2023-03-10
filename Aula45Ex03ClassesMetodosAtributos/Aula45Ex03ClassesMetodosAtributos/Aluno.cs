using System;

namespace Aula45Ex03ClassesMetodosAtributos
{
    public class Aluno
    {
        public string Nome;
        public double T1, T2, T3;

        public double CalculoDasNotas()
        {
            return T1 + T2 + T3;
        }

        public bool AprovadoOuReprovado()
        {
            if (CalculoDasNotas() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (AprovadoOuReprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - CalculoDasNotas();
            }
        }
    }
}
