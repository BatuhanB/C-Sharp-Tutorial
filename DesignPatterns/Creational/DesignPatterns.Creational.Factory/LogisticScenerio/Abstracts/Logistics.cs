namespace DesignPatterns.Creational.Factory.LogisticScenerio.Abstracts;
public abstract class Logistics
{
    public abstract ITransport CreateTransport();

    public void PlanDelivery()
    {
        var transport = CreateTransport();
        transport.Deliver();
    }
}
