using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Chess.Common;

namespace WPF_Chess.Core
{
    using S = Piece.Side;
    using P = Position;

    public sealed class Chessboard
    {
        /// <summary>
        /// Storage all pieces
        /// </summary>
        private readonly List<Piece> _board = new List<Piece>();

        public IEnumerable<Piece> Board
        {
            get { return _board; }
        }

        /// <summary>
        /// Initialize the chess board
        /// </summary>
        public void Init()
        {
            // Clear current board
            _board.Clear();

            // Create all pieces
            List<Piece> pieces = new List<Piece>()
            {
                new Rook(S.Black, new P(1, 1)),
                new Rook(S.Black, new P(1, 8)),
                new Rook(S.White, new P(8, 1)),
                new Rook(S.White, new P(8, 8)),

                new Knight(S.Black, new P(1, 2)),
                new Knight(S.Black, new P(1, 7)),
                new Knight(S.White, new P(8, 2)),
                new Knight(S.White, new P(8, 7)),

                new Bishop(S.Black, new P(1, 3)),
                new Bishop(S.Black, new P(1, 6)),
                new Bishop(S.White, new P(8, 3)),
                new Bishop(S.White, new P(8, 6)),

                new Queen(S.Black, new P(1, 4)),
                new Queen(S.White, new P(8, 4)),

                new King(S.Black, new P(1, 5)),
                new King(S.White, new P(8, 5))
            };
            for (int i = 1; i <= 8; i++ )
            {
                pieces.Add(new Pawn(S.Black, new P(2, i)));
                pieces.Add(new Pawn(S.White, new P(7, i)));
            }

            // Put all pieces on the board
            _board.AddRange(pieces);
        }
    }
}
