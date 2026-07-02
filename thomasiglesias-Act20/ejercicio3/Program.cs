using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*Actividad 3: Estadísticas de visitas a zonas arqueológicas
Problema:
Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
arqueológicas durante 4 semanas.
Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
días. Luego:
 Calcular el total de visitas por zona y almacenarlo en un vector.
 Mostrar los datos en forma tabular.
 Agregar estos resultados a una lista llamada zonasVisitadas que contenga
nombres de zonas y total de visitas.
 Determinar cuál fue la zona más visitada.*/

    class program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 4];
            int[] totales = new int[3];
            string[] zonas = { "zona 1", "zona 2", "zona 3" };

            List<string> zonasvisitadas = new List<string>();

            for (int a = 0; a < 3; a++)
            {
                int suma = 0;

                for (int t = 0; t < 4; t++)
                {
                    Console.Write("visitas zona " + (a + 1) + " semana " + (t + 1) + ": ");
                    matriz[a, t] = int.Parse(Console.ReadLine());
                    suma += matriz[a, t];
                }

                totales[a] = suma;
                zonasvisitadas.Add(zonas[a] + " - " + suma);
            }

            int max = -1;
            string zonaMax = "";

            for (int a = 0; a < 3; a++)
            {
                if (totales[a] > max)
                {
                    max = totales[a];
                    zonaMax = zonas[a];
                }
            }
            Console.WriteLine("zona mas visitada: " + zonaMax);
            Console.ReadKey();
        }
    }
}
