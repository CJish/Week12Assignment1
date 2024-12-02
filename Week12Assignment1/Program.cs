


/*
 * CSC180 Week12 Assignment #1
 * key concepts: abstract class/method; inheritance; constructor; array of objects
 * Tester: Program.cs
 */
using System;
public class Program
{
    public static void Main()
    {
        Shape[] shapes = { new Square(10), new Circle(10), new Triangle(5,3), new Rectangle(10,4) }; // creates an array of Shapes with 2 objects inside of it: a square with sides of 10 and a circle with radius of 10
        foreach (var shape in shapes) // goes through each shape in the shapes[] array
        {
            Console.WriteLine($"Area of {shape}: {shape.Area()}"); // outputs the area of the shape from 56
            Console.WriteLine($"Area of {shape}: {Shape.GetArea(shape)}, again"); // uses the getter to print out the area of the shape (again)
        }
    }
}


