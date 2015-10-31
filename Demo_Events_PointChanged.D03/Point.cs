using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Events_PointChanged
{
    public class Point
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }
            set
            {
                double originalX = _x;

                _x = value;
                OnPointChanged(originalX, _y, value, _y);
            }
        }

        public double Y
        {
            get { return _y; }
            set
            {
                double originalY = _y;

                _y = value;
                OnPointChanged(_x, originalY, _x, value);
            }
        }

        public Point()
        {
            _x = 0;
            _y = 0;
        }

        public event EventHandler<PointChangedEventArgs> PointChanged;

        public void OnPointChanged(double originalPointX, double originalPointY, double newPointX, double newPointY)
        {
            if (PointChanged != null)
            {
                PointChangedEventArgs eventArgs = new PointChangedEventArgs();
                eventArgs.OriginalPointX = originalPointX;
                eventArgs.OriginalPointY = originalPointY;
                eventArgs.NewPointX = newPointX;
                eventArgs.NewPointY = newPointY;

                PointChanged(this, eventArgs);
            }
        }
    }
}
