
using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories;

public class BikeFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new Bike();
    }

    public IEngine CreateEngine()
    {
        return new BikeEngine();
    }
}
