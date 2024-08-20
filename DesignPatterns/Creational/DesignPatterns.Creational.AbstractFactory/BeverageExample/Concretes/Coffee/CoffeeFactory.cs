using DesignPatterns.Creational.AbstractFactory.BeverageExample.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.BeverageExample.Concretes.Coffee;
public class CoffeeFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Coffee();
    }
}
