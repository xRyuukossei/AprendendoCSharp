using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula155Ex01Excecoes.Entities.Exceptions
{
    internal class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message) { }
    }
}
