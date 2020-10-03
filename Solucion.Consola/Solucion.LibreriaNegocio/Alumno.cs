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
        public Alumno()
        {

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
            return _codigo.ToString();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
