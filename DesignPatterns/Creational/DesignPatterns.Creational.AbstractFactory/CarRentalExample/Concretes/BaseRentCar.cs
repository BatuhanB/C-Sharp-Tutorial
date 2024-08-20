using DesignPatterns.Creational.AbstractFactory.CarRentalExample.Abstracts;
using DesignPatterns.Creational.AbstractFactory.CarRentalExample.Models;

namespace DesignPatterns.Creational.AbstractFactory.CarRentalExample.Concretes;
public abstract class BaseRentCar : IRentCar
{
    public virtual RentCarResponse DeliverCar(Customer customer)
    {
        return new RentCarResponse("",false);
    }

    public virtual RentCarResponse PrepareCar(Customer customer)
    {
        return new RentCarResponse("", false);
    }

    public virtual RentCarResponse RentCar(Customer customer)
    {
        return new RentCarResponse("", false);
    }
}
