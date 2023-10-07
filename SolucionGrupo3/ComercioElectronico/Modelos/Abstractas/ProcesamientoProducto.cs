using System;

namespace ComercioElectronico.Modelos
{
    public abstract class ProcesamientoProducto
    {
        public abstract string Nombre { get; set; }

        public ProcesamientoProducto(string nombre)
        {
            Nombre = nombre;
        }

        public void VerificacionInventario()
        {
            Console.WriteLine("Verificando Inventario");
        }
        public void Facturacion()
        {
            Console.WriteLine("Generando Factruras");
        }
        public void NotificacionCliente()
        {
            Console.WriteLine("Notificando al cliente");
        }

        public abstract void VerificarProducto();
        public abstract void ComprarMateriales();
        public abstract void Almacenar();
    }
}
