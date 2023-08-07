using System;

// Define the interface
interface IShape
{
    void Draw();
    double CalculateArea();
}

// Implement the interface in a class
class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : IShape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }

    public double CalculateArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main()
    {
        // Create objects of Circle and Rectangle classes
        IShape circle = new Circle(5.0);
        IShape rectangle = new Rectangle(4.0, 3.0);

        // Call the methods defined in the interface
        circle.Draw();
        Console.WriteLine("Area of the circle: " + circle.CalculateArea());

        rectangle.Draw();
        Console.WriteLine("Area of the rectangle: " + rectangle.CalculateArea());
    }
}
