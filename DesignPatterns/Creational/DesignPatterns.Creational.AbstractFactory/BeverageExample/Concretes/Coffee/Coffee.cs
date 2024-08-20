using DesignPatterns.Creational.AbstractFactory.BeverageExample.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.BeverageExample.Concretes.Coffee;
public class Coffee : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Coffee is preparing.");
    }
}
