namespace FactoryMethod
{
    public class FabricaSCZ : FabricaRefrescos
    {
        public override Gaseosa CrearGaseosa(string tipo)
        {
            if (tipo == "sprite")
            {
                return new Sprite("Santa Cruz");
            }
            else if (tipo == "coca")
            {
                return new CocaCola("Santa Cruz");
            }
            else if (tipo == "fanta")
            {
                return new Fanta("Santa Cruz");
            }
            else
            {
                return null;
            }
        }
    }
}