using System;

namespace MetodosDePago
{
    public class AdaptadorNuevaOpcionPago : IMetodoPago
    {
        NuevaOpcionPago NuevaOpcionPago { get; set; }

        public AdaptadorNuevaOpcionPago(NuevaOpcionPago NuevaOpcionPago)
        {
            this.NuevaOpcionPago = NuevaOpcionPago;   
        }

        public bool Pago(double valor)
        {
            var nuevoValor = NuevaOpcionPago.Pagar(valor);
            Console.WriteLine($"pagando {nuevoValor}");
            return true;
        }
    }

}
