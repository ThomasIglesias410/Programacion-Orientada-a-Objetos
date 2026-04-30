using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    /*4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
sus nombres y puntajes promedio obtenidos (de 1 a 10).
Cargar sus datos en vectores paralelos, mostrar docente con calificación más
alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
desaprobaron (tomando como base que se aprueba con una nota mayor o igual
a 6)*/
    internal class ejercicio4
    {
        private string[] doc;
        private int[] punt;
        private int alta = 0;
        private int baja = 1000000000;
        public void cargar()
        {
            doc = new string[6];
            punt = new int[6];
            for (int i = 0; i < doc.Length; i++)
            {

                Console.Write("ingrese el nombre del docente ");
                string linea = Console.ReadLine();
                doc[i] = linea;
                Console.Write("ingrese la nota del docente: ");
                linea = Console.ReadLine();
                punt[i] = int.Parse(linea);
            }
        }
        public void NotaAltaYBaja()
        {
            string NomAlt = "";
            string NomBaj = "";

            for (int i = 0; i < doc.Length; i++)
            {

                if (punt[i] > alta)
                {

                    alta = punt[i];
                    NomAlt = doc[i];
                }
                if (punt[i] < baja)
                {

                    baja = punt[i];
                    NomBaj = doc[i];
                }

            }

            Console.WriteLine("la nota mas alta es de: " + NomAlt + "con un: " + alta);
            Console.WriteLine("la nota mas baja es de: " + NomBaj + "con un: " + baja);
        }
        public void ordenarMayor()
        {
            string aux;
            int auxi;
            Console.WriteLine("notas ordenadas de mayor a menor: ");
            for (int i = 0; i < doc.Length; i++)
            {
                if (punt[i] < punt[1 + i])
                {
                    aux = doc[i];
                    doc[i] = doc[i + 1];
                    doc[i + 1] = aux;

                    auxi = punt[i];
                    punt[i] = punt[i + 1];
                    punt[i + 1] = auxi;
                }
                Console.WriteLine(doc[i] + ": " + punt[i]);
            }
        }
        public void aprobaron()
        {
                int apr = 0;
                int desapr = 0;
            for (int i = 0; i < doc.Length; i++)
            {
                if (punt[i] >= 6)
                {
                    apr++;
                }
                else
                {
                    desapr++;
                }
            }
            Console.WriteLine("cantidad de docentes aprobados:"+ apr);
            Console.WriteLine("cantidad de docentes desaprobados:" + desapr);
        }

        static void Main(string[] args)
        {
            ejercicio4 ej4 = new ejercicio4();
            ej4.cargar();
            ej4.NotaAltaYBaja();
            ej4.ordenarMayor();
            ej4.aprobaron();
            Console.ReadKey();
        }
    }
}