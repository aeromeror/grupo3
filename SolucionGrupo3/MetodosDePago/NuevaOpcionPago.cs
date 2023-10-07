using System.Globalization;

namespace MetodosDePago
{
    public class NuevaOpcionPago
    {
        public string Pagar(double valorPago)
        {
            return valorPago.ToString().Replace('.',',');
        }
    }
}
