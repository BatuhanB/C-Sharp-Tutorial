using DesignPatterns.Creational.Factory.LogisticScenerio.Abstracts;

namespace DesignPatterns.Creational.Factory.LogisticScenerio.Concrete;
public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Ship is delivering.");
    }
}
