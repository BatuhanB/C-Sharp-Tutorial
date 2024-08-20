namespace DesignPatterns.Creational.AbstractFactory.CarRentalExample.Models;
public class Customer
{
    private string FirstName;
    private string LastName;

    public Customer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"{FirstName} - {LastName}";
    }
}
