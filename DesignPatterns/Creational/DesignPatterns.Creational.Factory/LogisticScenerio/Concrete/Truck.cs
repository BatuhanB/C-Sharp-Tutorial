using DesignPatterns.Creational.Factory.LogisticScenerio.Abstracts;

namespace DesignPatterns.Creational.Factory.LogisticScenerio.Concrete;
public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Truck is delivering.");
    }
}
