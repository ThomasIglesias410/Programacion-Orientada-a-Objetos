using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
dato las temperaturas medias mensuales de dichos paises.
Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
mensuales.
Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
memoria.
a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
mismas.
c. Calcular la temperatura media trimestral de cada país.
d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
e. Imprimir el nombre del país con la temperatura media trimestral mayor.*/
    internal class ejercicio1
    {
        private string[] pais;
        private float[,] temp;
        private float[] med;
        public ejercicio1() 
        {
            pais = new string[4];
            temp = new float[4,3];
            string linea = Console.ReadLine();
            for (int a=0; a<4;a++)
            {
                Console.Write("ingresar nombre del pais: ");
                linea = Console.ReadLine();
                pais[a] = linea;
                for (int t = 0; t < 3; t++)
                {
                    Console.Write("ingresar temperatura del pais: ");
                    linea = Console.ReadLine();
                    temp[a,t] = float.Parse(linea);
                }
            }
        }
        public void imprimir()
        {
            for (int a = 0; a < 4; a++)
            {
                Console.WriteLine(pais[a]);
                for (int t = 0; t < 3; t++)
                {
                    Console.Write(temp[a,t]+" ");
                }
                Console.WriteLine();
            }
        }
        public void mediaTrim()
        {
            med = new float[4];
            for (int a = 0; a < 4; a++)
            {
                for (int t = 0; t < 3; t++)
                {
                    med[a] += temp[a, t];
                }
                med[a]=med[a]/3;
            }
        }
        public void imp()
        {
            Console.WriteLine("nombre de los paises y sus temperaturas medias trimestrales:");
            for (int a = 0; a < 4; a++)
            {
                Console.WriteLine(pais[a]+": " + med[a]);
            }
        }
        public void mediaTrimMay()
        {
            string nombre= "";
            float may=med[0];
            for (int a = 0; a < 4; a++)
            {
                if (med[a]>may)
                {
                    may = med[a];
                    nombre = pais[a];
                }
            }
            Console.WriteLine("pais con la media trimestral mayor:");
            Console.Write(nombre+": "+may);
        }
        static void Main(string[] args)
        {
            ejercicio1 ej1 = new ejercicio1();
            ej1.imprimir();
            ej1.mediaTrim();
            ej1.imp();
            ej1.mediaTrimMay();
            Console.ReadKey();
        }
    }
}
