/* 5. Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo (La circunferencia se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).
*/

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
            Console.Write("Ingrese el radio: ");
            int radio = int.Parse(Console.ReadLine());

            float pi = 3.14f;

            float circunferencia = 2 * pi * radio;
            float area = pi * radio * radio;

            Console.WriteLine("Circunferencia: " + circunferencia);
            Console.WriteLine("Área: " + area);
            Console.ReadKey();
        }
    }
}
