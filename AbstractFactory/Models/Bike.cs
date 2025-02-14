
using AbstractFactory.Interfaces;

namespace AbstractFactory.Models;

public class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a bike");
    }
}