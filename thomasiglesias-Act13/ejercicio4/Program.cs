using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    /*4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
alumno y sus 4 calificaciones.
Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
Alumno.
Agregar los siguientes métodos:
a) Un método que imprima el nombre de cada alumno y su promedio.
b) Un método que muestre el nombre del alumno con el promedio más
alto.
c) Un método que indique qué alumnos tienen al menos una nota
desaprobada (nota menor a 6)*/
    class Alumno
    {
        private string nom;
        private int[] not;
        public Alumno()
        {
            not = new int[4];
            Console.Write("ingrese nombre del alumno: ");
            nom = Console.ReadLine();
            for (int a = 0; a < 4; a++)
            {
                Console.Write("ingrese notas");
            }
            public string retNom()
        {
            return nom;
        }
        public int[] retNot()
        {
            return not;
        }
    }

        class curso()
        { 
            private Alumno[] alumnos;
            public curso()
            {
                alumnos = new Alumno[3];
                alumnos[0] = new Alumno();
                alumnos[1] = new Alumno();
                alumnos[2] = new Alumno();
            }
            public void imprimirNom() 
            {
            Console.writeLine("nombres y promedios:")
            float prom = 0;
                for (int a = 0; a < 3; a++)
                {
                    console.Write(alumnos[a].nom+": ");
                    for (int t  = 0; t < 4;t++)
                    {
                        prom += alumnos[a].not[t];
                    }
                    Console.WriteLine(prom/4);
                    prom = 0;
                }
            }
            public void promMay()
            {
                Console.writeLine("nombre del alumno/a con el promedio mas alto:")
                float prom = 0;
                float may = 0;
                string nomMay = "";
                for (int a = 0; a < 3; a++)
                {
                    for (int t = 0; t < 4; t++)
                    {
                        prom += alumnos[a].not[t];
                    }
                    Console.WriteLine(prom / 4);
					if (prom > may)
					{
					    may = prom;
						nomMay = alumnos[a].nom;
				    }
					prom = 0;
                }
                console.WriteLine("el alumno con el promedio mas alto es " + nomMay + " con un promedio de " + may);
            }
            public void desaprobados()
            {
                Console.writeLine("nombre de los alumnos desaprobados:")
                string[] alumnosDes = new string[3];
                for (int a = 0;a < 3;a++)
                {
                    for(int t = 0;t < 4; t++)
                    {
                        if (alumnos[a].not[t] < 6)
                        {
                            alumnosDes[a] = alumnos[a].nom;
                        }
                    }
                }
                for (int a = 0; a<3;a++)
                {
                    if (alumnosDes[a]) 
                    {
                        Console.WriteLine(alumnosDes[a]);
                    }
                }
            }
        
            static void Main(string[] args)
            {
                curso curso = new curso();
                curso.imprimirNom();
                curso.promMay();
                curso.desaprobados();
                Console.ReadKey();

            }
        }
}
