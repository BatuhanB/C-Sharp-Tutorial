using DesignPatterns.Creational.AbstractFactory.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.Concretes.Lemonade;
public class LemonadeFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Lemonade();
    }
}
