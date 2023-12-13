using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Прохоренко Олександр";
            Console.Write("Введіть довжину першої сторони: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Введіть довжину другої сторони: ");
            double side2 = double.Parse(Console.ReadLine());

            
            Rectangle myRectangle = new Rectangle(side1, side2);

            
            Console.WriteLine($"Периметр прямокутника: {myRectangle.Perimeter}");
            Console.WriteLine($"Площа прямокутника: {myRectangle.Area}");

            Console.ReadLine(); 
        }
    }
}
