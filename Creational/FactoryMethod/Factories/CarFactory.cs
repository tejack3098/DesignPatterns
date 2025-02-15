
using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Factories;

public class CarFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Car();
    }
}