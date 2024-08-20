
#region BeverageExample

//It helps us to create relations related each other objects
//using DesignPatterns.Creational.AbstractFactory.BeverageExample.Abstracts;
//using DesignPatterns.Creational.AbstractFactory.BeverageExample.Concretes.Coffee;
//using DesignPatterns.Creational.AbstractFactory.BeverageExample.Concretes.Lemonade;
//using DesignPatterns.Creational.AbstractFactory.BeverageExample.Concretes.Soda;
//using DesignPatterns.Creational.AbstractFactory.BeverageExample.Concretes.Tea;

//ConsoleKeyInfo keyInfo;
//string beverageType = string.Empty;

//var factoryMap = new Dictionary<string, IBeverageFactory>
//        {
//            { "1", new CoffeeFactory() },
//            { "2", new TeaFactory() },
//            { "3", new SodaFactory() },
//            { "4", new LemonadeFactory() }
//        };

//Console.WriteLine("Coffee: 1 \nTea: 2 \nSoda: 3 \nLemonade: 4 \n");
//while (true)
//{
//    Console.WriteLine("\nSelect Beverage Type (or press ESC to exit):");
//    var input = ReadLineOrEsc();
//    if (input == null) break;

//    beverageType = input;

//    if (factoryMap.ContainsKey(beverageType))
//    {
//        var beverageFactory = factoryMap[beverageType];
//        var beverage = beverageFactory.CreateBeverage();
//        beverage.Prepare();
//    }
//    else
//    {
//        Console.WriteLine("Invalid beverage type. Please try again.");
//    }
//}

//static string ReadLineOrEsc()
//{
//    var input = new List<char>();
//    while (true)
//    {
//        var keyInfo = Console.ReadKey(intercept: true);
//        if (keyInfo.Key == ConsoleKey.Escape)
//        {
//            return null;
//        }
//        else if (keyInfo.Key == ConsoleKey.Enter)
//        {
//            Console.WriteLine();
//            return new string(input.ToArray());
//        }
//        else
//        {
//            Console.Write(keyInfo.KeyChar);
//            input.Add(keyInfo.KeyChar);
//        }
//    }
//}

#endregion

#region CarRental



using DesignPatterns.Creational.AbstractFactory.CarRentalExample.Abstracts;
using DesignPatterns.Creational.AbstractFactory.CarRentalExample.Enums;
using DesignPatterns.Creational.AbstractFactory.CarRentalExample.Factory;
using DesignPatterns.Creational.AbstractFactory.CarRentalExample.Models;

ConsoleKeyInfo keyInfo;

var factoryMap = new Dictionary<int, CarTypes>
        {
            { 1, CarTypes.Sedan },
            { 2, CarTypes.Sport },
            { 3, CarTypes.Station },
        };

Customer customer = GetCustomerInformations();

Console.WriteLine("Sedan: 1 \nSport: 2 \nStation: 3 \n");
while (true)
{
    Console.WriteLine("\nSelect Car Type To Rent (or press ESC to exit):");
    var input = ReadLineOrEsc();
    if (input == null) break;

    if (factoryMap.ContainsKey(Convert.ToInt32(input)))
    {
        var carType = factoryMap[Convert.ToInt32(input)];
        var factory = new RentCarFactory();

        var car = factory.CreateCar(carType);
        RentalOperations(customer, car);
    }
    else
    {
        Console.WriteLine("Invalid car type. Please try again.");
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

static Customer GetCustomerInformations()
{
    Console.Write("Enter Your First Name:");
    var firstName = Console.ReadLine();


    Console.Write("Enter Your Last Name:");
    var lastName = Console.ReadLine();

    var customer = new Customer(firstName!, lastName!);
    return customer;
}

static void RentalOperations(Customer customer, IRentCar car)
{
    Console.WriteLine($"{car.RentCar(customer).Message}");
    Thread.Sleep(1000);
    Console.WriteLine($"{car.PrepareCar(customer).Message}");
    Thread.Sleep(1000);
    Console.WriteLine($"{car.DeliverCar(customer).Message}");
}

#endregion