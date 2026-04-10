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
            // 2. Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.

            Console.Write("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 == n2 && n2 == n3)
            {
                int suma = n1 + n2;
                int resultado = suma * n3;
                Console.WriteLine("suma de los primeros 2 numeros: " + suma);
                Console.WriteLine("resultado de la multiplicacion por el tercero: " + resultado);
            }
            Console.ReadKey();
        }
    }
}
