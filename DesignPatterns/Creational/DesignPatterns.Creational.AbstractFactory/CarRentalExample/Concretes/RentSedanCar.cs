﻿using DesignPatterns.Creational.AbstractFactory.CarRentalExample.Models;

namespace DesignPatterns.Creational.AbstractFactory.CarRentalExample.Concretes;
public class RentSedanCar : BaseRentCar
{
    public override RentCarResponse DeliverCar(Customer customer)
    {
        return new RentCarResponse($"Sedan has been delivered to {customer}.");
    }

    public override RentCarResponse PrepareCar(Customer customer)
    {
        return new RentCarResponse($"Sedan has been started to preparing to {customer}.");
    }

    public override RentCarResponse RentCar(Customer customer)
    {
        return new RentCarResponse($"Sedan has been rented by {customer}.");
    }
}