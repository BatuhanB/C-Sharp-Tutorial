using DesignPatterns.Creational.AbstractFactory.BeverageExample.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.BeverageExample.Concretes.Tea;
public class Tea : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Tea is preparing.");
    }
}
