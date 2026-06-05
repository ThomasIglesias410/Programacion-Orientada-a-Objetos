using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
Definir los siguientes métodos en la clase Carrera:
Un constructor que cargue los datos de los 3 atletas de la carrera.
Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
Un método que calcule e imprima el tiempo promedio de la carrera.
Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
Un método que muestre a los atletas que superaron el promedio.
*/
    class atleta
    {
        private string nom;
        private float tiem;
        public atleta()
        {
            Console.Write("ingresar nombre del atleta: ");
            nom = Console.ReadLine();
            Console.Write("ingresar tiempo del atleta");
            string linea = Console.ReadLine();
            tiem = float.Parse(linea);
        }
        public string retNom() { return nom; }
        public float retTiem() { return tiem; }
    }
    class carrera
    {
        private atleta[] atletas;
        private float prom;
        public carrera()
        {
            atletas = new atleta[3];
            for (int a = 0; a < atletas.Length; a++)
            {
                atletas[a] = new atleta();
            }
        }
        public void imprimir()
        {
            for (int a = 0; a < atletas.Length; a++)
            {
                Console.WriteLine("nombre: " + atletas[a].retNom() + " tiempo: " + atletas[a].retTiem());
            }
        }
        public void promedio()
        {
            prom = 0;
            for (int a = 0;a < atletas.Length; a++)
            {
                prom += atletas[a].retTiem();
            }
            prom = prom / 3;
            Console.WriteLine("el tiempo promedio de la carrera es: " + prom);
        }
        public void ganadores()
        {
            float men = atletas[0].retTiem();
            string nomMen = atletas[0].retNom();
            for (int a = 0;a<atletas.Length; a++)
            {
            if (men > atletas[a].retTiem())
            {
                men = atletas[a].retTiem();
                nomMen = atletas[a].retNom();
            }
            
            }
            Console.WriteLine("el ganador de la carrera es " + nomMen + " con un tiempo de " + men);
        }
        public void supPromedio()
        {
            Console.WriteLine("nombre de los atletas que superan el promedio:");
            for (int a = 0; a < atletas.Length; a++)
            {
                if (atletas[a].retTiem() < prom)
                {
                    Console.WriteLine(atletas[a].retNom());
                }
            }
        }
        static void Main(string[] args)
        {
            carrera car=new carrera();
            car.imprimir();
            car.promedio();
            car.ganadores();
            car.supPromedio();
            Console.ReadKey();
        }
    }
}
