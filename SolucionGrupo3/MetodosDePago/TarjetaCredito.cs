using System;

namespace MetodosDePago
{
    public class TarjetaCredito : IMetodoPago
    {
        public bool Pago(double valor)
        {
            Console.WriteLine($"Pagando {valor}");
            return true;
        }
    }
}
