using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Excepciones
{
    public class PersonaNoExisteException : Exception
    {
        public PersonaNoExisteException(string message) : base(message)
        {
        }
    }
}
