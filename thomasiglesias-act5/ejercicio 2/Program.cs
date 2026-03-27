using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Realizar un programa que lea los lados de n triángulos, e informar:
a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
b) Cantidad de triángulos de cada tipo.
c) Tipo de triángulo que posee menor cantidad.*/
            int num,lado1,lado2,lado3;
            int esc = 0;
            int iso = 0;
            int equ = 0;
            Console.Write("ingrese número de triangulos: ");
            string linea = Console.ReadLine();
            num = int.Parse(linea);
            for (int i = 0; i < num; i++)
            {


                    Console.Write("ingrese lado de triangulo: ");
                    linea = Console.ReadLine();
                    lado1 = int.Parse(linea);

                    Console.Write("ingrese lado de triangulo: ");
                    linea = Console.ReadLine();
                    lado2 = int.Parse(linea);

                    Console.Write("ingrese lado de triangulo: ");
                    linea = Console.ReadLine();
                    lado3 = int.Parse(linea);
                    if (lado1 == lado2 && lado1 == lado3)
                    {

                        Console.WriteLine("este triangulo es EQUILATERO");
                        equ++;

                    }

                    else
                    {

                        if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                        {
                            Console.WriteLine("este triangulo es ISOSCELES");
                            iso++;
                        }
                        else
                        {
                            Console.WriteLine("este triangulo es ESCALENO");
                            esc++;
                        }
                    }
                
                Console.WriteLine("EQUILATEROS: " + equ);
                Console.WriteLine("ISOCELES: " + iso);
                Console.WriteLine("ESCALENOS: " + esc);
                if (equ < iso && equ < esc)
                {
                    Console.WriteLine("los EQUILATEROS tienen la menor cantidad");
                }
                else 
                {

                    if (iso < equ && iso < esc)
                    {
                        Console.WriteLine("los ISOCELES tienen la menor cantidad");
                    }
                    else
                    { Console.WriteLine("los ESCALENOS tienen la menor cantidad"); }
            
            }
            Console.ReadKey();
            }
        }
    }
}

