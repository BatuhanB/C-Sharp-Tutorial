namespace DesignPatterns.Creational.Prototype;
public class Communication : IPrototype<Communication>
{
    public string Id { get; private set; }
    public string Alias { get; private set; }

    public Communication(string alias)
    {
        Id = Guid.NewGuid().ToString();
        Alias = alias;
    }

    public Communication(string id, string alias)
    {
        Id = id;
        Alias = alias;
    }

    public Communication Clone()
    {
        return new Communication(Id, Alias);
    }

    public override string ToString()
    {
        return $"CommId: {Id} - Alias: {Alias}";
    }
}
