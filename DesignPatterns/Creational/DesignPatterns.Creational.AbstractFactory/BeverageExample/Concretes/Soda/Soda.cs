using DesignPatterns.Creational.AbstractFactory.BeverageExample.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.BeverageExample.Concretes.Soda;
public class Soda : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Soda is preparing.");
    }
}
