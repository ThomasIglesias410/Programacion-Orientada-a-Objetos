using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5. Determinar en qué cuadrante se encuentra un punto (x, y).

            Console.Write("Ingrese valor de X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese valor de Y: ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Primer Cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Segundo Cuadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Tercer Cuadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Cuarto Cuadrante");
            }
            Console.ReadKey();
        }
    }
}
