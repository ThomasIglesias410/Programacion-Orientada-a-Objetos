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
