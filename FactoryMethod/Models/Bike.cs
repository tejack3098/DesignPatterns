

using FactoryMethod.Interfaces;

namespace FactoryMethod.Models;

public class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a bike");
    }
}
