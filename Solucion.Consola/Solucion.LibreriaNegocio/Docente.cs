using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Docente : Empleado
    {

        //CONSTRUCTOR
        public Docente(int legajo, string nombre, string apellido, DateTime fechaIngreso, double bruto)
        {

        }
        //MÉTODOS
        public override string GetNombreCompleto()
        {
            return "Docente " + this.Apellido;
        }
    }
}
