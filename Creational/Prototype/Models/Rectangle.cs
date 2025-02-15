
using Prototype.Interfaces;

namespace Prototype.Models;

public class Rectangle : IPrototype<Rectangle>
{
    public int Width { get; set; }
    public int Height { get; set; }
    public string Color { get; set; }

    public Rectangle(int width, int height, string color)
    {
        Width = width;
        Height = height;
        Color = color;
    }

    //Cloning method
    public Rectangle Clone()
    {
        return new Rectangle(this.Width, this.Height, this.Color);
    }

    //Show method
    public void ShowDetails()
    {
        Console.WriteLine($"Rectangle - Width: {Width}, Height: {Height}, Color: {Color}");
    }
}