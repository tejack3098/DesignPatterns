
namespace Builder.Models;

public class Computer
{
    public string CPU { get; set; }
    public string GPU { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; } 
    public bool HasCoolingSystem { get; set; }

    public void ShowConfiguration()
    {
        Console.WriteLine($"CPU: {CPU}, GPU: {GPU}, RAM: {RAM}GB, Storage: {Storage}GB, Has Cooling System: {HasCoolingSystem}");
    }
    
}