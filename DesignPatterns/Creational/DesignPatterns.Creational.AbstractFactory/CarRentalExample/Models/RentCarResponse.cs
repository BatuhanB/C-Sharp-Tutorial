namespace DesignPatterns.Creational.AbstractFactory.CarRentalExample.Models;
public class RentCarResponse
{
    public string Message { get; private set; }
    public bool Status { get; private set; }

    public RentCarResponse(string message, bool status = false)
    {
        Message = message;
        Status = status;
    }
}
