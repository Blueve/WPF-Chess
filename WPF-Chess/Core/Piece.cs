using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WPF_Chess.Common;

namespace WPF_Chess.Core
{
    abstract class Piece
    {
        public enum Side
        {
            Black,
            White
        }
        
        protected Side _side;

        protected Position _position;
        protected List<Position> _possibleMoves;

        public Piece(Side side, Position position)
        {
            _side = Side;
            _position = position;
        }

        public Position Position
        {
            get { return _position}
        }

        /// <summary>
        /// A cacheable property which contains all possible moves.
        /// If the value of '_possibleMoves' is 'null', the getter will update it
        /// by invoke virtual method 'PossibleMoves()'.
        /// </summary>
        public List<Position> PossibleMoves
        {
            get
            {
                return _possibleMoves ?? PossibleMoves();
            }
        }

        /// <summary>
        /// Move current piece to target place.
        /// '_possibleMoves' will be set to 'null' after the position changed.
        /// </summary>
        /// <param name="position"></param>
        public void MoveTo(Position position)
        {
            if(PossibleMoves.Contains(position))
            {
                _position = position;
                _possibleMoves = null;
            }
            //TODO: should be throw an exception here.
        }

        /// <summary>
        /// Return all possible moves of current piece.
        /// </summary>
        /// <returns></returns>
        protected abstract List<Position> RefreshPossibleMoves();
    }
}
