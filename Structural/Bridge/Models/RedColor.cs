
using Bridge.Interfaces;

namespace Bridge.Models;

public class RedColor : IColor
{
    public string FillColor()
    {
        return "Red";
    }
}
