using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
etc.)*/
    internal class ejercicio3
    {
        private int[,] m;
        public void cargar()
        {
            Console.Write("numero de filas: ");
            string linea = Console.ReadLine();
            int x = int.Parse(linea);

            Console.Write("numero de columnas: ");
            linea = Console.ReadLine();
            int y = int.Parse(linea);
            m = new int[x, y];
            for (int a = 0; a < x; a++)
            {
                for (int t = 0; t < y; t++)
                {
                    Console.Write("ingrese valor: ");
                    linea = Console.ReadLine();
                    m[a, t] = int.Parse(linea);
                }
            }
            imprimir();
        }
        public void imprimir()
        {
            Console.WriteLine();
            for (int a = 0; a < m.GetLength(0); a++)
            {
                for (int t = 0; t < m.GetLength(1); t++)
                {
                    Console.Write(m[a, t] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("valores de los vertices");
            Console.Write(m[0,0]+" ");
            Console.WriteLine(m[0, m.GetLength(1)-1]);
            Console.Write(m[m.GetLength(0) - 1,0]+" ");
            Console.WriteLine(m[m.GetLength(0) - 1, m.GetLength(1) - 1]);
        }
        static void Main(string[] args)
        {
            ejercicio3 ej3 = new ejercicio3();
            ej3.cargar();
            Console.ReadKey();
        }
    }
}
