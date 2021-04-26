namespace FactoryMethod
{
    public class FabricaCBBA : FabricaRefrescos
    {
        public override Gaseosa CrearGaseosa(string tipo)
        {
            if (tipo == "coca")
            {
                return new CocaCola("Cochabamba");
            }
            else if (tipo == "fanta")
            {
                return new Fanta("Cochabamba");
            }
            else if (tipo == "sprite")
            {
                return new Sprite("Cochabamba");
            }
            else
            {
                return null;
            }
        }
    }
}
