using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
La clase Vehiculo debe tener los siguientes atributos privados:
Patente (de tipo string).
Tipo (puede ser "Auto", "Camion" o "Moto").
Tarifa (un valor decimal que representa el costo de su pase).
El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
La clase CabinaPeaje debe tener como atributos privados:
El número o identificador de la cabina.
Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los siguientes métodos dentro de CabinaPeaje:
Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
Un método que muestre la patente del vehículo que pagó la tarifa más cara.
*/
    class vehiculo
    {
        private string patente;
        private string tipo;
        private float tarifa;
        public vehiculo() 
        {
            Console.Write("ingresar patente del vehiculo: ");
            patente = Console.ReadLine();
            Console.Write("ingresar tipo de vehiculo: ");
            tipo = Console.ReadLine();
            Console.Write("ingresar tarifa del vehiculo: ");
            string linea = Console.ReadLine();
            tarifa = float.Parse(linea);
        }
        public string retPatente()
        {  return patente; }
        public string retTipo()
        { return tipo; }
        public float retTarifa()
        { return tarifa; }
    }
    class cabinaPeaje
    {
        private int cabina;
        private vehiculo vehiculo1, vehiculo2, vehiculo3;
        public cabinaPeaje()
        {
            Console.Write("ingresar numero de la cabina: ");
            string linea = Console.ReadLine();
            cabina = int.Parse(linea);
            vehiculo1 = new vehiculo();
            vehiculo2 = new vehiculo();
            vehiculo3 = new vehiculo();
        }
        public void imprimir() 
        {
            Console.WriteLine();
            Console.WriteLine("patente: " + vehiculo1.retPatente()+" tipo: "+vehiculo1.retTipo());
            Console.WriteLine("patente: " + vehiculo2.retPatente() + " tipo: " + vehiculo2.retTipo());
            Console.WriteLine("patente: " + vehiculo3.retPatente() + " tipo: " + vehiculo3.retTipo());
        }
        public void recaudacion()
        {
            Console.WriteLine();
            float suma = vehiculo1.retTarifa() + vehiculo2.retTarifa() + vehiculo3.retTarifa();
            Console.WriteLine("suma total de lo recaudado con tarifas: " + suma);
        }
        public void mayTarifa() 
        {
            float may = vehiculo1.retTarifa();
            string patMay = vehiculo1.retPatente();
            if (may < vehiculo2.retTarifa())
            {
                may = vehiculo2.retTarifa();
                patMay = vehiculo2.retPatente();
            }
            if (may < vehiculo3.retTarifa())
            {
                may = vehiculo3.retTarifa();
                patMay = vehiculo3.retPatente();
            }
            Console.WriteLine("la patente del vehiculo que pagó la tarifa mas alta es " + patMay + " y pagó una tarifa de " + may);
        }
        static void Main(string[] args)
        {
            cabinaPeaje cp = new cabinaPeaje();
            cp.imprimir();
            cp.recaudacion();
            cp.mayTarifa();
            Console.ReadKey();
        }
    }
}
