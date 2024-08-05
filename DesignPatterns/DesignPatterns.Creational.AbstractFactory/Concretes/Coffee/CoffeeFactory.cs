using DesignPatterns.Creational.AbstractFactory.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.Concretes.Coffee;
public class CoffeeFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Coffee();
    }
}
