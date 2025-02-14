
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

// Create a car Factory
IVehicleFactory carFactory = new CarFactory();

IVehicle car = carFactory.CreateVehicle();
IEngine carEngine = carFactory.CreateEngine();

car.Drive();    
carEngine.Start();


// Create a bike Factory
IVehicleFactory bikeFactory = new BikeFactory();

IVehicle bike = bikeFactory.CreateVehicle();
IEngine bikeEngine = bikeFactory.CreateEngine();

bike.Drive();
bikeEngine.Start();