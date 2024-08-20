using DesignPatterns.Creational.AbstractFactory.BeverageExample.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.BeverageExample.Concretes.Tea;
public class TeaFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Tea();
    }
}
