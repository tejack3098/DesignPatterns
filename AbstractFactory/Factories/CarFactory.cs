
using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories;

public class CarFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new Car();
    }

    public IEngine CreateEngine()
    {
        return new CarEngine();
    }
}