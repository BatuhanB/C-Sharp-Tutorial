using DesignPatterns.Creational.Builder.Abstracts;

namespace DesignPatterns.Creational.Builder.Concrets;
public class RegularFoodBuilder : IBuilder
{
    private readonly Food _food;

    public RegularFoodBuilder()
    {
        _food = new Food();
    }
    public IBuilder AddPepper(decimal pepper)
    {
        _food.Pepper = pepper;
        return this;
    }

    public IBuilder AddSalt(decimal salt)
    {
        _food.Salt = salt;
        return this;
    }

    public IBuilder AddWater(decimal water)
    {
        _food.Water = water;
        return this;
    }

    public Food Build()
    {
        return _food;
    }
}
