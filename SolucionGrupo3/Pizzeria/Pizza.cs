using System.Collections.Generic;

namespace Pizzeria
{
    public class Pizza
    {
        public TipoTamano tamano { get; set; }
        public TipoMasa masa { get; set; }
        public bool borderDeQueso { get; set; }
        public List<Ingrediente> ingredientes { get; set; } = new List<Ingrediente>();



        public void AgregarIngrediente(Ingrediente ingrediente)
        {
            ingredientes.Add(ingrediente);
        }

        public float CalcularPrecios()
        {
            float total = 0;
            foreach (var i in ingredientes)
            {
                total += i.precio;
            }
            total += (int)tamano;
            total += (int)masa;
            if (borderDeQueso)
                total += 500;
            return total;
        }
    }
}
