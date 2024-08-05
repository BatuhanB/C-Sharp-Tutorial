using DesignPatterns.Creational.AbstractFactory.Abstracts;

namespace DesignPatterns.Creational.AbstractFactory.Concretes.Lemonade;
public class Lemonade : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Lemonade is preparing.");
    }
}
