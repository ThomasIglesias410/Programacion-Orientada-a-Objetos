using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    partial class reservaHotel
    {
        protected string nombrecliente;
        protected int cantidadnoches;
        protected string tipohabitacion;

        public string Nombrecliente
        {
            set { nombrecliente = value; }
            get { return nombrecliente; }
        }

        public int Cantidadnoches
        {
            set { cantidadnoches = value; }
            get { return cantidadnoches; }
        }

        public string Tipohabitacion
        {
            set { tipohabitacion = value; }
            get { return tipohabitacion; }
        }

        public reservaHotel()
        {
            Console.Write("ingrese nombre del cliente: ");
            nombrecliente = Console.ReadLine();
            do
            {
                Console.Write("ingrese la cantidad de noches: ");
                string linea = Console.ReadLine();
                cantidadnoches = int.Parse(linea);
            }
            while (cantidadnoches <= 0);
            Console.Write("ingrese el tipo de habitacion (simple, doble o suite): ");
            tipohabitacion = Console.ReadLine();
        }
    }
}