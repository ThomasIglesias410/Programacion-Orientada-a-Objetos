using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
algoritmo de ordenamiento alfabético.*/
    internal class actividad8
    {
        private string[] paises;
        public void cargar() 
        {
            paises = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("escribir nombre de un pais: ");
                string linea = Console.ReadLine();
                paises[i] = linea;
            }
        }
        public void ordenar()
        {
            string aux;
            for (int i = 0; i < 4; i++)
            {
                if (paises[i].CompareTo(paises[i + 1]) > 0)
                {
                    aux = paises[i];
                    paises[i] = paises[i + 1];
                    paises[i + 1] = aux;
                }
            }
        }
        public void mostrar()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(paises[i]);
            }
        }
        static void Main(string[] args)
        {
            actividad8 act8 = new actividad8();
            act8.cargar();
            act8.ordenar();
            act8.mostrar();
            Console.ReadKey();
        }
    }
}
