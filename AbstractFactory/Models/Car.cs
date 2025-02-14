
using AbstractFactory.Interfaces;

namespace AbstractFactory.Models;

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a car");
    }
}