using System;
internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = CircleArea(radius);
        Console.WriteLine($"The area of the circle with radius {radius} is {area}");
    }

    private static double CircleArea(double radius)
    {
        return Math.Pow(radius, 2) * Math.PI;
    }
}
