using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*Crear una clase base llamada Computadora que contenga los atributos Marca y
    MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
    Luego, definir dos clases derivadas de la clase base:
     Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
     Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
    Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
    tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
    clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
    de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.*/

    class computadora
    {
        protected string marca;
        protected float memoriaRam;

        public computadora(string ma, float mr)
        {
            Marca = ma;
            MemoriaRam = mr;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public float MemoriaRam
        {
            get { return memoriaRam; }
            set { memoriaRam = value; }
        }

        public void mostrar()
        {
            Console.WriteLine("marca: " + marca);
            Console.WriteLine("memoria RAM: " + memoriaRam);
        }
    }

    class notebook : computadora
    {
        private int tamanopantalla;

        public notebook(string ma, float mr, int tp)
            : base(ma, mr)
        {
            TamanoPantalla = tp;
        }

        public int TamanoPantalla
        {
            get { return tamanopantalla; }
            set { tamanopantalla = value; }
        }

        public void mostrarnb()
        {
            Console.WriteLine("notebook:");
            Console.WriteLine("tamaño de pantalla: " + tamanopantalla);
        }
    }

    class escritorio : computadora
    {
        private float potenciaFuente;

        public escritorio(string ma, float mr, float pf)
            : base(ma, mr)
        {
            PotenciaFuente = pf;
        }

        public float PotenciaFuente
        {
            get { return potenciaFuente; }
            set { potenciaFuente = value; }
        }

        public void mostrarEscritorio()
        {
            Console.WriteLine("escritorio: ");
            Console.WriteLine("potencia de la fuente: " + potenciaFuente);
        }

        static void Main(string[] args)
        {
            notebook n = new notebook("Agustina", 17, 67);
            escritorio e = new escritorio("Thomas", 17, 68);

            n.mostrarnb();
            e.mostrarEscritorio();

            Console.ReadKey();
        }
    }
}