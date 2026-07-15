using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    /*Actividad 4: Gestión de vuelos
    Problema:

    Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
     Usar la palabra clave this en el constructor para diferenciar los parámetros de
    los atributos.
     Crear un método para calcular la duración del vuelo (TimeSpan).
     Cargar un vector con 4 vuelos y mostrar:
    1. El código y duración del vuelo más largo.
    2. El código del vuelo que salga más temprano.
    */

    class vuelo
    {
        private int codigo;
        private DateTime horaSalida;
        private DateTime horaLlegada;

        public int Codigo
        {
            get { return codigo; }
        }

        public DateTime HoraSalida
        {
            get { return horaSalida; }
        }

        public vuelo(int codigo, DateTime horaSalida, DateTime horaLlegada)
        {
            this.codigo = codigo;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }

        public TimeSpan duracion()
        {
            TimeSpan duracion = horaLlegada - horaSalida;
            return duracion;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            vuelo[] vuelos = new vuelo[4];

            for (int a = 0; a < vuelos.Length; a++)
            {
                int codigo;
                int hora;
                int minuto;
                string linea;
                DateTime horaSalida;
                DateTime horaLlegada;

                Console.Write("ingresar codigo: ");
                codigo = int.Parse(Console.ReadLine());

                do
                {
                    Console.Write("ingresar hora de salida: ");
                    linea = Console.ReadLine();
                    hora = int.Parse(linea);
                } while (hora > 23 || hora < 0);

                do
                {
                    Console.Write("ingresar minuto de salida: ");
                    linea = Console.ReadLine();
                    minuto = int.Parse(linea);
                } while (minuto > 59 || minuto < 0);

                horaSalida = new DateTime(2026, 6, 11, hora, minuto, 0);

                do
                {
                    Console.Write("ingresar hora de llegada: ");
                    linea = Console.ReadLine();
                    hora = int.Parse(linea);
                } while (hora > 23 || hora < 0);

                do
                {
                    Console.Write("ingresar minuto de llegada: ");
                    linea = Console.ReadLine();
                    minuto = int.Parse(linea);
                } while (minuto > 59 || minuto < 0);

                horaLlegada = new DateTime(2026, 6, 11, hora, minuto, 0);

                vuelos[a] = new vuelo(codigo, horaSalida, horaLlegada);
            }

            vuelo mayor = vuelos[0];
            vuelo temprano = vuelos[0];

            for (int a = 0; a < vuelos.Length; a++)
            {
                if (vuelos[a].duracion() > mayor.duracion())
                {
                    mayor = vuelos[a];
                }

                if (vuelos[a].HoraSalida < temprano.HoraSalida)
                {
                    temprano = vuelos[a];
                }
            }

            Console.WriteLine("vuelo más largo:");
            Console.WriteLine("codigo: " + mayor.Codigo);
            Console.WriteLine("duracion: " + mayor.duracion());
            Console.WriteLine();
            Console.WriteLine("vuelo que sale más temprano:");
            Console.WriteLine("codigo: " + temprano.Codigo);
            Console.ReadKey();
        }
    }
}