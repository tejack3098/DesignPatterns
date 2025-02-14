
using AbstractFactory.Interfaces;

namespace AbstractFactory.Models;

public class BikeEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Starting a bike engine");
    }
}