namespace Pizzeria
{
    public interface IPizzero
    {
        void EscogerTamano(TipoTamano tamano);
        void EscogerMasa(TipoMasa masa);
        void AgregarIngredientes(Ingrediente ingrediente);
        void EscogerBordeDeQueso(bool tieneExtraQueso);
        float ConsultarPrecio();
    }
}
