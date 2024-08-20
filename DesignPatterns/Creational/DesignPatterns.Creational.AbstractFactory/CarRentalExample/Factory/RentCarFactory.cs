using DesignPatterns.Creational.AbstractFactory.CarRentalExample.Abstracts;
using DesignPatterns.Creational.AbstractFactory.CarRentalExample.Concretes;
using DesignPatterns.Creational.AbstractFactory.CarRentalExample.Enums;

namespace DesignPatterns.Creational.AbstractFactory.CarRentalExample.Factory;
public class RentCarFactory : IRentCarFactory
{
    public IRentCar CreateCar(CarTypes carType)
    {
        IRentCar rentCar = null;
        if (carType > 0)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            rentCar = carType switch
            {
                CarTypes.Sedan => new RentSedanCar(),
                CarTypes.Sport => new RentSportCar(),
                CarTypes.Station => new RentStationCar(),
                _ => null,
            };
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        }
        return rentCar;
    }
}
