using System;

namespace DesignPatterns.Creational.Singleton;
public class Database
{
    private static Database _instance;

    public Database()
    {
        Console.WriteLine("Database instance created!");
    }

    public static Database Instance
    {
        get
        {
            _instance ??= new Database();
            return _instance;
        }
    }

    public void Query(string sql)
    {

        Console.WriteLine($"Executing query:{sql}");
    }
}
