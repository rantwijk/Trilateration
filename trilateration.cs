using System;

public class Trilateration
{
    public double x, y;

    public Trilateration calculateLocation(double x1, double y1, double r1, double x2, double y2, double r2, double x3, double y3, double r3)
    {
        double A = 2 * x2 - 2 * x1;
        double B = 2 * y2 - 2 * y1;
        double C = Math.Pow(r1, 2) - Math.Pow(r2, 2) - Math.Pow(x1, 2) + Math.Pow(x2, 2) - Math.Pow(y1, 2) + Math.Pow(y2, 2);
        double D = 2 * x3 - 2 * x2;
        double E = 2 * y3 - 2 * y2;
        double F = Math.Pow(r2, 2) - Math.Pow(r3, 2) - Math.Pow(x2, 2) + Math.Pow(x3, 2) - Math.Pow(y2, 2) + Math.Pow(y3, 2);

        double x = (C * E - F * B) / (E * A - B * D);
        double y = (C * D - A * F) / (B * D - A * E);

        this.x = x;
        this.y = y;
        return this;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Trilateration tri = new Trilateration();
        tri.calculateLocation(-84, 44, 92.1791733528, 98, 64, 171.011695506, 116, -108, 171.39719951);
        Console.WriteLine("X: {0} Y: {1}", tri.x, tri.y);
    }
}