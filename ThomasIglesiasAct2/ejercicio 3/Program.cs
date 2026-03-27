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
            //3. Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el número tiene uno o dos dígitos.(Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)
            int num1;

            string linea;
            Console.Write("ingrese número:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            if (num1 - 100 >= 0)
            {

                Console.WriteLine("Este numero tiene mas de 2 cifras");


            }
            else {

                Console.WriteLine("Este numero tiene 1 o 2 cifras");


            }
            Console.ReadKey();

        }
    }
}
