using System;
using Task2;

class Figure
{
    private Point[] points;

    
    public Figure(Point point1, Point point2, Point point3, Point point4 = null, Point point5 = null)
    {
        points = new Point[] { point1, point2, point3, point4, point5 };
    }

    
    private double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    
    public void CalculatePerimeter()
    {
        if (points == null)
        {
            Console.WriteLine("Invalid number of points provided.");
            return;
        }

        double perimeter = 0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            if (points[i] != null && points[i + 1] != null)
            {
                perimeter += GetSideLength(points[i], points[i + 1]);
            }
        }

        
        if (points[points.Length - 1] != null && points[0] != null)
        {
            perimeter += GetSideLength(points[points.Length - 1], points[0]);
        }

        Console.WriteLine($"Назва багатокутника: {points.Length}-кут");
        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

