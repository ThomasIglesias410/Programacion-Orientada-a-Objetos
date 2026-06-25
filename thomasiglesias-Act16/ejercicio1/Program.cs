using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*1. Confeccionar una clase Persona que tenga como atributos el nombre y la
edad (definir las propiedades para poder acceder a dichos atributos). Definir
un método para imprimirlos. Plantear una segunda clase Empleado que
herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
método para imprimir su sueldo. Definir un objeto de la clase Persona y
llamar a sus métodos y propiedades. También crear un objeto de la clase
Empleado y llamar a sus métodos y propiedades.*/
    class persona
    {
        protected string nombre;
        protected int edad;
        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set {  edad = value; }
        }
    }
    class empleado : persona
    {
        private int sueldo;
        public int Sueldo
        {
            get { return sueldo; }
            set {  sueldo = value; }
        }
        public void imprimir() { Console.WriteLine("el sueldo de "+Nombre+" es de: " + Sueldo); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            empleado empleado = new empleado();
            empleado.Nombre = "Agustina";
            empleado.Edad = 17;
            empleado.Sueldo = 6767;
            empleado.imprimir();
            Console.ReadKey();
        }

    }
}
