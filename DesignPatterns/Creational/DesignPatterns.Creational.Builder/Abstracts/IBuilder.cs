using DesignPatterns.Creational.Builder.Concrets;

namespace DesignPatterns.Creational.Builder.Abstracts;
public interface IBuilder
{
    IBuilder AddSalt(decimal salt);
    IBuilder AddWater(decimal water);
    IBuilder AddPepper(decimal pepper);
    Food Build();
}
