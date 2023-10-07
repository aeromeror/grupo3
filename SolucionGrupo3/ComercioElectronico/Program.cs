using ComercioElectronico.Modelos;
using System;

namespace ComercioElectronico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            var televisor = new Electronico("televisor");
            cliente.VerificarExistenciaProducto(televisor);
            Console.ReadLine();
        }
    }
}
