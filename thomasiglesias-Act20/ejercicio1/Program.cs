using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*Una aerolínea administra los vuelos programados mediante un sistema orientado a objetos.
     Vuelo (base): número, destino, duración
     VueloInternacional: país destino
     Lista de 5 vuelos, mostrar datos, mayor duración y orden de constructores*/

    class vuelo
    {
        protected int numero;
        protected string destino;
        protected float duracion;

        public vuelo(int n, string d, float du)
        {
            Numero = n;
            Destino = d;
            Duracion = du;

            Console.WriteLine("constructor vuelo ejecutado");
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public float Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public void mostrar()
        {
            Console.WriteLine("numero: " + Numero);
            Console.WriteLine("destino: " + Destino);
            Console.WriteLine("duracion: " + Duracion);
        }
    }

    class vuelointernacional : vuelo
    {
        private string paisdestino;

        public vuelointernacional(int n, string d, float du, string p)
            : base(n, d, du)
        {
            Paisdestino = p;

            Console.WriteLine("constructor vuelointernacional ejecutado");
        }

        public string Paisdestino
        {
            get { return paisdestino; }
            set { paisdestino = value; }
        }

        public void mostrarvuelo()
        {
            mostrar();
            Console.WriteLine("pais destino: " + Paisdestino);
            Console.WriteLine();
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            List<vuelointernacional> vuelos = new List<vuelointernacional>();

            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine("vuelo " + (a + 1));

                Console.Write("numero: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("destino: ");
                string d = Console.ReadLine();

                Console.Write("duracion: ");
                float du = float.Parse(Console.ReadLine());

                Console.Write("pais destino: ");
                string p = Console.ReadLine();

                vuelos.Add(new vuelointernacional(n, d, du, p));
            }

            vuelointernacional mayor = null;
            float max = -1;

            foreach (var v in vuelos)
            {
                v.mostrarvuelo();

                if (v.Duracion > max)
                {
                    max = v.Duracion;
                    mayor = v;
                }
            }
            Console.WriteLine("vuelo con mayor duracion:");
            mayor.mostrarvuelo();
            Console.ReadKey();
        }
    }
}