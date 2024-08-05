using DesignPatterns.Creational.Factory.LogisticScenerio.Abstracts;

namespace DesignPatterns.Creational.Factory.LogisticScenerio.Concrete;
public class SeaLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}
