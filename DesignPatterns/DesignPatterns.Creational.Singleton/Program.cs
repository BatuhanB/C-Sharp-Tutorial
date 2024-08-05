//It allocated in memory once and still lives through lifetime

using DesignPatterns.Creational.Singleton;

var ins1 = Database.Instance;
ins1.Query("Select * From users");

var ins2 = Database.Instance;
ins2.Query("Select * From products");

Console.WriteLine($"db1 == db2: {ins1 == ins2}");