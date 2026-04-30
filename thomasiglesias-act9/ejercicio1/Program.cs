using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*1. Se desea desarrollar un programa que permita registrar los nombres y las
calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
máxima o mínima.*/
    internal class ejercicio1
    {
        private string[] nom;
        private int[] not;
        private int alta = 0;
        private int baja = 1000000000;
        public void cargar()
        {
            nom = new string[6];
            not = new int[6];
            for (int i = 0; i < nom.Length; i++)
            {

                Console.Write("ingrese el nombre del estudiante ");
                string linea = Console.ReadLine();
                nom[i] = linea;
                Console.Write("ingrese la nota del estudiante: ");
                linea = Console.ReadLine();
                not[i] = int.Parse(linea);
            }
        }
        public void NotaAltaYBaja()
        {
            string NomAlt = "";
            string NomBaj = "";

            for (int i = 0; i < nom.Length; i++)
            {

                if (not[i] > alta)
                {

                    alta = not[i];
                    NomAlt = nom[i];
                }
                if (not[i] < baja)
                {

                    baja = not[i];
                    NomBaj = nom[i];
                }
            
            }

            Console.WriteLine("la nota mas alta es de: " + NomAlt + "con un: "+ alta);
            Console.WriteLine("la nota mas baja es de: "+NomBaj+ "con un: " + baja);
        }
        public void mismanota()
        {
            int contA = 0;
            int contB = 0;
            for (int i = 0; i < nom.Length; i++)
            {
                if (not[i] == alta)
                {
                    contA++;
                }
                if (not[i] == baja)
                {
                    contB++;
                }
            }
            Console.WriteLine("la nota mas alta se repite "+contA+" veces");
            Console.WriteLine("la nota mas baja se repite " + contB + " veces");
        }
        
        static void Main(string[] args)
        {
            ejercicio1 ej1 = new ejercicio1();
            ej1.cargar();
            ej1.NotaAltaYBaja();
            ej1.mismanota();
            Console.ReadKey();
        }
    }
}
