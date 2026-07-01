using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public partial class reservaHotel
    {
        protected int precio;
        public void CalcularTotal()
        {
            precio = 0;

            if (tipohabitacion == "Simple")
            {
                precio = 5000;
            }
            else if (tipohabitacion == "Doble")
            {
                precio = 8000;
            }
            else if (tipohabitacion == "Suite")
            {
                precio = 12000;
            }
            precio = precio * cantidadnoches;
        }
        public int Precio
        {
            set {precio=value;}
            get {return precio;}
        }
    }
}