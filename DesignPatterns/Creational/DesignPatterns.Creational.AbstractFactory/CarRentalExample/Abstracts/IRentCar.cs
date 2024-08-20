using DesignPatterns.Creational.AbstractFactory.CarRentalExample.Models;

namespace DesignPatterns.Creational.AbstractFactory.CarRentalExample.Abstracts;
public interface IRentCar
{
    RentCarResponse RentCar(Customer customer);
    RentCarResponse PrepareCar(Customer customer);
    RentCarResponse DeliverCar(Customer customer);
}
