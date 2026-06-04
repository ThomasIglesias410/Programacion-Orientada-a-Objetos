using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*3. Plantear una clase Club y otra clase Socio.
La clase Socio debe tener los siguientes atributos privados: nombre y la
antigüedad en el club (en años). En el constructor pedir la carga del nombre y
su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
antigüedad en el club.*/
    class socio
    {
        private string nom;
        private int ant;
        public socio()
        {
            Console.Write("cargar nombre del socio: ");
            nom = Console.ReadLine();
            Console.Write("cargar antiguedad del socio: ");
            string linea = Console.ReadLine();
            ant = int.Parse(linea);
        }
        public string retornarNom()
        {
            return nom;
        }
        public int retornarAnt()
        {
            return ant;
        }
    }
    class club
    {
        private socio socio1, socio2, socio3;
        public club()
        {
            socio1 = new socio();
            socio2 = new socio();
            socio3 = new socio();
        }
        public void mayAnt()
        {
            Console.WriteLine();
            int may = socio1.retornarAnt();
            if (may < socio2.retornarAnt())
            {
                may = socio2.retornarAnt();
                Console.WriteLine(socio2.retornarNom()+": "+may);
            }
            else if (may < socio3.retornarAnt())
            {
                may = socio3.retornarAnt();
                Console.WriteLine(socio3.retornarNom() + ": " + may);
            }
            else
            {
                Console.WriteLine(socio1.retornarNom() + ": " + may);
            }
        }
        static void Main(string[] args)
        {
           club club = new club();
            club.mayAnt();
            Console.ReadKey();
        }
    }
}
