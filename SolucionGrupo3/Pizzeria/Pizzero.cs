using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Pizzero : IPizzero
    {
        public Pizza pizza { get; set; }

        public Pizzero() { 
            pizza = new Pizza();
        }

        public float ConsultarPrecio()
        {
            return pizza.CalcularPrecios();
        }

        public void EscogerBordeDeQueso(bool tieneExtraQueso)
        {
            pizza.borderDeQueso = tieneExtraQueso;
        }

        public void AgregarIngredientes(Ingrediente ingrediente)
        {
            pizza.AgregarIngrediente(ingrediente);
        }

        public void EscogerMasa(TipoMasa masa)
        {
            pizza.masa = masa;
        }

        public void EscogerTamano(TipoTamano tamano)
        {
            pizza.tamano = tamano;

        }
    }
}
