using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
carrera de 100 metros. El programa debe cargar los datos en dos vectores
paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
promedio.*/
    internal class ejercicio3
    {
        private string[] nom;
        private int[] tiem;
        private int alta = 0;
        private int baja = 1000000000;
        private int prom = 0;
        public void cargar()
        {
            nom = new string[5];
            tiem = new int[5];
            int suma = 0;
            for (int i = 0; i < nom.Length; i++)
            {

                Console.Write("ingrese el nombre del atleta ");
                string linea = Console.ReadLine();
                nom[i] = linea;
                Console.Write("ingrese el tiempo del atleta en segundos: ");
                linea = Console.ReadLine();
                tiem[i] = int.Parse(linea);
                suma = suma + tiem[i];
            }
            prom = suma/5;
            Console.WriteLine("promedio: "+prom);
        }
        public void tiempoAltoyBajo()
        {
            string NomAlt = "";
            string NomBaj = "";

            for (int i = 0; i < nom.Length; i++)
            {

                if (tiem[i] > alta)
                {

                    alta = tiem[i];
                    NomAlt = nom[i];
                }
                if (tiem[i] < baja)
                {

                    baja = tiem[i];
                    NomBaj = nom[i];
                }

            }

            Console.WriteLine("el peor tiempo es de: " + NomAlt + "con unos: " + alta + " segundos");
            Console.WriteLine("el mejor tiempo es de: " + NomBaj + "con unos: " + baja + " segundos");
        }
        public void superaronPromedio()
        {
            Console.WriteLine("atletas que superaron el promedio: ");
            for (int i = 0; i < nom.Length; i++)
            {
                if (tiem[i] > prom)
                {
                    Console.WriteLine(nom[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            ejercicio3 ej1 = new ejercicio3();
            ej1.cargar();
            ej1.tiempoAltoyBajo();
            ej1.superaronPromedio();
            Console.ReadKey();
        }
    }
}