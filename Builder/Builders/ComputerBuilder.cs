
using Builder.Models;

namespace Builder.Builders;

public class ComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public IComputerBuilder SetCPU(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public IComputerBuilder SetGPU(string gpu)
    {
        _computer.GPU = gpu;
        return this;
    }

    public IComputerBuilder SetRAM(int ram)
    {
        _computer.RAM = ram;
        return this;
    }

    public IComputerBuilder SetStorage(int storage)
    {
        _computer.Storage = storage;
        return this;
    }


    public IComputerBuilder EnableCoolingSystem()
    {
        _computer.HasCoolingSystem = true;
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }
}