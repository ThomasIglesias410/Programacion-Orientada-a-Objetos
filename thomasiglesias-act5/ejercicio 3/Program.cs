using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
a) La cantidad de valores ingresados negativos.
b) La cantidad de valores ingresados positivos.
c) La cantidad de múltiplos de 15.
d) El valor acumulado de los números ingresados que son pares.*/

            int n;
            int neg = 0;
            int pos = 0;
            int mul = 0;
            int par = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("ingrese un número: ");
                string linea = Console.ReadLine();
                n = int.Parse(linea);
                if (n > 0) { pos++; }
                if (n < 0) { neg++; }
                if (n%15 == 0) { mul++; }
                if (n%2 == 0) { par=par+n; }

            }
            Console.WriteLine("la cantidad de positivos es: " + pos);
            Console.WriteLine("la cantidad de negativos es: " + neg);
            Console.WriteLine("los multiplos de 15 son: " + mul);
            Console.WriteLine("el valor acumulado de los numeros pares es: " + par);
        }
    }
}
