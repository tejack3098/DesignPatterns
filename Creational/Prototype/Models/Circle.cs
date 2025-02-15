
using Prototype.Interfaces;

namespace Prototype.Models;

public class Circle : IPrototype<Circle>
{
    public int Radius { get; set; }
    public string Color { get; set; }

    public Circle(int radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    //Cloning method
    public Circle Clone()
    {
        return new Circle(this.Radius, this.Color);
    }

    //Show method
    public void ShowDetails()
    {
        Console.WriteLine($"Circle - Radius: {Radius}, Color: {Color}");
    }
}