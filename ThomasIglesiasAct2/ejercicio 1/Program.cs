using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su suma y diferencia, en caso contrario informar el producto y la división del primero respecto al segundo.
            int num1, num2, suma, producto, diferencia, division;
           
            string linea;
            Console.Write("ingrese el primer número:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("ingrese el segundo número:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            suma = num1 + num2;
            producto = num1 * num2;
            diferencia = num2 - num1;
            division=num2/num1;
            if (num1 > num2)
            {

                Console.WriteLine("suma: " + suma);
                Console.WriteLine("diferencia: " + diferencia);

            }
            else {

                Console.WriteLine("producto: " + producto);
                Console.WriteLine("division: " + division);


            }
            Console.ReadKey();
        }
    }
}
