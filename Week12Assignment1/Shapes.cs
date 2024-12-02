/*
 * CSC180 Week12 Assignment #1
 * key concepts: abstract class/method; inheritance; constructor; array of objects
 * Shape class: Shape.cs
 */

using System;

public abstract class Shape
{
    public abstract double Area();
    public static double GetArea(Shape shape)
    {
        return shape.Area();
    }
}

public class Square : Shape
{
    private double size;
    public Square(double length)
    {
        this.size = length;
    }
    public override double Area()
    {
        return Math.Pow(size, 2);
    }
}

public class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
    }
}

public class Triangle : Shape
{
    private double triangleBase;
    private double triangleHeight;

    public Triangle(double b, double h)
    {
        this.triangleBase = b;
        this.triangleHeight = h;
    }

    public override double Area()
    {
        return Math.Round((triangleBase * triangleHeight) / 2, 2);
    }
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double Area()
    {
        return Math.Round(length * width, 2);
    }
}