using System;

namespace FactoryMethod.Consola
{
    class MainClass
    {
        static void Main(string[] args)
        {

            FabricaRefrescos fabrica;
            Gaseosa gaseosa;

            fabrica = new FabricaCBBA();

            gaseosa = fabrica.CrearGaseosa("coca");
            gaseosa.Print();
            gaseosa = fabrica.CrearGaseosa("fanta");
            gaseosa.Print();
            gaseosa = fabrica.CrearGaseosa("sprite");
            gaseosa.Print();

            Console.WriteLine ("\n");

            fabrica = new FabricaLPZ();

            gaseosa = fabrica.CrearGaseosa("coca");
            gaseosa.Print();
            gaseosa = fabrica.CrearGaseosa("fanta");
            gaseosa.Print();
            gaseosa = fabrica.CrearGaseosa("sprite");
            gaseosa.Print();

            Console.WriteLine ("\n");

            fabrica = new FabricaSCZ();

            gaseosa = fabrica.CrearGaseosa("coca");
            gaseosa.Print();
            gaseosa = fabrica.CrearGaseosa("fanta");
            gaseosa.Print();
            gaseosa = fabrica.CrearGaseosa("sprite");
            gaseosa.Print();
            Console.ReadKey();
        }
    }
}
/*
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
*/