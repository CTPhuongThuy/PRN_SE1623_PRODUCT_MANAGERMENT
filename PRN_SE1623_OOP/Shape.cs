using System;

public abstract class Shape
{
    protected string Color { get; set; }

    public Shape()
    {
        
    }
    public Shape(string color)
    {
        Color = color;
    }
    //virtual method
    public virtual void display()
    {
        Console.WriteLine("vritual");
    }
    //abstract method
    public abstract double GetArea();
    public abstract double Peremetter();
}