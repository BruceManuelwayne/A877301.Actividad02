using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad2
{
    class Ordenes
    {
        public int NumeroOrden { get; set; }

        public bool Asignada { get; set; }
        public Operadores OperadorOrden { get; set; }

        public static Dictionary<int, bool> dictOrdenes = new Dictionary<int, bool>();



        public static Ordenes CrearOrden()
        {
            var orden = new Ordenes();

            int num = 0;
            num++;

            orden.NumeroOrden = num;
            orden.Asignada = false;

            Console.WriteLine($"Numero de orden: {num} fue generada");

            dictOrdenes.Add(orden.NumeroOrden, orden.Asignada); 

            return orden;

        }

        public static Ordenes SeleccionarOrden()
        {
            //TODO: Recorre la lista de ordenes generados y devuelve el primero no asignado. 
            //recorrer la lista , primero que no tiene el bool verdadero , devuelve ese orden.
            throw new NotImplementedException(); 
        }
        
    }

}
