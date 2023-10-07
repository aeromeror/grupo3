namespace MetodosDePago
{
    public class Cliente
    {
        public void RealizarPago(IMetodoPago metodoPago, double valor)
        {
            metodoPago.Pago(valor);
        }
    }
}
