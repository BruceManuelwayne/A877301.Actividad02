using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad2
{
    class Operadores
    {
         
        
        public int NumeroOperador { get; set; }

        public List<int> ordenesOperador { get; set; }


        public static Dictionary<int, Ordenes[]> dictOrdenesOper = new  Dictionary<int, Ordenes[]>(); 






        public static void AsignarOrden() 
        {
            //TODO asigno un orden a un operador
            throw new NotImplementedException(); 
        }

        public static bool Existe(int numOperador)
        {
            //TODO: verifica si ya existe el numero
            throw new NotImplementedException(); 
        }
        


        public static Operadores IngresarOperadores()
        {
            //TODO Ingresar un nuevo operador
            var operador = new Operadores();
            Console.WriteLine("Nuevo Operador");

            Console.WriteLine("Ingrese Numero de Operador(numero entero)");
            do 
            {
                var ingreso = Console.ReadLine();

                if (!int.TryParse(ingreso, out var numeroOperador))
                {
                    Console.WriteLine("No ha ingresado un numero valido");
                    continue;
                }
                if (Existe(numeroOperador))
                {
                    Console.WriteLine("Ya existe ese numero de operador");
                    continue;
                }
                operador.NumeroOperador = numeroOperador; 
                

            } while (operador.NumeroOperador == 0);
            
           

            return operador;

        }

    }
    
}
