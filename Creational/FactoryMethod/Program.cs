
using FactoryMethod.Factories;
using FactoryMethod.Interfaces;

Console.WriteLine("Select a vehicle type (Car/Bike):");

string? vehicleType = Console.ReadLine()?.ToLower();
VehicleFactory? factory = vehicleType switch
{
    "car" => new CarFactory(),
    "bike" => new BikeFactory(),
    _ => null
};

if (factory == null)
{
    Console.WriteLine("Invalid vehicle type.");
    return;
}

IVehicle vehicle = factory.CreateVehicle();
vehicle.Drive();