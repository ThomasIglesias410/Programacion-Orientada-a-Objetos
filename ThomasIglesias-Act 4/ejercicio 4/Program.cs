using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
finalizar al ingresar un valor negativo en el número de cuenta.
Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
informe:
a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
que:
Estado de la cuenta:
○ “Acreedor” si el saldo es &gt;0.
○ “Deudor” si el saldo es &lt;0.
○ “Nulo” si el saldo es =0.
b) La suma total de los saldos acreedores.*/
            int saldo = 0;
            int total = 0;
            int numero_cuenta=0;
            string linea;
            do
            {
                
                    Console.Write("numero de cuenta: ");
                    linea = Console.ReadLine();
                    numero_cuenta = int.Parse(linea);
                if (numero_cuenta >= 0)
                {
                    Console.Write("saldo: ");
                    linea = Console.ReadLine();
                    saldo = int.Parse(linea);
                    if (saldo > 0)
                    {

                        Console.WriteLine("acreedor");
                        total = total + saldo;
                    }
                    else
                    {
                        if (saldo < 0)
                        {

                            Console.WriteLine("deudor");

                        }
                        else
                        {

                            Console.WriteLine("nulo");

                        }
                    }
                }
            } while (numero_cuenta >= 0);
            Console.WriteLine("saldo acreedores: " + total);
            Console.ReadKey();
        }
    }
}
