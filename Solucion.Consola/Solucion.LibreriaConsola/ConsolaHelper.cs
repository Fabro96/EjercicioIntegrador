using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaConsola
{
    public static class ConsolaHelper
    {
        public static string PedirString(string msj)
        {
            Console.WriteLine("Ingrese " + msj);
            string n = Console.ReadLine(); //Crear Validación de String
            return n;
        }
    }
}
