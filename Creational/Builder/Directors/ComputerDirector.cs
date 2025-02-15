
using Builder.Builders;
using Builder.Models;

namespace Builder.Directors;

public class ComputerDirector
{
    public Computer BuildGamingPC(IComputerBuilder builder)
    {
        return builder.SetCPU("Intel Core i7")
                    .SetGPU("RTX 3090")
                    .SetRAM(16)
                    .SetStorage(1024)
                    .EnableCoolingSystem()
                    .Build();
    }

    public Computer BuildOfficePC(IComputerBuilder builder)
    {
        return builder.SetCPU("Intel Core i5")
                    .SetGPU("RTX 3060")
                    .SetRAM(8)
                    .SetStorage(512)
                    .Build();
    }
}