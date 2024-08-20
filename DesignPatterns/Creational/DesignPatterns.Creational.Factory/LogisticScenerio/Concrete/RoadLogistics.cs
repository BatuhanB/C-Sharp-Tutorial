using DesignPatterns.Creational.Factory.LogisticScenerio.Abstracts;

namespace DesignPatterns.Creational.Factory.LogisticScenerio.Concrete;
public class RoadLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}
