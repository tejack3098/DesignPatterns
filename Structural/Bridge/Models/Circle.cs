
using Bridge.Interfaces;

namespace Bridge.Models;

public class Circle: Shape
{
    public Circle(IColor color): base(color){}

    public override void Draw()
    {
        Console.WriteLine($"Drawing a Circle filled with {_color.FillColor()} color.");
    }

}