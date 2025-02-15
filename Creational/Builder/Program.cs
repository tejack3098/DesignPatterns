
using Builder.Builders;
using Builder.Directors;
using Builder.Models;

IComputerBuilder builder = new ComputerBuilder();
ComputerDirector director = new ComputerDirector();

//Build a custom PC
Computer customPC = builder.SetCPU("Intel Core i7")
    .SetGPU("RTX 3090")
    .SetRAM(16)
    .SetStorage(1024)
    .Build();

Console.WriteLine("Custom PC Configuration:");
customPC.ShowConfiguration();

//Build a gaming PC
Computer gamingPC = director.BuildGamingPC(new ComputerBuilder());
Console.WriteLine("Gaming PC Configuration:");
gamingPC.ShowConfiguration();

//Build an office PC
Computer officePC = director.BuildOfficePC(new ComputerBuilder());
Console.WriteLine("Office PC Configuration:");
officePC.ShowConfiguration();