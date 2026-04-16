using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    /*4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
nuevamente.*/
    internal class actividad8
    {
        private string[] paises;
        private int[] hab;
        public void cargar() 
        {
            paises = new string[5];
            hab = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("cargar pais: ");
                string linea = Console.ReadLine();
                paises[i] = linea;
                Console.Write("numero de habitantes: ");
                linea = Console.ReadLine();
                hab[i] = int.Parse(linea);
            }
        }
        public void ordenarAlf()
        {
            string aux;
            int auxi;
            Console.WriteLine("paises ordenados alfabeticamente: ");
            for (int i = 0; i < 4; i++)
            {
                if (paises[i].CompareTo(paises[i + 1]) > 0)
                {
                    aux = paises[i];
                    paises[i] = paises[i + 1];
                    paises[i + 1] = aux;

                    auxi = hab[i];
                    hab[i] = hab[i + 1];
                    hab[i + 1] = auxi;
                }
                Console.WriteLine(paises[i]);
            }
            Console.WriteLine(paises[4]);
        }
        public void ordenarHab()
        {
            string aux;
            int auxi;
            Console.WriteLine("paises ordenados por habitantes: ");
            for (int i = 0; i < 4; i++)
            {
                if (hab[i] > hab[1+i])
                {
                    aux = paises[i];
                    paises[i] = paises[i + 1];
                    paises[i + 1] = aux;

                    auxi = hab[i];
                    hab[i] = hab[i + 1];
                    hab[i + 1] = auxi;
                }
                Console.WriteLine(paises[i]+": " + hab[i]);
            }
            Console.WriteLine(paises[4] + ": " + hab[4]);
        }
        static void Main(string[] args)
        {
            actividad8 act8 = new actividad8();
            act8.cargar();
            act8.ordenarAlf();
            act8.ordenarHab();
            Console.ReadKey();
        }
    }
}
