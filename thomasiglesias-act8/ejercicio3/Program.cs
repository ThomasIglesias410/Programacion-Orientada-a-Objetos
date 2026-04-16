using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
(el orden lo pueden elegir ustedes).*/
    internal class actividad8
    {
        private int[] v;
        public void cargar() 
        {
            Console.Write("numero de elementos del vector: ");
            string linea= Console.ReadLine();
            int n = int.Parse(linea);
            v = new int[n];
            for ( int i = 0; i < n; i++ )
            {
                Console.Write("numero de elementos del vector: ");
                linea = Console.ReadLine();
                v[i] = int.Parse(linea);
            }
        }
        public void ordenar()
        {
            for (int i = 0; i < v.Length - 1; i++)
            {
                if (v[i] > v[i + 1])
                {
                    int aux = v[i];
                    v[i] = v[i + 1];
                    v[i + 1] = aux;
                }
            }
        }
        static void Main(string[] args)
        {
            actividad8 act8 = new actividad8();
            act8.cargar();
            act8.ordenar();
            Console.ReadKey();
        }
    }
}
