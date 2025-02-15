
using Prototype.Models;

//Creating a circle
Circle orginalCircle = new Circle(10, "Red");
Circle clonedCircle = orginalCircle.Clone();

//Modifying the cloned circle
clonedCircle.Color = "Green";

Console.WriteLine("Original circle:");
orginalCircle.ShowDetails();

Console.WriteLine("Cloned circle (Modified):");
clonedCircle.ShowDetails();

//Creating a rectangle
Rectangle orginalRectangle = new Rectangle(5, 10, "Blue");
Rectangle clonedRectangle = orginalRectangle.Clone();

Console.WriteLine("Original rectangle:");
orginalRectangle.ShowDetails();

Console.WriteLine("Cloned rectangle (Unmodified):");
clonedRectangle.ShowDetails();