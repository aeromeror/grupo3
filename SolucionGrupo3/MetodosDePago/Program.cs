using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDePago
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            var tarjeta = new TarjetaCredito();
            cliente.RealizarPago(tarjeta, 1000.2);

            var nuevaOpcion = new NuevaOpcionPago();
            var adaptador = new AdaptadorNuevaOpcionPago(nuevaOpcion);
            cliente.RealizarPago(adaptador, 1000.2);

            Console.ReadLine();
        }
    }
}
