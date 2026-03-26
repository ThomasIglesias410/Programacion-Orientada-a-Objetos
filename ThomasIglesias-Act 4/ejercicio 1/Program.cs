using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
$500, realizar un programa que lea los sueldos que cobra cada empleado e
informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
de $300. Además el programa deberá informar el importe que gasta la empresa
en sueldos al personal.*/

            int cont = 0;  
            int empleados, sueldo;
            int importe = 0;
            int empmin = 0;
            int empmax  = 0;
            string linea;
            Console.Write("ingrese número de empleados: ");
            linea = Console.ReadLine();
            empleados = int.Parse(linea);
           

            while (cont<empleados) {
                
                Console.Write("ingrese sueldo de empleados(mayor a $100 y menos a $500): ");
                linea= Console.ReadLine();
                sueldo = int.Parse(linea);
                importe = importe + sueldo;
                if (sueldo>=100 && sueldo<=300) {

                    empmin++;
                
                }
                if (sueldo > 300)
                {

                    empmax++;

                }
                cont++;
            }
            Console.WriteLine("los empleados con sueldo entre 100 y 300 son: "+empmin);
            Console.WriteLine("los empleados con sueldo de mas de 300 son: " + empmax);
            Console.WriteLine("importe en sueldos:" + importe);
            Console.ReadKey();

        }
    }
}
