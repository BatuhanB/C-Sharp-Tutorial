using DesignPatterns.Creational.AbstractFactory.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.Concretes.Tea;
public class TeaFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Tea();
    }
}
