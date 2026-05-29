using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*3. Academia de Gastronomía: Recetario Dinámico
Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
● Definir un vector para los nombres de los alumnos.
● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
presentado.
● Métodos:
1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
de cada alumno.
2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
4. Calcular el puntaje promedio de cada alumno e informar si está &quot;Aprobado&quot;
(promedio &gt;= 70) o &quot;Reprobado&quot;.
5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
valor máximo de la matriz).*/
    internal class ejercicio3
    {
        private string[] nom;
        private int[][] punt;
        public ejercicio3()
        {
            nom = new string[3];
            punt = new int[3][];
            int cant = 0;
            for (int a = 0; a < 3; a++)
            {
                Console.Write("nombre del alumno: ");
                nom[a] = Console.ReadLine();
                Console.Write("cantidad platos presentados: ");
                string linea = Console.ReadLine();
                cant = int.Parse(linea);
                punt[a] = new int[cant];
                for (int t = 0; t < cant; t++)
                {
                    do
                    {
                        Console.Write("nota del plato(0~100): ");
                        linea = Console.ReadLine();
                        punt[a][t] = int.Parse(linea);
                    } while (punt[a][t] > 100 || punt[a][t] < 0);
                }

            }
        }
        public void mostrar()
        {
            for (int a = 0; a < punt.Length; a++)
            {
                Console.Write(nom[a] + ": ");
                for (int t = 0; t < punt[a].Length; t++)
                {
                    Console.Write(punt[a][t] + " ");
                }
                Console.WriteLine();
            }
        }
        public void promedio()
        {
            float prom = 0;
            for (int a = 0; a < punt.Length; a++)
            {
                prom = 0;
                for (int t = 0; t < punt[a].Length; t++)
                {
                    prom = prom + punt[a][t];
                }
                prom = prom / punt[a].Length;
                Console.WriteLine("el promedio de " + nom[a] +" es de " + prom);
            }
        }
        public void mayor()
        {
            int may = punt[0][0];
            for (int a = 0; a < punt.Length; a++)
            {
                for (int t = 0; t < punt[a].Length; t++)
                {
                    if (punt[a][t] > may)
                    {
                        may = punt[a][t];
                    }
                }
            }
            Console.WriteLine("el puntaje individual mas alto fue de: " + may);
        }
        static void Main(string[] args)
        {
            ejercicio3 ej3 = new ejercicio3();
            ej3.mostrar();
            ej3.promedio();
            ej3.mayor();
            Console.ReadKey();
        }
    }
}
