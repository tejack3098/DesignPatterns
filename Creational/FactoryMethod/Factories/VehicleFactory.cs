

using FactoryMethod.Interfaces;

namespace FactoryMethod.Factories;

public abstract class VehicleFactory
{
    public abstract IVehicle CreateVehicle();
}
