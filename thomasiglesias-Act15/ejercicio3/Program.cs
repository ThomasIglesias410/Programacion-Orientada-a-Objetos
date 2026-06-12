using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
especies protegidas en cuadrículas de territorio.
● Confeccionar la clase ReservaNatural que tenga como atributos privados el
NombreReserva y una matriz llamada avistamientos de 3x3 (que representa un
mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
cantidad de animales avistados en cada sector). El constructor de la clase debe
cargar por teclado el nombre y rellenar el mapa de avistamientos.
● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
objetos de la clase ReservaNatural.
La clase CentroEcologico debe implementar los siguientes métodos:
1. Un constructor que solicite la carga secuencial de las 3 reservas.
2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
registró en toda su superficie (la suma de toda su matriz rectangular).
3. Un método que determine e informe cuál fue la coordenada o sector específico ([fila,
columna]) que registró la mayor concentración de avistamientos de toda la red de
reservas, indicando a qué reserva pertenece.*/
    class reservaNatural
    {
        private string nombreReserva;
        private int[,] avistamientos;
        public reservaNatural()
        {
            avistamientos = new int[3, 3];
            Console.Write("ingresar nombre de la reserva: ");
            string linea = Console.ReadLine();
            for (int a = 0; a<avistamientos.GetLength(0);a++)
            {
                for (int t = 0; a<avistamientos.GetLength(1);t++)
                {
                    Console.Write("animales avistados en la zona " + (a + 1) + " distrito " + (t + 1) + ": ");
                    linea = Console.ReadLine();
                    avistamientos[a,t] = int.Parse(linea);
                }
            }
        }
        public string nombre() { return nombreReserva; }
        public int[,] avist() { return avistamientos; }
        }
    class centroEcologico
    {
        private reservaNatural[] reservas;
        public centroEcologico() 
        {
            reservas = new reservaNatural[3];
            for ( int a = 0; a<reservas.Length;a++)
            {
                reservas[a] = new reservaNatural();
            }
        }
        public void totalAvis()
        {
            int suma = 0;
            for (int a = 0; a < reservas.Length; a++)
            {
                for (int t = 0; t < reservas[a].avist().GetLength(0);t++)
                {
                    for (int e  = 0; e < reservas[a].avist().GetLength(1); e++)
                    {
                        suma += reservas[a].avist()[t, e];
                    }
                }
                Console.WriteLine("la suma total de la reserva " + (a + 1) + " es: " + suma);
            }
        }
        public void mayAvis()
        {
            Console.WriteLine();
            int may = 0;
            int fila = 0;
            int columna = 0;
            string nombre = "";
            for (int a = 0; a < reservas.Length; a++)
            {
                for (int t = 0; t < reservas[a].avist().GetLength(0); t++)
                {
                    for (int e = 0; e < reservas[a].avist().GetLength(1); e++)
                    {
                        if (reservas[a].avist()[t,e]>may)
                        {
                            may = reservas[a].avist()[t, e];
                            fila = t;
                            columna = e;
                            nombre = reservas[a].nombre();
                        }
                    }
                }
            }
            Console.WriteLine("el mayor numero de avistamientos se encuentra en la reserva"+ nombre +" fila N°" + fila + " columna N° " + columna);
        }
        static void Main(string[] args)
        {
            centroEcologico centro = new centroEcologico();
            centro.totalAvis();
            centro.mayAvis();
            Console.ReadKey();

        }
    }
}
