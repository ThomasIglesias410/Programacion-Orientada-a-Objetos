using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta
ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el
valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.*/
            int num;
            int acum = 0;
           
            string linea;
            Console.Write("ingrese un número: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            while (num != 9999) {

                acum = acum + num;

                Console.Write("ingrese un número: ");
                linea = Console.ReadLine();
                num = int.Parse(linea);


            }

            Console.WriteLine("total= "+acum);
            if(acum < 0)
            {
                Console.WriteLine("el valor acumulado es menor a 0");
            }
            else if (acum > 0)
            {
                Console.WriteLine("el valor acumulado es mayo a 0");
            }
            else
            {
                Console.WriteLine("el valor acumulado es 0");
            }
            Console.ReadKey();
        }
    }
}
