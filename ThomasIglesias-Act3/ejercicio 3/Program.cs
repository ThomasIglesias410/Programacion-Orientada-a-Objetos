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
            // 3. Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, imprimir mensaje.

            Console.Write("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 < 10 && n2 < 10 && n3 < 10)
            {
                Console.WriteLine("Todos los números son menores a diez");
            }
            Console.ReadKey();
        }
    }
}
