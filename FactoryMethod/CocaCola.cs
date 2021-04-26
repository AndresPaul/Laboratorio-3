namespace FactoryMethod
{
    public class CocaCola : Gaseosa
    {
        public CocaCola(string origen)
        {
            _descripcion = "Coca-Cola";
            _origen = origen;
        }
    }
}
