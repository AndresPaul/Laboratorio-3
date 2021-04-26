namespace FactoryMethod
{
    public class Fanta : Gaseosa
    {
        public Fanta(string origen)
        {
            _descripcion = "Fanta";
            _origen = origen;
        }
    }
}
