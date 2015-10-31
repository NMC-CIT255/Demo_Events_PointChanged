using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Events_PointChanged
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Point pointA = new Point();
            
            pointA.PointChanged += HandlePointChanged;

            Console.WriteLine("The current coordinates are: ({0}, {1})\n", pointA.X, pointA.Y);
            Console.Write("Enter the new X coordinate: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter the new Y coordinate: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            pointA.X = x;
            pointA.Y = y;

            Console.WriteLine("\nThe new coordinates are: ({0}, {1})", pointA.X, pointA.Y);

            Console.ReadKey();                       
        }

        public static void HandlePointChanged(object point, EventArgs e)
        {
            Console.WriteLine("The point changed.");
        }
    }
}
