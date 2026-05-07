using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
primer fila con la segunda. Imprimir luego la matriz.*/
    internal class ejercicio2
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
                for(int t = 0; t < y; t++)
                {
                    Console.Write("ingrese valor: ");
                    linea = Console.ReadLine();
                    m[a,t] = int.Parse(linea);
                }
            }
            imprimir();
        }
        public void intercambiar()
        {
            int[] aux = new int[m.GetLength(1)];
            
                for (int a= 0; a<m.GetLength(1);a++)
                {
                    aux[a] = m[0, a];
                    m[0, a] = m[1, a];
                    m[1, a] = aux[a];
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
                    Console.Write(m[a, t]+" ");
                }
                Console.WriteLine();
            }
        }
            static void Main(string[] args)
            {
            ejercicio2 ej2 = new ejercicio2();
            ej2.cargar();
            ej2.intercambiar();
            Console.ReadKey();
            }
    }
}
