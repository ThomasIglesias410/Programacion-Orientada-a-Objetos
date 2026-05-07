using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*1- Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
componentes por columna (es decir primero ingresar toda la primer
columna, luego la segunda columna y así sucesivamente)
Imprimir luego la matriz.*/
    internal class ejercicio1
    {
        private int[,] m;
        public void carga()
        {
            m = new int[2,5];
           
                for (int t = 0; t < 5; t++)
                { 
                    for (int a = 0; a < 2; a++)
                    {
                    Console.Write("ingresar valor de la columna " + t + ": ");
                    string linea = Console.ReadLine();
                    m[a,t] = int.Parse(linea);
                    }
                }
            for (int t = 0;t < 2; t++)
            {
                for (int a = 0; a < 5; a++)
                {
                    Console.Write(m[t,a] + " ");
                }
                Console.Write("...");
            }
        }
        static void Main(string[] args)
        {
            ejercicio1 ej1 = new ejercicio1();
            ej1.carga();
            Console.ReadKey();
        }
    }
}
