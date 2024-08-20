using DesignPatterns.Creational.AbstractFactory.CarRentalExample.Enums;

namespace DesignPatterns.Creational.AbstractFactory.CarRentalExample.Abstracts;
public interface IRentCarFactory
{
    IRentCar CreateCar(CarTypes carType);
}
