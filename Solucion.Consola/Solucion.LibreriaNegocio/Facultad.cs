using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Facultad
    {
        //ATRIBUTOS
        private List<Empleado> _empleados;
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private string _nombre;

        //CONSTRUCTOR
        public Facultad(string nombre)
        {
            this._nombre = nombre;
            this._empleados = new List<Empleado>();
            this._alumnos = new List<Alumno>();
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
        public List<Alumno> Alumnos
        {
            get { return _alumnos; }
        }
        public List<Empleado> Empleados
        {
            get { return _empleados; }
        }

        public bool TieneAlumnos
        {
            get { return _alumnos.Count > 0; }
        }
        public bool TieneEmpleados
        {
            get { return _empleados.Count > 0; }
        }

        //MÉTODOS
        public void AgregarAlumno(Alumno alumno)
        {

        }
        public void AgregarEmpleado(Empleado empleado)
        {

        }
        public void EliminarAlumno(int codigo)
        {

        }
        public void EliminarEmpleado(int legajo)
        {

        }
        public void ModificarEmpleado(Empleado empleado)
        {

        }
        public List<Alumno> TraerAlumnos()
        {
            return _alumnos;
        }
        //public Empleado TraerEmpleadoPorLegajo(int legajo)
        //{
            
        //}
        public List<Empleado> TraerEmpleados()
        {
            return _empleados;
        }
        //public List<Empleado> TraerEmpleadosPorNombre(string nombre)
        //{
        //    return _nombre;
        //}


    }
}
