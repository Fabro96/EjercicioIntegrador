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
            string s = Console.ReadLine(); //Crear Validación de String
            return s;
        }
        public static int PedirInt(string msj)
        {
            Console.WriteLine("Ingrese " + msj);
            int i = int.Parse(Console.ReadLine());//Crear validación de Int
            return i;
        }
        public static DateTime PedirFecha(string msj)
        {
            Console.WriteLine("Ingrese " + msj + " solo en este formato YYYY-MM-DD");
            DateTime f = Convert.ToDateTime(Console.ReadLine());//Crear validación de Fecha
            return f;
        }
        public static double PedirDouble(string msj)
        {
            Console.WriteLine("Ingrese " + msj);
            double d = double.Parse(Console.ReadLine());//Crear validación de Double
            return d;
        }
    }
    
}
