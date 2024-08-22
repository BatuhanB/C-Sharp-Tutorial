using DesignPatterns.Creational.Prototype;

Communication communication = new ("TLS");
Communication communication2 = new ("HTTP");

Console.WriteLine($"Comm1 => {communication}");
Console.WriteLine($"Comm1 Clone => {communication.Clone()}");

Console.WriteLine("\n");

Console.WriteLine($"Comm2 => {communication2}");
Console.WriteLine($"Comm2 Clone => {communication2.Clone()}");

Console.ReadLine();