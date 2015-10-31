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
            x = double.Parse(Console.ReadLine());
            Console.Write("Enter the new Y coordinate: ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine();

            pointA.X = x;
            pointA.Y = y;

            Console.WriteLine("\nThe new coordinates are: ({0}, {1})", pointA.X, pointA.Y);

            Console.ReadKey();
        }

        public static void HandlePointChanged(object point, PointChangedEventArgs eventArgs)
        {
            if (eventArgs.OriginalPointX != eventArgs.NewPointX)
            {
                Console.WriteLine("The X coordinate was changed from {0} to {1}\n", eventArgs.OriginalPointX, eventArgs.NewPointX);
            }
            else
            {
                Console.WriteLine("The Y coordinate was changed from {0} to {1}\n", eventArgs.OriginalPointY, eventArgs.NewPointY);
            }
        }
    }
}
