using DesignPatterns.Creational.AbstractFactory.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.Concretes.Tea;
public class Tea : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Tea is preparing.");
    }
}
