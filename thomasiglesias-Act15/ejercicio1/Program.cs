using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejercicio1
{
    /*En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
cardíaco de los pacientes.
● Plantear una clase llamada Paciente que tenga como atributos privados:
1. Nombre (de tipo string).
2. Una matriz llamada ritmoCardiaco de tamaño 3x4 (representando los
registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
clave de cada día: mañana, mediodía, tarde y noche).
3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
teclado de las 12 lecturas cardíacas.

● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
objetos de la clase Paciente. Su constructor debe inicializar el vector y solicitar la
carga de los 3 pacientes. Implementar los siguientes métodos dentro de
SalaMonitoreo:
1. Un método que imprima la grilla de lecturas cardíacas completa de cada
paciente organizada por día y momento.
2. Un método que calcule e imprima el promedio de pulsaciones de cada
paciente a lo largo de todo su monitoreo.
3. Un método que verifique si algún paciente registró un evento de taquicardia
severa (cualquier lectura individual que sea estrictamente mayor a 120
pulsaciones), mostrando por consola su nombre y la lectura detectada.*/
    class paciente
    {
        private string nom;
        private int[,] puls;
        public paciente()
        {
            puls = new int[3, 4];
            Console.Write("ingresar nombre del paciente: ");
            nom = Console.ReadLine();
            for (int a = 0; a < puls.GetLength(0); a++)
            {
                for (int t = 0; t < puls.GetLength(1); t++)
                {
                    Console.Write("ingresar ritmo cardiaco registrado en el dia " + (a + 1));
                    string linea = Console.ReadLine();
                    puls[a, t] = int.Parse(linea);
                }
            }
        }
        public string retNom() { return nom; }
        public int[,] retPuls() { return puls; }
    }
    class salaMonitoreo
    {
        private paciente[] pacientes;
        public salaMonitoreo()
        {
            pacientes = new paciente[3];
            for (int a = 0; a < pacientes.Length; a++)
            {
                pacientes[a] = new paciente();
            }
        }
        public void imprimir()
        {
            for (int a = 0; a < pacientes.Length; a++)
            {
                Console.WriteLine("grilla completa de " + pacientes[a].retNom());
                for (int t = 0; t < pacientes[a].retPuls().GetLength(0); t++)
                {
                    Console.WriteLine("dia "+(t+1)+": ");
                    for (int g = 0; g < pacientes[a].retPuls().GetLength(1); g++)
                    {
                        Console.Write(pacientes[a].retPuls()[t, g]);
                    }
                    Console.WriteLine();
                }
            }
        }
        public void promedio()
        {
            int prom = 0;
            for (int a = 0; a < pacientes.Length; a++)
            {
                for (int t = 0; t < pacientes[a].retPuls().GetLength(0); t++)
                {
                    for (int g = 0; g < pacientes[a].retPuls().GetLength(1); g++)
                    {
                        prom += pacientes[a].retPuls()[t, g];   
                    }
                    
                }
                Console.WriteLine("el ritmo cardiaco promedio de " + pacientes[a].retNom()+" son: "+(prom/12));
            }
        }
        public void aviso()
        {
            for (int a = 0; a < pacientes.Length; a++)
            {
                for (int t = 0; t < pacientes[a].retPuls().GetLength(0); t++)
                {
                    for (int g = 0; g < pacientes[a].retPuls().GetLength(1); g++)
                    {
                        if (pacientes[a].retPuls()[t, g] >120)
                        {
                            Console.WriteLine("el/la paciente " + pacientes[a].retNom()+" presentó una lectura peligrosa de " + pacientes[a].retPuls()[t, g]);
                        }
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            salaMonitoreo sala = new salaMonitoreo();
            sala.imprimir();
            sala.promedio();
            sala.aviso();
            Console.ReadKey();
        }
    }
}
