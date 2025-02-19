
using Bridge.Interfaces;

namespace Bridge.Models;

public class Rectangle : Shape
{
    public Rectangle(IColor color): base(color){}

    public override void Draw()
    {
        Console.WriteLine($"Drawing a rectangle filled with {_color.FillColor()} color.");
    }
}
