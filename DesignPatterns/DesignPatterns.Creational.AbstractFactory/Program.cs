//It helps us to create relations related each other objects
using DesignPatterns.Creational.AbstractFactory.Abstracts;
using DesignPatterns.Creational.AbstractFactory.Concretes.Coffee;
using DesignPatterns.Creational.AbstractFactory.Concretes.Lemonade;
using DesignPatterns.Creational.AbstractFactory.Concretes.Soda;
using DesignPatterns.Creational.AbstractFactory.Concretes.Tea;

ConsoleKeyInfo keyInfo;
string beverageType = string.Empty;

var factoryMap = new Dictionary<string, IBeverageFactory>
        {
            { "1", new CoffeeFactory() },
            { "2", new TeaFactory() },
            { "3", new SodaFactory() },
            { "4", new LemonadeFactory() }
        };

Console.WriteLine("Coffee: 1 \nTea: 2 \nSoda: 3 \nLemonade: 4 \n");
while (true)
{
    Console.WriteLine("\nSelect Beverage Type (or press ESC to exit):");
    var input = ReadLineOrEsc();
    if (input == null) break;

    beverageType = input;

    if (factoryMap.ContainsKey(beverageType))
    {
        var beverageFactory = factoryMap[beverageType];
        var beverage = beverageFactory.CreateBeverage();
        beverage.Prepare();
    }
    else
    {
        Console.WriteLine("Invalid beverage type. Please try again.");
    }
}

static string ReadLineOrEsc()
{
    var input = new List<char>();
    while (true)
    {
        var keyInfo = Console.ReadKey(intercept: true);
        if (keyInfo.Key == ConsoleKey.Escape)
        {
            return null;
        }
        else if (keyInfo.Key == ConsoleKey.Enter)
        {
            Console.WriteLine();
            return new string(input.ToArray());
        }
        else
        {
            Console.Write(keyInfo.KeyChar);
            input.Add(keyInfo.KeyChar);
        }
    }
}