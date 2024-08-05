using DesignPatterns.Creational.AbstractFactory.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.Concretes.Soda;
public class Soda : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Soda is preparing.");
    }
}
