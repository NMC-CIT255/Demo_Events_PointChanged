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
            Point pointA = new Point();
            
            pointA.PointChanged += HandlePointChanged;

            pointA.X = 3.0;

            Console.ReadKey();                       
        }

        public static void HandlePointChanged(object point, EventArgs e)
        {
            Console.WriteLine("The point changed.");
        }
    }
}
