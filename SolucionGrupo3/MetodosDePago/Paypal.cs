using System;

namespace MetodosDePago
{
    public class Paypal : IMetodoPago
    {
        public bool Pago(double valor)
        {
            Console.WriteLine("Pagando");
            return true;
        }
    }


}
