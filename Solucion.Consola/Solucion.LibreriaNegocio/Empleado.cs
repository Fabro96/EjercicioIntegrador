using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public abstract class Empleado : Persona
    {
        //ATRIBUTOS
        private DateTime _fechaIngreso;
        private int _legajo;
        private List<Salario> _salarios;
        private Salario _ultimoSalario;

        //CONSTRUCTOR
        public Empleado()
        {

        }

        //PROPIEDADES
        public int Antiguedad //Revisar
        {
            set { _fechaIngreso = Convert.ToDateTime(value); }
            get { return DateTime.Now.Year - _fechaIngreso.Year; }
        }
        public DateTime FechaIngreso
        {
            set { _fechaIngreso = value; }
            get { return _fechaIngreso;  }
        }
        public DateTime FechaNacimiento
        {
            set { _fechaNacimiento = value; }
            get { return _fechaNacimiento;  }
        }
        public int Legajo
        {
            set { _legajo = value; }
            get { return _legajo;  }
        }
        public List<Salario> Salario
        {
            set { _salarios = value; }
            get { return _salarios;  }
        }
        public Salario UltimoSalario
        {
            set { _ultimoSalario = value; }
            get { return _ultimoSalario;  }
        }

        //MÉTODOS
        public void AgregarSalario(Salario salario)
        {

        }
        //public bool Equals(Object obj)
        //{

        //}
        public override string GetCredencial()
        {
            return _legajo.ToString();
        }
        public override string GetNombreCompleto()
        {
            return base.GetNombreCompleto();
        }
        public override string ToString()
        {
            return base.ToString();
        }




    }
}
