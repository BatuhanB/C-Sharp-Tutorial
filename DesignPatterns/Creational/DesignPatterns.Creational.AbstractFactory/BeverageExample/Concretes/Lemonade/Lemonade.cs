using DesignPatterns.Creational.AbstractFactory.BeverageExample.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.BeverageExample.Concretes.Lemonade;
public class Lemonade : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Lemonade is preparing.");
    }
}
