using DesignPatterns.Creational.AbstractFactory.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.Concretes.Soda;
public class SodaFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Soda();
    }
}
