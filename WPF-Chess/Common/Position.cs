using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chess.Common
{
    public struct Position : IEqualityComparer<Position>
    {
        private int _x;
        private int _y;

        public Position(int x, int y)
        {
            _x = _y = 0;
            X = x;
            Y = y;
        }

        public Position(int x, char y)
        {
            _x = _y = 0;
            X = 9 - x;
            Y = (int)(y - 'A' + 1);
        }

        public int X
        {
            get { return _x; }
            set { _x = (value > 8 || value < 1) ? 0 : value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = (value > 8 || value < 1) ? 0 : value; }
        }

        public bool Equals(Position a, Position b)
        {
            return (a._x == b._x && a._y == b._y);
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", 9 - _x, (char)(_y - 1 + 'A'));
        }


        public int GetHashCode(Position obj)
        {
            return obj.GetHashCode();
        }
    }
}
