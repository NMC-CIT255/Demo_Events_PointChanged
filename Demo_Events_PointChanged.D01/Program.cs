using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Events_PointChanged.D01
{
    public delegate void EventHandler();
    class Program
    {
        public static event EventHandler _printInfo;
        static void Main(string[] args)
        {
            _printInfo += new EventHandler(Name);
            _printInfo += new EventHandler(Address);
            _printInfo += new EventHandler(City);
            _printInfo += new EventHandler(State);

            _printInfo.Invoke();

            Console.ReadKey();
        }

        static void Name()
        {
            Console.WriteLine("John Velis");
        }

        static void Address()
        {
            Console.WriteLine("6625 Echo Valley Road");
        }

        static void City()
        {
            Console.WriteLine("Empire");
        }

        static void State()
        {
            Console.WriteLine("MI");
        }
    }
}
