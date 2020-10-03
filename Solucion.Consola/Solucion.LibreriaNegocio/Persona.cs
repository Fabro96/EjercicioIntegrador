using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public abstract class Persona
    {
        //ATRIBUTOS
        protected string _nombre;
        protected string _apellido;
        protected DateTime _fechaNacimiento;


        //PROPIEDADES
        public string Nombre
        {
            set { _nombre = value;}
            get { return _nombre; }
        }
        public string Apellido
        {
            set { _apellido = value; }
            get { return _apellido; }
        }
        public int Edad //Revisar
        {
            set { _fechaNacimiento = Convert.ToDateTime(value); }
            get { return DateTime.Now.Year - _fechaNacimiento.Year; }
        }

        //MÉTODOS
        public abstract string GetCredencial();

        public virtual string GetNombreCompleto()
        {
            return string.Format("{0} {1}", this._apellido, this._nombre);
        }


    }
}
