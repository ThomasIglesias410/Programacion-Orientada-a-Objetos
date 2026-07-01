using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*Plantear una clase parcial ReservaHotel.
En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
noches sea mayor a 0. Estos valores son cargados desde la consola.
En el segundo archivo, agregar un método que calcule el total a pagar según la
habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
noche).
Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            reservaHotel[] clientes = new reservaHotel[3];
            int mayor = 0;
            string mayorN = "";
            for (int a = 0; a < clientes.Length; a++)
            {
                clientes[a] = new reservaHotel();
                clientes[a].CalcularTotal();
                if (clientes[a].Precio>mayor)
                {
                    mayor = clientes[a].Precio;
                    mayorN = clientes[a].Nombrecliente;
                }
            }
            Console.WriteLine("el cliente que tendra que pagar más es " + mayorN + " y tiene que pagar " + mayor);
            Console.ReadKey();
        }
    }
}
