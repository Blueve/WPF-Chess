using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chess.Common
{
    public struct Position
    {
        private int _x;
        private int _y;

        public Position(int x, int y)
        {
            _x = _y = 0;
            X = x;
            Y = y;
        }

        public Position(char x, int y)
        {
            _x = _y = 0;
            X = (int)(x - 'A');
            Y = 8 - y;
        }

        public int X
        {
            get { return _x; }
            set { _x = (value > 7 || value < 0) ? -1 : value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = (value > 7 || value < 0) ? -1 : value; }
        }

        public bool Equals(Position othr)
        {
            return (_x == othr._x && _y == othr._y);
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", (char)(_x + 'A'), 8 - _y);
        }


        public override int GetHashCode()
        {
            return _x * 10 + _y;
        }
    }
}
