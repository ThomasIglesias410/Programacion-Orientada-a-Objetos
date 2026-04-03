using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Op
    {
        /*4. Implementar la clase operaciones. Se deben cargar dos valores enteros,
calcular su suma, resta, multiplicación y división, cada una en un método,
imprimir dichos resultados.*/
        int a, b;

        public void cargar()
        {
            string linea;
            linea = Console.ReadLine();
            a = int.Parse(linea);

            linea = Console.ReadLine();
            b = int.Parse(linea);
        }

        public void suma() { Console.WriteLine(a + b); }
        public void resta() { Console.WriteLine(a - b); }
        public void mul() { Console.WriteLine(a * b); }

        public void div()
        {
            if (b != 0)
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Op o = new Op();
            o.cargar();
            o.suma();
            o.resta();
            o.mul();
            o.div();

            Console.ReadKey();
        }
    }
}