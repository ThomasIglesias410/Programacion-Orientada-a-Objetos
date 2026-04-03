using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    class Punto
    {
        /*1. Desarrollar una clase que represente un punto en el plano y tenga los
siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
encuentra dicho punto (concepto matemático, primer cuadrante si x e y son
positivas, si x&lt;0 e y&gt;0 segundo cuadrante, etc.)*/
        int x, y;

        public void cargar()
        {
            string linea;
            linea = Console.ReadLine();
            x = int.Parse(linea);

            linea = Console.ReadLine();
            y = int.Parse(linea);
        }

        public void cuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
            }
            else if (x < 0 && y > 0)
            {
                 Console.WriteLine("2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
            else
            {
                Console.WriteLine("eje");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Punto p = new Punto();
            p.cargar();
            p.cuadrante();
         }
       }


    }