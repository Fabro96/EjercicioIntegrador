using Solucion.LibreriaConsola;
using Solucion.LibreriaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion;

            //INSTANCIO OBJETO FACULTAD
            Facultad FCE = new Facultad("FCE");

            //INGRESO AL SISTEMA
            Console.WriteLine("Bienvenidos a " + FCE.Nombre);
            Console.WriteLine("\nIngrese una tecla para ingresar al Menú Principal.");
            Console.ReadKey();

            do
            {
                Console.Clear();
                Console.WriteLine("MENÚ PRINCIAL:");

                Console.WriteLine("\n   1 - LISTAR ALUMNOS" +
                                  "\n   2 - LISTAR EMPLEADOS" +
                                  "\n   3 - AGREGAR ALUMNO" +
                                  "\n   4 - AGREGAR EMPLEADO" +
                                  "\n   5 - BORRAR ALUMNO" +
                                  "\n   6 - BORRAR EMPLEADO" +
                                  "\n   7 - EXIT");

                opcion = Validaciones.ValidarOpcionMenu(1, 7, "\nINGRESE LA OPCIÓN QUE DESEE VER:");

                try
                {
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            //Listar Alumnos
                            Program.ListarAlumnos(FCE);
                            break;
                        case 2:
                            //Listar Empleados
                            Program.ListarEmpleados(FCE);
                            Console.ReadKey();
                            break;
                        case 3:
                            //Agregar Alumno
                            Program.AgregarAlumno(FCE);
                            break;
                        case 4:
                            //Agregar Empleado
                            Program.AgregarEmpleado(FCE);
                            Console.ReadKey();
                            break;
                        case 5:
                            //Borrar Alumno
                            Program.BorrarAlumno(FCE);
                            break;
                        case 6:
                            //Borrar Empleado
                            Program.BorrarEmpleado(FCE);
                            break;
                        case 7:
                            //Salir del Programa
                            Program.Exit();
                            break;
                        default:
                            Console.WriteLine("Opción Inválida");
                            break;
                    }

                }catch(Exception ex)
                {
                    Console.WriteLine("\nLo sentimos, hubo un error en el sistema." + ex.Message);
                }

            } while (opcion <= 6);

        }
        public static void ListarAlumnos(Facultad facultad)
        {
            if (facultad.TieneAlumnos)
            {
                foreach(Alumno alumno in facultad.Alumnos)
                {
                    facultad.TraerAlumnos();
                }
            }
            else
            {
                Console.WriteLine("No hay alumnos cargados en el sistema.");
            }
        }
        public static void ListarEmpleados(Facultad facultad)
        {
            if (facultad.TieneEmpleados)
            {
                foreach(Empleado empleado in facultad.Empleados)
                {
                    facultad.TraerEmpleados();
                }
            }
            else
            {
                Console.WriteLine("No hay empleados cargados en el sistema");
            }

        }
        public static void AgregarAlumno(Facultad facultad)
        {

        }
        public static void AgregarEmpleado(Facultad facultad)
        {
            try
            {
                string nombre = ConsolaHelper.PedirString("Nombre: ");
                string apellido = ConsolaHelper.PedirString("Apellido: ");
                int legajo = ConsolaHelper.PedirInt("Legajo: ");
                string TipoEmpleado = ConsolaHelper.PedirString("tipo empleado (D Docente, B Bedel, A Directivo)");
                DateTime fechaIngreso = ConsolaHelper.PedirFecha("Fecha de Ingreso: ");

                string apodo = string.Empty;
                if (TipoEmpleado.ToUpper() == "B")
                {
                    apodo = ConsolaHelper.PedirString("Apodo");
                }

                double bruto = ConsolaHelper.PedirDouble("Salario Bruto");

                facultad.AgregarEmpleado(nombre, apellido, legajo, TipoEmpleado, fechaIngreso, apodo, bruto);
                Console.WriteLine("\nEmpleado Agregado.");

            } catch (Exception ex)
            {
                Console.WriteLine("Error en uno de los datos ingresado. " + ex.Message);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
        public static void BorrarAlumno(Facultad facultad)
        {

        }
        public static void BorrarEmpleado(Facultad facultad)
        {

        }
        public static void Exit()
        {
            Console.WriteLine("Muchas gracias por haber usado la app! Nos vemos la próxima :)");
            Console.WriteLine("\nIngrese una tecla y se cerrara el progrma.");
            Console.ReadKey();
        }
    }
}
