using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Se cuenta con la siguiente información:
● Las edades de 20 estudiantes del turno mañana.
● Las edades de 30 estudiantes del turno tarde.
● Las edades de 15 estudiantes del turno noche.
Las edades de cada estudiante deben ingresarse por teclado.
a) Obtener el promedio de las edades de cada turno (tres promedios)
b) Imprimir dichos promedios (promedio de cada turno)
c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
promedio de edades menor.*/

           
            int numero;
            int promTM = 0;
            int promTT = 0;
            int promTN = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write("ingrese un número: ");
                string linea = Console.ReadLine();
                numero = int.Parse(linea);
                promTM = promTM + numero;
            }
            for (int i = 0; i < 30; i++)
            {
                Console.Write("ingrese un número: ");
                string linea = Console.ReadLine();
                numero = int.Parse(linea);
                promTM = promTT + numero;
            }
            for (int i = 0; i < 15; i++)
            {
                Console.Write("ingrese un número: ");
                string linea = Console.ReadLine();
                numero = int.Parse(linea);
                promTM = promTN + numero;
            }
                promTM=promTM/20;
                promTT = promTT / 30;
                promTN = promTN / 15;
            Console.WriteLine("promedio turno mañana: "+promTM);
            Console.WriteLine("promedio turno tarde: " + promTT);
            Console.WriteLine("promedio turno noche: " + promTN);
            if (promTM < promTT && promTM < promTN)
            {

                Console.WriteLine("el menor promedio de edades es de turno mañana");

            }
            else 
            {
                if (promTT < promTM && promTT < promTN)
                {

                    Console.WriteLine("el menor promedio de edades es de turno tarde");

                }
                else { Console.WriteLine("el menor promedio de edades es de turno noche"); }
            
            }
        }
    }
}
