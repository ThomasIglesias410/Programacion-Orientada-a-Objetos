using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
método para imprimir estos datos básicos.
Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
para imprimir todos los datos del profesor (incluyendo los heredados).
En el programa principal (Main):
 Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
llamar a su método de impresión.
 Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
que puede acceder tanto a sus métodos propios como a los de la clase base.s*/
    class personaGimnasio
    {
        protected string nombre;
        protected int dni;
        public personaGimnasio() 
        {
            Console.Write("ingresar nombre: ");
            nombre = Console.ReadLine();
            Console.Write("ingresar dni: ");
            string linea = Console.ReadLine();
            dni = int.Parse(linea);
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int Dni
        {
            set { dni = value; }
            get { return dni; }
        }
        public void imprimirGym()
        {
            Console.WriteLine("clase personaGimnasio");
            Console.WriteLine("nombre: " + Nombre);
            Console.WriteLine("dni: " + Dni);
        }
    }
    class Profesor : personaGimnasio
    {
        private string especialidad;
        public Profesor()
        {
            Console.Write("ingresar especialidad: ");
            especialidad = Console.ReadLine();
        }
        public void imprimir()
        {
            Console.WriteLine("clase profesor");
            Console.WriteLine("nombre: " + Nombre);
            Console.WriteLine("dni: " + Dni);
            Console.WriteLine("especialidad: " + especialidad);
        }
            static void Main(string[] args)
            {
                personaGimnasio p = new personaGimnasio();
                p.imprimirGym();
                Profesor pr = new Profesor();
                pr.imprimir();
                pr.imprimirGym();
                Console.ReadKey();
            }
    }
}

