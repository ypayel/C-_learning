//Zadanie 1 
using System;
using System.Collections.Generic;

abstract class Solid
{
    public abstract double GetVolume();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Bryła: {this.GetType().Name}, Objętość: {GetVolume():F2}");
    }
}

class Cube : Solid
{
    private double side;

    public Cube(double side)
    {
        this.side = side;
    }

    public override double GetVolume()
    {
        return Math.Pow(side, 3);
    }
}

class Sphere : Solid
{
    private double radius;

    public Sphere(double radius)
    {
        this.radius = radius;
    }

    public override double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }
}

class Cylinder : Solid
{
    private double radius;
    private double height;

    public Cylinder(double radius, double height)
    {
        this.radius = radius;
        this.height = height;
    }

    public override double GetVolume()
    {
        return Math.PI * Math.Pow(radius, 2) * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Solid> solids = new List<Solid>
        {
            new Cube(3),
            new Sphere(2),
            new Cylinder(2, 5)
        };

        foreach (Solid solid in solids)
        {
            solid.DisplayInfo();
        }
    }
}

