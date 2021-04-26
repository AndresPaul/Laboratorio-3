using System;

namespace FactoryMethod
{
    public abstract class Gaseosa
    {
        protected string _descripcion;
        protected string _origen;

        public void Print()
        {
            Console.WriteLine(string.Format("{0} hecha en {1}", _descripcion, _origen));
        }
    }
}
