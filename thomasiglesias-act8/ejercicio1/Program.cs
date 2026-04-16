using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
del vector.*/
    internal class actividad8
    {
        private int[] v;
        public void cargar()
        {
            Console.Write("numero de elementos: ");
            string linea = Console.ReadLine();
            int n = int.Parse(linea);
            v = new int[n];
            int menor = 1000000000;
            for (int i = 0; i < n; i++)
            {

                Console.Write("numero de elementos: ");
                linea = Console.ReadLine();
                v[i] = int.Parse(linea);
                if (v[i]<menor)
                {
                    menor = v[i];
                }
                if(v[i]==menor)
                {
                    Console.Write("este numero se repite");
                }

            }
        
        
        }
        static void Main(string[] args)
        {
            actividad8 act8 = new actividad8();
            act8.cargar();
            Console.ReadKey();
        }
    }
}
