using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Facultad
    {
        //ATRIBUTOS
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> empleados;
        private string _nombre;

        //CONSTRUCTOR
        public Facultad()
        {

        }

        //PROPIEDADES
        public int CantidadSedes
        {
            set { _cantidadSedes = value; }
            get { return _cantidadSedes;  }
        }
        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre;  }
        }

        //MÉTODOS

    }
}
