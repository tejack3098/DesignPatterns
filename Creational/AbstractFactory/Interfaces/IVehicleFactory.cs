
namespace AbstractFactory.Interfaces;

public interface IVehicleFactory
{
    IVehicle CreateVehicle();
    IEngine CreateEngine();
}