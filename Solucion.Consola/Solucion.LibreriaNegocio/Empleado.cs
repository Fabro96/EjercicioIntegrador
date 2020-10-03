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
        protected DateTime _fechaIngreso;
        protected int _legajo;
        protected List<Salario> _salarios;
        protected Salario _ultimoSalario;

        //CONSTRUCTORES
        public Empleado()
        {

        }
        public Empleado(int legajo, string nombre, string apellido)
        {
            this._legajo = legajo;
            this._nombre = nombre;
            this._apellido = apellido;
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
        public List<Salario> Salarios
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
            return string.Format("{0} - {1} - {2} $ / {3} $", this._legajo, GetNombreCompleto(), this._salarios, this._ultimoSalario) ;
        }
        public override string GetNombreCompleto()
        {
            return base.GetNombreCompleto();
        }
        public override string ToString()
        {
            return GetCredencial();
        }




    }
}
