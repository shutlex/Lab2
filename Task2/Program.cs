using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Прохоренко Олександр";
            Point point1 = new Point(0, 0, "A");
            Point point2 = new Point(4, 0, "B");
            Point point3 = new Point(4, 3, "C");

            
            Figure myFigure = new Figure(point1, point2, point3);

            
            myFigure.CalculatePerimeter();

            Console.ReadLine(); 
        }
    }
    }

