

using OpenClosed.Filters;
using OpenClosed.Models;
using Color = OpenClosed.Models.Color;

public class Program
{
    private static void Main(string[] args)
    {
        var apple = new Product("Apple", Color.Green, Size.Small);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Large);

        Product[] products = new Product[] { apple, tree, house };

        var pf = new ProductFilter();
        Console.WriteLine("Green Products (old):");

        foreach (var p in pf.FilterByColor(products, Color.Green))
            Console.WriteLine($" - {p.Name} is green");

        // ----------------------------- ^^ Before ^^ ----------------------------------------------------

        // -----------------------------  vv After vv ----------------------------------------------------

        var bf = new BetterFilter();

        Console.WriteLine("Green Products (new):");
        foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            Console.WriteLine($" - {p.Name} is green");

        Console.WriteLine("Large Products:");
        foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
            Console.WriteLine($" - {p.Name} is large");

        Console.WriteLine("Large Blue Items");
        foreach (var p in bf.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
        {
            Console.WriteLine($" - {p.Name} is big and blue");
        }

    }
}