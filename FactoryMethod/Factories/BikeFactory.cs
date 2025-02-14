

using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Factories;

public class BikeFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Bike();
    }
}