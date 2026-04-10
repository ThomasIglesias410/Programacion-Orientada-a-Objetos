using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
un videojuego. El programa debe:
 Mostrar la puntuación más alta y la más baja.
 Calcular el promedio de puntuación.
 Contar cuántas veces superó los 500 puntos.*/
    internal class ejercicio3
    {
        private int[] punt;

        public void cargar()
        {

            punt = new int[6];
           
            for (int i = 0; i < 6; i++)
            {

                Console.Write("ingrese el valor de la puntuacion: ");
                string linea = Console.ReadLine();
                punt[i] = int.Parse(linea);
                
            }



        }
        public void PuntuacionAltaYBaja()
        {

            int alta = 0;
            int baja = 1000000000;

            for (int i = 0; i < 6; i++)
            {

                if (punt[i]>alta)
                {

                    alta = punt[i];

                }
                if (punt[i] < baja)
                {

                    baja = punt[i];

                }

            }

            Console.WriteLine("la puntuacion mas alta es: " + alta);
            Console.WriteLine("la puntuacion mas baja es: " + baja);

        }
        public void promedio()
        {

            int sum = 0;
            float prom = 0;
            for (int i = 0; i < 6; i++)
            {

                sum = sum + punt[i];

            }
            prom = sum/6;
            Console.WriteLine("el promedio es: " + prom);


        }
        public void cont500()
        {

            int cont = 0;

            for (int i = 0; i < 6; i++)
            {

               if(punt[i]>500)
                {

                    cont++;

                }

            }

            Console.WriteLine("los puntajes mayores a 500 son: " + cont);

        }
        static void Main(string[] args)
        {

            ejercicio3 ej3 = new ejercicio3();
            ej3.cargar();
            ej3.PuntuacionAltaYBaja();
            ej3.promedio();
            ej3.cont500();
            Console.ReadKey();

        }
    }
}
