using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
(un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
asegurando mediante validaciones lógicas que:
 La duración en minutos sea estrictamente mayor a cero (0).
 La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
un valor por defecto de 1).
La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
películas ordenadas de mayor a menor en base a su duración. Además, el método debe
informar el título de la película con mejor calificación y cuál es la película más corta del
catálogo.*/
    class pelicula
    {
        private string titulo;
        private int duracion;
        private int calificacion;
        public pelicula()
        {
            string linea;
            Console.Write("ingresar titulo: ");
            titulo = Console.ReadLine();
            do
            {
                Console.Write("ingresar duracion de la pelicula (mayor a 0): ");
                linea = Console.ReadLine();
                duracion = int.Parse(linea);
            } while (duracion <= 0);
            Console.Write("ingresar calificacion de la pelicula (del 1 al 5): ");
            linea = Console.ReadLine();
            calificacion = int.Parse(linea);
            if (calificacion < 1 || calificacion > 5)
            {
                calificacion = 1;
            }
        }
        public string Titulo
        {
            set
            {
                titulo = value;
            }
            get
            {
                return titulo;
            }
        }
        public int Calificacion
        {
            set
            {
                calificacion = value;
            }
            get
            {
                return calificacion;
            }
        }
        public int Duracion
        {
            set
            {
                duracion = value;
            }
            get
            {
                return duracion;
            }
        }
    }
        class catalogo
        {
            private pelicula[] peliculas;
            public catalogo()
            {
                peliculas = new pelicula[3];
                for (int a = 0; a < peliculas.Length; a++)
                {
                    peliculas[a] = new pelicula();
                }
            }
            public void imprimir()
            {
                int aux;
                string auxN;
                int may = peliculas[0].Calificacion;
                string mayN= peliculas[0].Titulo;
                for (int a = 0; a < peliculas.Length-1; a++)
                {
                    for (int t = 0; t < peliculas.Length - 1; t++)
                    {
                        if (peliculas[a].Duracion < peliculas[(a + 1)].Duracion)
                        {
                            aux = peliculas[(a + 1)].Duracion;
                            peliculas[(a + 1)].Duracion = peliculas[a].Duracion;
                            peliculas[a].Duracion = aux;
                            auxN = peliculas[(a+1)].Titulo;
                            peliculas[(a+1)].Titulo = peliculas[a].Titulo;
                            peliculas[a].Titulo = auxN;
                    }
                    }
                }
                for (int a = 0;a < peliculas.Length; a++)
                {
                    Console.WriteLine(peliculas[a].Titulo + ": " + peliculas[a].Duracion);
                    if (peliculas[a].Calificacion > may)
                    {
                        may = peliculas[a].Calificacion;
                        mayN = peliculas[a].Titulo;
                    }   
                }
            Console.WriteLine("la pelicula con mayor calificacion es: "+mayN);
            }   
            static void Main(string[] args)
            {
                catalogo c = new catalogo();
                c.imprimir();
            }
        }
    
}

