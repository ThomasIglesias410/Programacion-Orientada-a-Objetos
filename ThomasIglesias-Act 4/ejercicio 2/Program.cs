using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        /*2. Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.
(No se ingresan valores por teclado)*/
        static void Main(string[] args)
        {
            int cont = 0;
            int num = 11;
            while (cont <= 24)
            {
                Console.WriteLine(num);
                num = num + 11;
                cont = cont + 1;
            }
            Console.ReadKey();
        }
    }
}
