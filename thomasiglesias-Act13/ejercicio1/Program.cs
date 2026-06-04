using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*1. Confeccionar una clase que represente un empleado. Definir como atributos su
nombre y su sueldo. En el constructor cargar los atributos y luego en otro
método imprimir sus datos y por último uno que imprima un mensaje si debe
pagar impuestos (si el sueldo supera a 3000)*/
    internal class empleado
    {
        private string nom;
        private int suel;
        public empleado()
        {
            Console.Write("cargar nombre del empleado: ");
            string linea=Console.ReadLine();
            nom = Console.ReadLine();
            Console.Write("cargar sueldo del empleado: ");
            linea = Console.ReadLine();
            suel = int.Parse(linea);
        }
        public void imprimir()
        {
            Console.WriteLine(nom+" "+suel);
        }
        public void impuestos()
        {
            if (suel > 3000)
            {
                Console.WriteLine("debe pagar impuestos");
            }
        }
        static void Main(string[] args)
            {
                empleado emp = new empleado();
                emp.imprimir();
                emp.impuestos();
                Console.ReadKey();
            }

    }
}
