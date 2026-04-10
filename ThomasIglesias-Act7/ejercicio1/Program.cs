using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
El valor acumulado de todos los elementos del vector.
El valor acumulado de los elementos del vector que sean mayores a 36.
Cantidad de valores mayores a 50.*/
    internal class ejercicio1
    {
        private int[] v;
        public void ValorAcumulado()
        {
            v = new int[8];
            int ValAc = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.Write("ingrese un valor: ");
                string linea = Console.ReadLine();
                v[i] = int.Parse(linea);

                ValAc = ValAc + v[i];


            }
            Console.Write("Valor acumulado: ");
            Console.WriteLine(ValAc);
        }
        public void Val36()
        {
            
            int Val = 0;
            for (int i = 0; i < 8; i++)
            {
                if (v[i] > 36) 
                { 
                 
                    Val = Val + v[i];

                }

            }
            Console.Write("Valor acumulado de mas de 36: ");
            Console.WriteLine(Val);
        }
        public void cant50()
        {
            
            int cant = 0;
            for (int i = 0; i < 8; i++)
            {
                if (v[i] > 50)
                {

                    cant++;
                }

            }
            Console.Write("valores mayores a 50: ");
            Console.WriteLine(cant);
        }
        static void Main(string[] args)
        {

            ejercicio1 ej1 = new ejercicio1();
            ej1.ValorAcumulado();
            ej1.Val36();
            ej1.cant50();
            Console.ReadKey();

        }
    }
}
