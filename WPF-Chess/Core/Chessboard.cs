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
        private readonly List<Piece> _pieces = new List<Piece>();

        public IReadOnlyList<Piece> Pieces
        {
            get { return _pieces; }
        }

        /// <summary>
        /// Initialize the chess board
        /// </summary>
        public void Init()
        {
            // Clear current board
            _pieces.Clear();

            // Create all pieces
            List<Piece> pieces = new List<Piece>()
            {
                new Rook(S.Black, new P('A', 8), Pieces),
                new Rook(S.Black, new P('H', 8), Pieces),
                new Rook(S.White, new P('A', 1), Pieces),
                new Rook(S.White, new P('H', 1), Pieces),

                new Knight(S.Black, new P('B', 8), Pieces),
                new Knight(S.Black, new P('G', 8), Pieces),
                new Knight(S.White, new P('B', 1), Pieces),
                new Knight(S.White, new P('G', 1), Pieces),

                new Bishop(S.Black, new P('C', 8), Pieces),
                new Bishop(S.Black, new P('F', 8), Pieces),
                new Bishop(S.White, new P('C', 1), Pieces),
                new Bishop(S.White, new P('F', 1), Pieces),

                new Queen(S.Black, new P('D', 8), Pieces),
                new Queen(S.White, new P('D', 1), Pieces),

                new King(S.Black, new P('E', 8), Pieces),
                new King(S.White, new P('E', 1), Pieces)
            };
            for (int i = 0; i < 8; i++ )
            {
                pieces.Add(new Pawn(S.Black, new P(i, 1), Pieces));
                pieces.Add(new Pawn(S.White, new P(i, 6), Pieces));
            }

            // Put all pieces on the board
            _pieces.AddRange(pieces);
        }
    }
}
