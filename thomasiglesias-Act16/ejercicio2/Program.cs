using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejercicio2
{
    /*Plantear una clase Producto y otra clase Inventario.
La clase Producto debe tener como atributos privados el nombre, precio y
stock. Definir propiedades para acceder a estos atributos, asegurando que el
stock no pueda ser negativo y el precio sea mayor a cero.
La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
método para mostrar todos los productos ordenados de menor a mayor en
base al precio, además, mostrar el producto más caro y más barato del
inventario.*/
    
    class producto
    {
        private string nombre;
        private int precio;
        private int stock;
        public producto() 
        {
            Console.Write("ingrese nombre del producto: ");
            nombre = Console.ReadLine();
            Console.Write("ingresar precio del producto (no puede ser 0): ");
            string linea = Console.ReadLine();
            precio = int.Parse(linea);
            Console.Write("ingresar stock del producto (no puede ser negativo): ");
            linea = Console.ReadLine();
            stock = int.Parse(linea);

        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { if (precio > 0) { precio = value; }
                else { Console.WriteLine("el precio no puede ser 0 o menor "); }
            }
        }
        public int Stock
        {
            get { return stock; }
            set { if (stock >= 0) { stock = value; }
                else { Console.WriteLine("no se puede tener un valor negativo"); }
            }
        }
        class Inventario
        {
            private producto[] productos;
            private string[] nombres;
            private int[] precio;
            public Inventario()
            {
                productos = new producto[3];
                nombres = new string[3];
                precio = new int[3];
                for (int a = 0; a < productos.Length; a++)
                {
                    productos[a] = new producto();
                }
                for (int a = 0;a < productos.Length; a++)
                {
                    nombres[a]=productos[a].Nombre;
                    precio[a] = productos[a].Precio;
                }
            }
            public void ordenar()
            {
                for (int a = 0; a < nombres.Length-1; a++)
                {
                    for (int t = 0; t < precio.Length-a;t++)
                    {
                        if (precio[a] > precio[a+1])
                        {
                            int aux;
                            string nomAux;

                            aux = precio[a];
                            precio[a]=precio[a+1];
                            precio[a+1]=aux;

                            nomAux = nombres[a];
                            nombres[a] = nombres[a + 1];
                            nombres[a+1]=nomAux;
                        }
                    }
                }
            }
            public void imprimir()
            {
                int t = 0;
                for (int a = 0;a<productos.Length; a++)
                {
                    if (precio[a] > 0)
                    {
                        Console.WriteLine(nombres[a] + ": " + precio[a]);
                    }
                    else { Console.WriteLine("el precio no puede ser 0 o menor"); t++; }
                        
                }
                Console.WriteLine("el producto mas barato es: " + nombres[t]);
                Console.WriteLine("el producto mas caro es: " + nombres[(nombres.Length-1)]);
            }
        }
        static void Main(string[] args)
        {
            Inventario i = new Inventario();
            i.ordenar();
            i.imprimir();
            Console.ReadKey();
        }
    }
}
