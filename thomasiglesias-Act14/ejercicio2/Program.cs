using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
Agregar los siguientes métodos en la clase Vuelo:
Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI.
*/
    class pasajero
    {
        private string nom;
        int dni;
        float equipkg;
        public pasajero()
        {
            Console.Write("ingresar nombre del pasajero: ");
            nom = Console.ReadLine();
            Console.Write("ingresar dni del pasajero: ");
            string linea = Console.ReadLine();
            dni = int.Parse(linea);
            Console.Write("ingresar peso de su equipaje en kg: ");
            linea = Console.ReadLine();
            equipkg = float.Parse(linea);
    

        }
        public string retNom() {  return nom; }
        public int retDni() { return dni; } 
        public float retEquipkg() { return equipkg; }
    }
    class vuelo
    {
        private pasajero[] pasajeros;
        public vuelo()
        {
            pasajeros = new pasajero[4];
            for (int a = 0;  a < pasajeros.Length; a++)
            {
                pasajeros[a] = new pasajero();
            }
        }
        public void listado()
        {
            for (int a = 0;a < pasajeros.Length;a++)
            {
                Console.WriteLine("nombre: "+pasajeros[a].retNom()+" dni: " + pasajeros[a].retDni()+" peso de su equipaje: " + pasajeros[a].retEquipkg());
            }
        }
        public void pesoTotal()
        {
            Console.WriteLine();
            float suma = 0;
            for (int a = 0; a <pasajeros.Length; a++)
            {
                suma += pasajeros[a].retEquipkg();
            }
            Console.WriteLine("el peso total del equipaje es: "+suma);
        }
        public void excesoDePeso()
        {
            Console.WriteLine("los pasajeros que exceden el peso permitido de 23 kg son:");
            for (int a = 0; a < pasajeros.Length; a++)
            {
                if (pasajeros[a].retEquipkg()>23)
                {
                    Console.WriteLine(pasajeros[a].retNom()+" " + pasajeros[a].retDni());
                }
            }
        }

        static void Main(string[] args)
        {
            vuelo vuelo = new vuelo();
            vuelo.listado();
            vuelo.pesoTotal();
            vuelo.excesoDePeso();
            Console.ReadKey();
        }
    }
}
