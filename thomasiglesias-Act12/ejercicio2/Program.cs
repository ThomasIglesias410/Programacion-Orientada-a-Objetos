using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*2. Gestión de Complejo de Cine
Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
● Definir una matriz irregular de 4 filas para representar los asientos.
● Métodos:
1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
intervención del operador).
2. Crear un método de &quot;Venta de Entradas&quot; que permita cargar la edad del
espectador en un asiento específico (fila y columna).
3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
en cada asiento.
4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
5. Informar cuál es el promedio de edad de los espectadores de todo el
complejo.*/
    internal class ejercicio2
    {
        private int[][] mat;
        public ejercicio2()
        {
            mat = new int[4][];
            mat[0] = new int[10];
            mat[1] = new int[15];
            mat[2] = new int[8];
            mat[3] = new int[12];

        }
        public void ventaDeEntradas()
        {
            int fila = 0;
            int columna = 0;
            string linea;
            do 
            {
                Console.Write("elija la fila: ");
                linea = Console.ReadLine();
                fila = int.Parse(linea);
                Console.Write("elija la columna: ");
                linea = Console.ReadLine();
                columna = int.Parse(linea);
                Console.Write("coloque su edad: ");
                linea = Console.ReadLine();
                mat[(fila-1)][(columna-1)] = int.Parse(linea);
                Console.Write("-1 para terminar el proceso, cualquier otro numero para continuar: ");
                linea = Console.ReadLine();
                columna = int.Parse(linea);

            } while (columna!=-1);
        }
        public void mapa()
        { 
            for (int a = 0; a < mat.Length; a++)
            {
                for (int t = 0; t < mat[a].Length; t++)
                {
                    Console.Write(mat[a][t]+" ");
                }
                Console.WriteLine();
            }

        }
        public void menores()
        {
            int m = 0;
            for (int a = 0; a < mat.Length; a++)
            {
                m = 0;
                for (int t = 0; t < mat[a].Length; t++)
                {
                    if(mat[a][t] < 18)
                    {
                        m++;
                    }
                }
                Console.WriteLine("en la sala "+(a+1)+" hay "+m+" menores de edad");
            }

        }
        public void promedio()
        {
            float prom = 0;
            for (int a = 0; a < mat.Length; a++)
            {
                for (int t = 0; t < mat[a].Length; t++)
                {
                    prom = prom + mat[a][t];
                }
                Console.WriteLine();
            }
            prom = prom / 45;
            Console.WriteLine("el promedio de las edades de las salas es de "+prom);
        }

        static void Main(string[] args)
        {
            ejercicio2 ej2 = new ejercicio2();
            ej2.ventaDeEntradas();
            ej2.mapa();
            ej2.menores();
            ej2.promedio();
            Console.ReadKey();
        }
    }
}
