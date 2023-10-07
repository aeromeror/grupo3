namespace ComercioElectronico.Modelos
{
    public class Cliente
    {
        public void VerificarExistenciaProducto(ProcesamientoProducto producto)
        {
            producto.VerificacionInventario();
            producto.Facturacion();
            producto.NotificacionCliente();

            producto.VerificarProducto();
            producto.ComprarMateriales();
            producto.Almacenar();
        }
    }
}
