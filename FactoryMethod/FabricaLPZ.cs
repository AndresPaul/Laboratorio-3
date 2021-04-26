namespace FactoryMethod
{
    public class FabricaLPZ : FabricaRefrescos
    {
        public override Gaseosa CrearGaseosa(string tipo)
        {
            if (tipo == "fanta")
            {
                return new Fanta("La Paz");
            }
            else if (tipo == "coca")
            {
                return new CocaCola("La Paz");
            }
            else if (tipo == "sprite")
            {
                return new Sprite("La Paz");
            }
            else
            {
                return null;
            }
        }
    }
}
