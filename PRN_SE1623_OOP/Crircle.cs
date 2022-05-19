using System;

public class Crircle:Shape
{
    private int Radius { get; set; }
    public Crircle()
    {

    }
    public Crircle(int radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.Pow(Radius,2)*Math.PI;
    }

    public override double Peremetter()
    {
       return 2* Math.Pow(Radius, 2) * Math.PI;
    }

    public override void display()
    {
        Console.WriteLine("console da duoc thay doi");
    }
}