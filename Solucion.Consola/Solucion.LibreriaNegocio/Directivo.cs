using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Directivo : Empleado
    {
        public override string GetNombreCompleto()
        {
            return "Sr. Directivo " + this.Apellido;
        }
    }
}
