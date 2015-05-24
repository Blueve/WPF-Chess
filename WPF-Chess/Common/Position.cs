using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chess.Common
{
    public sealed struct Position : IEqualityComparer<Position>
    {
        private Int16 _x;
        private Int16 _y;

        public Int16 X
        {
            get { return _x; }
            set { _x = (value > 8 || value < 1) ? 0 : value; }
        }

        public Int16 Y
        {
            get { return _y; }
            set { _y = (value > 8 || value < 1) ? 0 : value; }
        }

        public bool Equals(Position a, Position b)
        {
            return (a._x == b._x && a._y == b._y);
        }
    }
}
