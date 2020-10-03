using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaConsola
{
    public static class Validaciones
    {
        public static int ValidarNumero(string mensaje)
        {
            int res;
            Console.WriteLine(mensaje);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("Ingrese un número válido por favor");
                    res = -1;
                }
            } while (res != 0 && res != 1);
            return res;
        }

        public static int ValidarOpcionMenu(int min, int max, string mensaje)
        {
            int res;
            Console.WriteLine(mensaje);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("Ingrese un número válido por favor.");
                    res = -1;
                }
            } while (res < min || res > max);
            return res;
        }
        public static string ValidarString(string input)
        {
            do
            {
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("\nIntentelo nuevamente");
                    input = Console.ReadLine();
                }

            } while (1 == 1);
        }
        
            
    }
}

