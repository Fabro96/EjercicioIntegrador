using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class NombreInvalidoException : Exception
    {
        public NombreInvalidoException()
            : base("El nombre recibido no es válido.")
        {

        }

        public NombreInvalidoException(string s)
            : base("El nombre recibido (" + s + ") no es válido.")
        {

        }

    }
}
