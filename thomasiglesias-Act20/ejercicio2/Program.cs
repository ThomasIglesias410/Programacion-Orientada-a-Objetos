using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*Actividad 2: Administración de entregas logísticas
Problema:
Una empresa de envíos desea registrar sus entregas mediante colaboración de
clases.
Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
Despachador que contenga una lista de paquetes y un método para registrar nuevos
paquetes.
Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
 Todos los paquetes registrados.
 Cuántos superan los 10 kg de peso.
 Cuántos tienen destino nacional (por ejemplo, “Argentina”).*/
    class paquete
    {
        private string codigo;
        private float peso;
        private string destino;

        public paquete(string c, float p, string d)
        {
            Codigo = c;
            Peso = p;
            Destino = d;
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public string Destino
        {
            get { return destino; }
            set { destino = value; }
        }
    }

    class despachador
    {
        public List<paquete> lista = new List<paquete>();

        public void registrar(paquete p)
        {
            lista.Add(p);
        }

        public void mostrar()
        {
            foreach (paquete p in lista)
            {
                Console.WriteLine("codigo: " + p.Codigo);
                Console.WriteLine("peso: " + p.Peso);
                Console.WriteLine("destino: " + p.Destino);
                Console.WriteLine();
            }
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            despachador d = new despachador();

            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine("paquete " + (a + 1));

                Console.Write("codigo: ");
                string c = Console.ReadLine();

                Console.Write("peso: ");
                float p = float.Parse(Console.ReadLine());

                Console.Write("destino: ");
                string de = Console.ReadLine();

                d.registrar(new paquete(c, p, de));
            }

            int mayores10 = 0;
            int argentina = 0;

            foreach (var p in d.lista)
            {
                if (p.Peso > 10) { mayores10++; }
                if (p.Destino == "argentina") { argentina++; }
            }
            Console.WriteLine("mayores a 10kg: " + mayores10);
            Console.WriteLine("destino argentina: " + argentina);
            Console.ReadKey();
        }
    }
}