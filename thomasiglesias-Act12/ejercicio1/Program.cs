using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*1. Sistema de Logística: Envíos por Sucursal
Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
cantidad diferente de paquetes por día dependiendo de su demanda.
● Definir un vector de tipo string para los nombres de las 3 sucursales.
● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
represente el peso (en kg) de cada paquete enviado.
● Métodos:
1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
paquetes se enviaron hoy para definir el tamaño de su fila.
2. Cargar el peso de cada paquete.
3. Imprimir el peso de todos los paquetes organizados por sucursal.
4. Calcular e informar el peso total despachado por cada sucursal.
5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
pertenece.*/
    internal class ejercicio1
    {
        private string[] suc;
        private int[][] paq;
        public ejercicio1()
        {
            suc = new string[3];
            paq = new int[3][];
            int cant = 0;
            for (int a = 0; a < 3; a++)
            {
                Console.Write("nombre de la sucursal: ");
                suc[a]= Console.ReadLine();
                Console.Write("cantidad de paquetes enviados hoy: ");
                string linea = Console.ReadLine();
                cant = int.Parse(linea);
                paq[a]=new int[cant];
                for (int t = 0; t < cant; t++)
                {
                    Console.Write("peso del paquete: ");
                    linea = Console.ReadLine();
                    paq[a][t] = int.Parse(linea);
                }

            }
        }
        public void imprimir()
        {
            for (int a = 0; a < paq.Length; a++)
            {
                Console.Write(suc[a]+": ");
                for (int t = 0; t < paq[a].Length; t++)
                {
                    Console.Write(paq[a][t]+ " ");
                }
                Console.WriteLine();
            }
        }
        public void pesototal() 
        {
            int pesotot = 0;
            for (int a = 0; a < paq.Length; a++)
            {
                for (int t = 0; t < paq[a].Length; t++)
                {
                    pesotot+= paq[a][t];
                }
            }
            Console.WriteLine("el peso total es: " + pesotot);

        }
        public void maspesado()
        {
            int may=paq[0][0];
            string nombre = "";
            for (int a = 0; a < paq.Length; a++)
            {
                for (int t = 0; t < paq[a].Length; t++)
                {
                    if (paq[a][t]>may)
                    {
                        may = paq[a][t];
                        nombre = suc[a];
                    }
                }
            }
            Console.WriteLine("el paquete mas pesado es de " + may + " de la sucursal " + nombre);
        }
        static void Main(string[] args)
        {
            ejercicio1 ej1 = new ejercicio1();
            ej1.imprimir();
            ej1.pesototal();
            ej1.maspesado();
            Console.ReadKey();
        }
    }
}
