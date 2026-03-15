using System.Security.Cryptography;

namespace RoundShapes;

class Program
{
    static void Main(string[] args)
    {
        Circle steve = new Circle();
        steve.SetRadius(2.0);

        Cylinder mike = new Cylinder();
        mike.SetRadius(10.0);
        mike.SetHeight(2.0);

        Sphere sully = new Sphere();
        sully.SetRadius(500);

        Console.WriteLine($"Area of steve: {steve.Area()}");
        Console.WriteLine($"Area of mike: {mike.Area()}");
        Console.WriteLine($"Area of sully: {sully.Area()}");
    }
}