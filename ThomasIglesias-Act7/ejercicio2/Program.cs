using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
tercer vector del mismo tamaño. Sumar componente a componente.*/
    internal class ejercicio2
    {

        private int[] v1;
        private int[] v2;
        private int[] v3;
        public void cargar() 
        { 
        
            v1 = new int[4];
            v2 = new int[4];
            for (int i = 0; i < 4; i++) 
            {

                Console.Write("ingrese el valor del primer vector: ");
                string linea = Console.ReadLine();
                v1[i] = int.Parse(linea);
                Console.Write("ingrese el valor del segundo vector: ");
                linea = Console.ReadLine();
                v2[i] = int.Parse(linea);
            }
        
        
        
        }

        public void suma()
        {

            v3 = new int[4];
            for (int i = 0; i < 4; i++)
            {

                v3[i] = v1[i] + v2[i];
                Console.WriteLine(v3[i]);
            }



        }

        static void Main(string[] args)
        {

            ejercicio2 ej2 = new ejercicio2();
            ej2.cargar();
            ej2.suma();
            Console.ReadKey();

        }
    }
}
