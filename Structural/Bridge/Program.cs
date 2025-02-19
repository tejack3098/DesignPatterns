
using Bridge.Models;
using Bridge.Interfaces;

// Create a Red Circle
Shape redCircle = new Circle(new RedColor());
redCircle.Draw();

// Create a Blue Rectangle
Shape blueRectangle = new Rectangle(new BlueColor());
blueRectangle.Draw();