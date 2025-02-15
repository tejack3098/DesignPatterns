
using AbstractFactory.Interfaces;

namespace AbstractFactory.Models;

public class CarEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Starting a car engine");
    }
}