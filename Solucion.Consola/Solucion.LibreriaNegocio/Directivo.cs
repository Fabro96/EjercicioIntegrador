using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Directivo : Empleado
    {
        //CONSTRUCTOR
        public Directivo(int legajo, string nombre, string apellido, DateTime fechaIngreso, double bruto)
        {

        }
        
        //MÉTODOS
        public override string GetNombreCompleto()
        {
            return "Sr. Directivo " + this.Apellido;
        }
    }
}
