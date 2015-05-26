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
                new Rook(S.Black, new P('A', 8)),
                new Rook(S.Black, new P('H', 8)),
                new Rook(S.White, new P('A', 1)),
                new Rook(S.White, new P('H', 1)),

                new Knight(S.Black, new P('B', 8)),
                new Knight(S.Black, new P('G', 8)),
                new Knight(S.White, new P('B', 1)),
                new Knight(S.White, new P('G', 1)),

                new Bishop(S.Black, new P('C', 8)),
                new Bishop(S.Black, new P('F', 8)),
                new Bishop(S.White, new P('C', 1)),
                new Bishop(S.White, new P('F', 1)),

                new Queen(S.Black, new P('D', 8)),
                new Queen(S.White, new P('D', 1)),

                new King(S.Black, new P('E', 8)),
                new King(S.White, new P('E', 1))
            };
            for (int i = 1; i <= 8; i++ )
            {
                pieces.Add(new Pawn(S.Black, new P(i, 2)));
                pieces.Add(new Pawn(S.White, new P(i, 7)));
            }

            // Put all pieces on the board
            _pieces.AddRange(pieces);
        }
    }
}
