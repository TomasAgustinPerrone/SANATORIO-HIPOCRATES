using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Excepciones
{
    public class ElementoNoEncontrado : Exception
    {
        public ElementoNoEncontrado(string message) : base(message)
        {
        }
    }
}
