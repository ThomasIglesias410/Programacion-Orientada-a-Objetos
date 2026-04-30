using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
vectores paralelos, ordenar los datos de mayor a menor según las ventas,
imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
el que menos vendió de los 5 empleados.*/
    internal class ejercicio2
    {
        private string[] vend;
        private int[] vent;
        public void cargar()
        {
            vend = new string[5];
            vent = new int[5];
            for (int i = 0; i < vend.Length; i++)
            {

                Console.Write("ingrese el nombre del vendedor: ");
                string linea = Console.ReadLine();
                vend[i] = linea;
                Console.Write("ingrese el total de ventas del vendedor: ");
                linea = Console.ReadLine();
                vent[i] = int.Parse(linea);
            }
        }
        public void ordenarMayor()
        {
            string aux;
            int auxi;
            Console.WriteLine("datos ordenados de mayor a menor segun las ventas: ");
            for (int i = 0; i < vend.Length; i++)
            {
                if (vent[i] < vent[1 + i])
                {
                    aux = vend[i];
                    vend[i] = vend[i + 1];
                    vend[i + 1] = aux;

                    auxi = vent[i];
                    vent[i] = vent[i + 1];
                    vent[i + 1] = auxi;
                }
                Console.WriteLine(vend[i] + ": " + vent[i]);
            }
            Console.WriteLine("el que menos vendio fue: "+ vend[4] );
        }
        static void Main(string[] args)
        {
            ejercicio2 ej2 = new ejercicio2();
            ej2.cargar();
            ej2.ordenarMayor();
            Console.ReadLine();
        }
    }
}
