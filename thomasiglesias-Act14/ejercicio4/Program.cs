using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
//    Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual.El constructor de la clase debe cargar estos atributos por teclado.
//Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo.El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
//Implementar en la clase Sucursal los siguientes métodos:
//Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio* Stock).
//Un método que busque y muestre el nombre del artículo más caro del local.
//Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).

    class articulo
    {
        private string nom;
        private int precio;
        private int stock;
        public articulo()
        {
            Console.Write("ingresar nombre del atleta: ");
            nom = Console.ReadLine();
            Console.Write("ingresar tiempo del atleta");
            string linea = Console.ReadLine();
            precio = int.Parse(linea);
            Console.Write("ingresar tiempo del atleta");
            linea = Console.ReadLine();
            stock = int.Parse(linea);
        }
        public string retNom() { return nom; }
        public int retPrecio() { return precio; }
        public int retStock() { return stock; }
    }
    class sucursal
    {
        private articulo[] articulos;
        public sucursal()
        {
            articulos = new articulo[3];
            Console.WriteLine("ingresar el numero de la sucursal: " + Console.ReadLine());
            for (int a = 0; a < articulos.Length; a++)
            {
                articulos[a] = new articulo();
            }
        }
        public void imprimir()
        {
            for (int a = 0; a < articulos.Length; a++)
            {
                Console.WriteLine("nombre del articulo: " + articulos [a].retNom() + " valor total en inventario: " + (articulos[a].retPrecio() * articulos[a].retStock()));
            }
        }
        public void caro()
        {
            float may = articulos[0].retPrecio();
            string nommay = articulos[0].retNom();
            for (int a = 0; a < articulos.Length; a++)
            {
                if (may < articulos[a].retPrecio())
                {
                    may = articulos[a].retPrecio();
                    nommay = articulos[a].retNom();
                }

            }
            Console.WriteLine("el producto mas caro es " + nommay + " con un precio de " + may);
        }
        public void reposicion()
        {
            for(int a = 0;a < articulos.Length; a++)
            {
                Console.Write(articulos[a].retNom());
                if (articulos[a].retStock()<5)
                {
                    Console.Write(" necesita reposicion urgente");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            sucursal s = new sucursal();
            s.imprimir();
            s.caro();               
            s.reposicion();
            Console.ReadKey();
        }
    }
}
