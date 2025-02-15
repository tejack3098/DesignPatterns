
using Builder.Models;

namespace Builder.Builders;

public interface IComputerBuilder
{
    IComputerBuilder SetCPU(string cpu);
    IComputerBuilder SetGPU(string gpu);
    IComputerBuilder SetRAM(int ram);
    IComputerBuilder SetStorage(int storage);
    IComputerBuilder EnableCoolingSystem();
    Computer Build();
}