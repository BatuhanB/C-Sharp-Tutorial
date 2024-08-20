using DesignPatterns.Creational.AbstractFactory.BeverageExample.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.BeverageExample.Concretes.Soda;
public class SodaFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Soda();
    }
}
