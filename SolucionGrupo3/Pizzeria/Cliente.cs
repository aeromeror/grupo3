namespace Pizzeria
{
    public class Cliente
    {
        public IPizzero pizzero { get; set; }

        public Cliente(IPizzero pizzero)
        {
            this.pizzero = pizzero;
        }

        public void RealizarPedido()
        {
            pizzero.EscogerTamano(TipoTamano.Pequena);
            pizzero.EscogerMasa(TipoMasa.Delgada);
            pizzero.EscogerBordeDeQueso(false);
            pizzero.AgregarIngredientes(new Ingrediente { nombre = "jamon", precio = 300 });
            System.Console.WriteLine($"Su pizza cuesta : {pizzero.ConsultarPrecio()}");

            //es necesario es crear clases absatractas de los ingredientes ?
        }
    }
}
