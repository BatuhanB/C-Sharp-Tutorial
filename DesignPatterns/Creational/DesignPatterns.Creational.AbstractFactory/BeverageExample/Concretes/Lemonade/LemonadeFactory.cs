using DesignPatterns.Creational.AbstractFactory.BeverageExample.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.BeverageExample.Concretes.Lemonade;
public class LemonadeFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Lemonade();
    }
}
