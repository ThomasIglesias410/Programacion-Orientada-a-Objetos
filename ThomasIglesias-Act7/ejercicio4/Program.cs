using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    /*4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
ordenado de menor a mayor y de mayor a menor.*/
    internal class ejercicio4
    {
        private int[] v;
        private int x = 0;
        public void MayorAMenor()
        {

            v = new int[10];
            int var = 10000;
            int cheq = 0;
            for (int i = 0; i < 10; i++)
            {

                Console.Write("ingrese el valor del vector: ");
                string linea = Console.ReadLine();
                v[i] = int.Parse(linea);
                // 30 20 50 40
                if (v[i]<var)
                {
                    cheq++;                    
                }
                var = v[i];
            }
            if(cheq == 10)
            {

                Console.WriteLine("el vector esta ordenado de mayor a menor");
                x++;

            }

        }
        public void MenorAMayor()
        {
        
            int var = -10000;
            int cheq = 0;
            for (int i = 0; i < 10; i++)
            {

                if (v[i] > var)
                {
                    cheq++;
                }
                var = v[i];

            }
            if (cheq == 10)
            {

                Console.WriteLine("el vector esta ordenado de menor a mayor");

            }
            else if(x==0)
            {
                Console.WriteLine("el vector NO esta ordenado");
            }


        }
        static void Main(string[] args)
        {
            ejercicio4 ej4 = new ejercicio4();
            ej4.MayorAMenor();
            ej4.MenorAMayor();   
            Console.ReadKey();
        }
    }
}
