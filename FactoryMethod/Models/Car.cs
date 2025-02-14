

using FactoryMethod.Interfaces;

namespace FactoryMethod.Models;

public class Car : IVehicle
{

    public void Drive()
    {
        Console.WriteLine("Driving a car");
    }
}