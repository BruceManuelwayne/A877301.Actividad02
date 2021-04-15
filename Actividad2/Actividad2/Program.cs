using System;
using System.Collections.Generic;

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Ordenes> listaOrdenes = new List<Ordenes>();
             bool salir = false;

            do
            {
                Console.WriteLine("MENU PRINCIPAL:");
                Console.WriteLine("----------------");

                Console.WriteLine("1-Ingrese Operador");
                Console.WriteLine("2-Ingrese Orden De Trabajo ");
                Console.WriteLine("3-Asignar Orden a Operador");
                Console.WriteLine("4-Generar Reporte");
                Console.WriteLine("0-Salir");

                Console.WriteLine("Ingrese una opcion y presione [Enter]"); 

                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        IngresarOperador();
                        break;
                    case "2":
                        IngresarOrden();
                        break;
                    case "3":
                        AsignarOrden();
                        break;
                    case "4":
                        GenerarReporte();
                        break; 
                    case "0":
                        salir=true;
                        break;
                    default:
                        Console.WriteLine("No ha ingresado una opcion del menu, reintente por favor.");
                        break; 


                }


            } while (!salir); 



        }
        private static void IngresarOperador()
        {
            bool terminar = false;
            do
            {
                var operador = Operadores.IngresarOperadores();
                Console.WriteLine("Ingresar otro Operador? S/N");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.N)
                {
                    terminar = true;
                }
            } while (!terminar); 
           
        }
        private static void IngresarOrden()
        {
            bool terminar = false;
            do
            {
                Ordenes.CrearOrden();
                
                Console.WriteLine($"Orden Generada");

                Console.WriteLine(" Quisieras generar otra orden? (S/N)");
                var key = Console.ReadKey(true); 
                if(key.Key == ConsoleKey.N)
                {
                    terminar = true; 
                }
            } while (!terminar);
          

        }

        private static void AsignarOrden()
        {

        }

        private static void GenerarReporte()
        {

        }

       
    }
}
