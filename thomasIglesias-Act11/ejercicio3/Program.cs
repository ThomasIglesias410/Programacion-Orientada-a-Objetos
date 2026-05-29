using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
empresa.
Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
irregular para cargar los días que han faltado cada empleado (cargar el número de día que
faltó)
Cada fila de la matriz representa los días de cada empleado.
a. Mostrar los empleados con la cantidad de inasistencias.
b. Cuál empleado faltó menos días.*/
    internal class ejercicio3
    {
        private string[] emp;
        private int[][] dia;
        public ejercicio3()
        {
           emp = new string[3];
           dia = new int[3][];
            for (int a = 0; a < 3; a++)
            {
                Console.Write("nombre de empleado: ");
                emp[a] = Console.ReadLine();
                Console.Write("cantidad de dias que faltó: ");
                string linea = Console.ReadLine();
                int i = int.Parse(linea);
                dia[a] = new int[i];
                for (int t = 0; t < i; t++)
                {
                    Console.Write("numero de dia que falto: ");
                    linea = Console.ReadLine();
                    dia[a][t] = int.Parse(linea);
                }
            }
        }
        public void mostrar()
        {
            for (int a = 0; a < 3; a++)
            {
                Console.Write(emp[a] + ": "+ dia[a].Length+" ");
            }
            Console.WriteLine();
        }
        public void menosdias()
        {
            string nombre = "";
            int men = 10000;
            for (int a = 0; a < 3; a++)
            {
                if (men > dia[a].Length)
                {
                    nombre = emp[a];
                    men = dia[a].Length;
                }
            }
            Console.WriteLine("el empleado que falto menos dias es " + nombre + ", faltó " + men + " dia(s).");
        }
        static void Main(string[] args)
        {
            ejercicio3 ej3 = new ejercicio3();
            ej3.mostrar();
            ej3.menosdias();
            Console.ReadKey();

        }
    }
}
