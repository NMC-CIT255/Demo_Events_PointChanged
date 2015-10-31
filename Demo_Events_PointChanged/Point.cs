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
                _x = value;
                OnPointChanged();
            }
        }

        public double Y
        {
            get { return _y; }
            set
            {
                _y = value;
                OnPointChanged();
            }
        }

        public event EventHandler PointChanged;

        public void OnPointChanged()
        {
            if (PointChanged != null)
            {
                PointChanged(this, EventArgs.Empty);
            }
        }
    }
}
