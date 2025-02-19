
using Bridge.Interfaces;

namespace Bridge.Models;

public class BlueColor : IColor
{
    public string FillColor()
    {
        return "Blue";
    }
}