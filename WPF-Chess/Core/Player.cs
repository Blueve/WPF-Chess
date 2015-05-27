using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chess.Core
{
    using Side = Piece.Side;

    public class Player
    {
        public readonly Side Side;

        public Player(Side side)
        {
            Side = side;
        }
    }
}
