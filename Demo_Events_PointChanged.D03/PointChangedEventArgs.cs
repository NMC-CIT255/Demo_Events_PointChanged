using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Events_PointChanged
{
    public class PointChangedEventArgs : EventArgs
    {
        public double OriginalPointX { get; set; }
        public double OriginalPointY { get; set; }
        public double NewPointX { get; set; }
        public double NewPointY { get; set; }
    }
}
