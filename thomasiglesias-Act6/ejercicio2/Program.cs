using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Cuadrado
    {
        int cuad;

        public void cargar()
        {
            /*2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.*/
            string linea;
            linea = Console.ReadLine();
            cuad = int.Parse(linea);
        }

        public void per()
        {
            Console.WriteLine(cuad * 4);
        }

        public void sup()
        {
            Console.WriteLine(cuad * cuad);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado c = new Cuadrado();
            c.cargar();
            c.per();
            c.sup();

            Console.ReadKey();
        }
    }
}