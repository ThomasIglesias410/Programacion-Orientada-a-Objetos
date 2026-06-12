using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    /*En una planta de fabricación automatizada, cada robot industrial realiza tareas de
ensamblaje complejas divididas en operaciones secundarias de duración variable.
● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
1. ModeloRobot.
2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
fila representa una de las 4 fases principales del proceso (Estructura,
Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
completar las distintas subtareas de esa fase (por ejemplo, en la fase de
Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
1).
3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
cada una de las 4 fases de fabricación cuántas sub-tareas requirió realizar

(definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
una de ellas.

● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
RobotEnsamblador. Implementar en PlantaIndustrial:
1. Un constructor que cargue la información de los 3 robots instalados en la
planta.
2. Un método que muestre un reporte detallado con los tiempos de operación
de cada robot fase por fase.
3. Un método que calcule el promedio general de tiempo por tarea de cada
robot y declare al &quot;Robot más Eficiente&quot; (aquel que registre el promedio de
tiempo por operación más bajo de la planta).*/
    class RobotEnsamblador
    {
        private string modeloRobot;
        private float[][] tiemposOperacion;
        public RobotEnsamblador()
        {
            tiemposOperacion = new float[4][];
            Console.Write("nombre del robot: ");
            modeloRobot = Console.ReadLine();
            for (int a  = 0;a<tiemposOperacion.Length;a++)
            {
                Console.Write("ingresar cuantas sub-fases tiene esta fase: ");
                string linea = Console.ReadLine();
                int x = int.Parse(linea);
                tiemposOperacion[a] = new float [x];
            }
            for(int a = 0;a<tiemposOperacion.Length; a++)
            {
                for (int t  = 0;t<tiemposOperacion[a].Length;t++)
                {
                    Console.Write("ingresar tiempo de esta subfase: ");
                    string linea = Console.ReadLine();
                    tiemposOperacion[a][t]=int.Parse(linea);
                }
            }
            
        }
        public string modelo() {  return modeloRobot; }
        public float[][] tiempo() {  return tiemposOperacion; }
    }
    class PlantaIndustrial
    {
        private RobotEnsamblador[] robots;
        public PlantaIndustrial()
        {
            robots = new RobotEnsamblador[3];
            for (int a = 0; a < robots.Length; a++)
            {
                robots[a]=new RobotEnsamblador();
            }
        }
        public void mostrar()
        {
            for(int a = 0; a<robots.Length;a++)
            {
                Console.WriteLine("robot N°" + (a + 1));
                for (int t = 0; t<robots[a].tiempo().Length; t++)
                {
                    Console.WriteLine("fase "+(t+1));
                    for (int i=0; i < robots[a].tiempo()[t].Length;i++)
                    {
                        Console.Write(robots[a].tiempo()[t][i] + " ");
                    }
                }
            }
        }
        public void promedio()
        {
            float prom = 0;
            float men = 1000000000000000;
            string nombre = "";
            for (int a = 0; a < robots.Length; a++)
            {
                prom = 0;
                for (int t = 0; t < robots[a].tiempo().Length; t++)
                {
                    for (int i = 0; i < robots[a].tiempo()[t].Length; i++)
                    {
                        prom += robots[a].tiempo()[t][i];
                    }
                    prom = prom / 4;
                    if (prom < men)
                    {
                        men = prom;
                        nombre = robots[a].modelo();
                    }
                }
            }
            Console.WriteLine("el robot mas eficiente es: " + nombre + " con un promedio de " + men + " segundos por tarea");
        }
        static void Main(string[] args)
        {
            PlantaIndustrial p = new PlantaIndustrial();
            p.mostrar();
            p.promedio();
            Console.ReadKey();
        }
    }
}
