using DesignPatterns.Creational.AbstractFactory.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.Concretes.Coffee;
public class Coffee : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Coffee is preparing.");
    }
}
