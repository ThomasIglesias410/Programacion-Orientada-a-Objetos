using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Empleado
    {
        /*3. Confeccionar una clase que represente un empleado. Definir como atributos su
nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
sus datos y por último uno que imprima un mensaje si debe pagar impuestos
(si el sueldo supera a 3000).*/
        string n;
        double s;

        public void cargar()
        {
            string linea;
            n = Console.ReadLine();
            linea = Console.ReadLine();
            s = double.Parse(linea);
        }

        public void mostrar()
        {
            Console.WriteLine(n);
            Console.WriteLine(s);
        }

        public void imp()
        {
            if (s > 3000)
            {
                Console.WriteLine("paga");
            }
            else
            {
                Console.WriteLine("no paga");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado e = new Empleado();
            e.cargar();
            e.mostrar();
            e.imp();

            Console.ReadKey();
        }
    }
}