using System;

namespace ComercioElectronico.Modelos
{
    public class Alimento : ProcesamientoProducto
    {
        public override string Nombre { get; set; }

        public Alimento(string nombre) : base(nombre)
        {
        }

        public override void Almacenar()
        {
            Console.WriteLine($"Almacenando {Nombre}");
        }

        public override void ComprarMateriales()
        {
            Console.WriteLine($"Comprando materiales {Nombre}");
        }

        public override void VerificarProducto()
        {
            Console.WriteLine($"Verificando {Nombre}");
        }
    }
}
