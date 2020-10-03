using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Alumno : Persona
    {
        //ATRIBUTOS
        private int _codigo;

        //CONSTRUCTOR
        public Alumno(int codigo, string nombre, string apellido, DateTime fechaNaciemiento)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNacimiento = fechaNaciemiento;
        }
        
        //PROPIEDADES
        public int Codigo
        {
            set { _codigo = value; }
            get { return _codigo; }
        }
        public string Credencial
        {
            get { return GetCredencial(); }
        }

        //MÉTODOS
        public override string GetCredencial()
        {
            return string.Format("{0} - {1}, {2}", this._codigo, this._apellido, this._nombre);
        }
        public override string ToString()
        {
            return GetCredencial();
        }
    }
}
