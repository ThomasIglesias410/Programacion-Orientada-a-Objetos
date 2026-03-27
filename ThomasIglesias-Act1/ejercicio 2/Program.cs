// 2. Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el cuarto número: ");
            int n4 = int.Parse(Console.ReadLine());

            int suma = n1 + n2;
            int producto = n3 * n4;

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Producto: " + producto);
            Console.ReadKey();
        }
    }
}
