using DesignPatterns.Creational.Builder.Abstracts;

namespace DesignPatterns.Creational.Builder.Concrets;
public class Director
{
    private IBuilder _builder;

    public IBuilder Builder
    {
        set { _builder = value; }
    }

    public void MakeFoodWithPepperAndSalt(decimal pepper,decimal salt)
    {
        _builder.AddPepper(pepper);
        _builder.AddSalt(salt);
    }
    public void MakeFoodWithPepperSaltAndWater(decimal pepper, decimal salt, decimal water)
    {
        _builder.AddPepper(pepper);
        _builder.AddWater(water);
        _builder.AddSalt(salt);
    }
    public void MakeFoodWithSaltAndWater(decimal salt, decimal water)
    {
        _builder.AddWater(water);
        _builder.AddSalt(salt);
    }
}