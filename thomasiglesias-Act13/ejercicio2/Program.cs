using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el
constructor, calcular su suma, resta, multiplicación y división, cada una en un
método, imprimir dichos resultados.*/
    internal class operaciones
    {
        private int a;
        private int t;
        public operaciones() 
        {
            Console.Write("cargar primer numero: ");
            string linea = Console.ReadLine();
            a = int.Parse(linea);
            Console.Write("cargar segundo numero: ");
            linea = Console.ReadLine();
            t = int.Parse(linea);
        }
        public void suma()
        {
            Console.WriteLine(a + " + " + t + " = " + (a + t));
        }
        public void resta()
        {
            Console.WriteLine(a + " - " + t + " = " + (a - t));
        }
        public void multiplicacion()
        {
            Console.WriteLine(a + " * " + t + " = " + (a * t));
        }
        public void division()
        {
            Console.WriteLine(a + " / " + t + " = " + (a / t));
        }
        static void Main(string[] args)
        {
            operaciones op = new operaciones();
            op.suma();
            op.resta();
            op.multiplicacion();
            op.division();
            Console.ReadKey();
        }
    }
}
