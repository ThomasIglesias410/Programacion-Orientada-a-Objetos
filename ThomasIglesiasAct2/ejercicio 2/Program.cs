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

            //2. Se ingresan seis notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"
            int num1, num2, num3, num4, num5, num6, promedio;

            string linea;
            Console.Write("nota 1:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("nota 2:");
            linea = Console.ReadLine(); 
            num2 = int.Parse(linea);
            Console.Write("nota 3:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            Console.Write("nota 4:");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);
            Console.Write("nota 5:");
            linea = Console.ReadLine();
            num5 = int.Parse(linea);
            Console.Write("nota 6:");
            linea = Console.ReadLine();
            num6 = int.Parse(linea);

            promedio = (num1 + num2 + num3 + num4 + num5 + num6) / 6;
       
            
            if (promedio >= 7)
            {

                Console.WriteLine("Promocionado");
              

            }
            Console.ReadKey();
        }
    }
}
