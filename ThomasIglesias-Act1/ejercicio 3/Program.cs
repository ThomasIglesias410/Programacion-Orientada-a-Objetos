// 3. Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.



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
            int suma = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Ingrese número " + i + ": ");
                suma += int.Parse(Console.ReadLine());
            }

            int promedio = suma / 4;

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Promedio: " + promedio);
            Console.ReadKey();
        }
    }
}
