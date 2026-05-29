using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
(crearla sin la intervención del operador)
Realizar la carga por teclado e imprimir posteriormente.*/
    internal class ejercicio2
    {
        private int[][] mat;
        public void declarar()
        {
            mat = new int[5][];
           
                for (int a = 0; a < mat.Length; a++)
                {
                    
                    mat[a] = new int[a+1];
                    Console.WriteLine(mat[a].Length);
                
                }


        }
        public void cargar()
        {
            for(int a=0; a<mat.Length;a++)
            {
                for (int t=0;t<mat[a].Length;t++)
                {
                    Console.WriteLine("cargar fila " + (a+1)+" columna "+(t+1)+": ");
                    string linea = Console.ReadLine();
                    mat[a][t] = int.Parse(linea);
                }
            }
        }
        public void imprimir()
        {
            for (int a = 0; a < mat.Length; a++)
            {
                for (int t = 0; t < mat[a].Length; t++)
                {
                    Console.Write(mat[a][t]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ejercicio2 ej2 = new ejercicio2();
            ej2.declarar();
            ej2.cargar();
            ej2.imprimir();
            Console.ReadKey();
        }
    }
}
