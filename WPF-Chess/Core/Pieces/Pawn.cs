using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Chess.Common;

namespace WPF_Chess.Core
{
    internal sealed class Pawn : Piece
    {
        private bool _move = false;

        public Pawn(Side side, Position position, IReadOnlyList<Piece> pieces) 
            : base(side, position, pieces) { }

        protected override List<Position> RefreshPossibleMoves()
        {
            var result = new List<Position>();
            if(_move)
            {
                result.Add(new Position(_position.X, _position.Y + 1 * (_side == Side.White ? 1 : -1)));
            }
            else
            {
                _move = true;
                result.Add(new Position(_position.X, _position.Y + 1 * (_side == Side.White ? 1 : -1)));
                result.Add(new Position(_position.X, _position.Y + 2 * (_side == Side.White ? 1 : -1)));
            }
            throw new NotImplementedException();
        }

        protected override string TypeName()
        {
            return "PAWN";
        }
    }
}
