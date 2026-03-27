//1. Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el lado del cuadrado: ");
            int lado = int.Parse(Console.ReadLine());

           
            int perimetro = lado * 4;
            

            Console.WriteLine("perimetro: " + perimetro);
            Console.ReadKey();
        }
    }
}
