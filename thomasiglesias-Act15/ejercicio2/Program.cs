using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*Una estación de acoplamiento registra el peso de los contenedores transportados en las
bodegas de carga de las naves espaciales que llegan al puerto.
● Crear la clase NaveEspacial que contenga únicamente el atributo privado
NombreNave y su constructor para cargarlo.
● Crear la clase colaboradora PuertoControl que contenga:
○ Un vector de 3 objetos de la clase NaveEspacial.
○ Una matriz irregular de tipo double llamado pesoContenedores, donde
cada fila representa a una nave, el tamaño de la fila es la cantidad de
bodegas que posee esa nave, y los valores almacenados son los pesos (en
toneladas) de los contenedores que transporta cada bodega.

En PuertoControl, definir los siguientes métodos:

1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
irregular) y cargue el peso del contenedor asignado a cada bodega.
2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
espacial.
3. Un método que identifique e informe qué nave transporta el contenedor individual
más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
irregular).
4. Un método que indique el nombre de la nave que transporta menor peso acumulado
total (la suma de todos sus contenedores).*/
    class naveEspacial
    {
        private string nombreNave;
        public naveEspacial()
        {
            Console.Write("ingrese nombre de la nave: ");
            nombreNave = Console.ReadLine();
        }

        public string retNom() { return nombreNave; }
    }
    class puertoControl
    {
        private naveEspacial[] naves;
        private double[][] peso;
        public puertoControl()
        {
            naves = new naveEspacial[3];
            peso = new double[3][];
            int tam = 0;
            for (int a = 0; a < naves.Length; a++)
            {
                naves[a] = new naveEspacial();
                Console.Write("de cuantas bodegas dispone esta nave: ");
                string linea = Console.ReadLine();
                tam = int.Parse(linea);
                peso[a] = new double[tam];
            }
            for (int a = 0;a < naves.Length; a++)
            {
                Console.WriteLine("nave " + (a + 1) + ": ");
                for (int t = 0; t < peso[a].Length; t++)
                {
                    Console.Write("ingresar peso del contenedor de la bodega "+(t+1)+": ");
                    string linea = Console.ReadLine();
                    peso[a][t] = double.Parse(linea);
                }
            }
        }
        public void mostrar()
        {
            for (int a = 0; a <naves.Length; a++)
            {
                Console.WriteLine("nave "+(a+1));
                for(int t = 0;t < peso[a].Length;t++)
                {
                    Console.Write(peso[a][t]+" ");
                }
                Console.WriteLine();
            }
        }
        public void valMax()
        {
            Console.WriteLine();
            double max = 0;
            for (int a = 0; a < naves.Length; a++)
            {
                for (int t = 0; t < peso[a].Length; t++)
                {
                    if (peso[a][t] > max)
                    {
                        max = peso[a][t];
                    }
                }
            }
            Console.WriteLine("el peso mas alto de todas las naves es de: "+max);
        }
        public void menPes()
        {
            Console.WriteLine();
            double men = 0;
            double total;
            string nomMen = "";

            for (int a = 0; a < naves.Length; a++)
            {
                total = 0;
                for (int t = 0; t < peso[a].Length; t++)
                {
                    total += peso[a][t];
                }
                    if (total < men)
                    {
                        men = total;
                    nomMen = naves[a].retNom();
                    }
            }
            Console.WriteLine("la nave con el menor peso acumulado es: " + nomMen);
        }
        static void Main(string[] args)
        {
            puertoControl p = new puertoControl();
            p.mostrar();
            p.valMax();
            p.menPes();
            Console.ReadKey();
        }
    }
}
