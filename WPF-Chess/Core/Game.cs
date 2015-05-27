using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chess.Core
{
    using Side = Piece.Side;

    public sealed class Game
    {
        private Player _playerOne;
        private Player _playerTwo;

        private Chessboard _board;

        /// <summary>
        /// Who need to move now.
        /// </summary>
        private Player _current;

        public IReadOnlyList<Piece> Pieces
        {
            get { return _board.Pieces; }
        }

        /// <summary>
        /// Start a new game with two players
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        public void Start(Player p1, Player p2)
        {
            _playerOne = p1;
            _playerTwo = p2;

            _board = new Chessboard();
            _board.Init();

            // Make the player who play with white piece go first
            _current = _playerOne.Side == Side.White ? _playerOne : _playerTwo;
        }
    }
}
