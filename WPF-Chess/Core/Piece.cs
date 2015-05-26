using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using WPF_Chess.Common;

namespace WPF_Chess.Core
{
    public abstract class Piece
    {
        #region Static Resources
        protected static IReadOnlyDictionary<string, BitmapImage> _IMAGES = 
            new Dictionary<string, BitmapImage>()
            {
                {"KING_B", new BitmapImage(new Uri("Asset/Images/King_B.png", UriKind.Relative))},
                {"KING_W", new BitmapImage(new Uri("Asset/Images/King_W.png", UriKind.Relative))},
                {"QUEEN_B", new BitmapImage(new Uri("Asset/Images/Queen_B.png", UriKind.Relative))},
                {"QUEEN_W", new BitmapImage(new Uri("Asset/Images/Queen_W.png", UriKind.Relative))},
                {"KNIGHT_B", new BitmapImage(new Uri("Asset/Images/Knight_B.png", UriKind.Relative))},
                {"KNIGHT_W", new BitmapImage(new Uri("Asset/Images/Knight_W.png", UriKind.Relative))},
                {"BISHOP_B", new BitmapImage(new Uri("Asset/Images/Bishop_B.png", UriKind.Relative))},
                {"BISHOP_W", new BitmapImage(new Uri("Asset/Images/Bishop_W.png", UriKind.Relative))},
                {"ROOK_B", new BitmapImage(new Uri("Asset/Images/Rook_B.png", UriKind.Relative))},
                {"ROOK_W", new BitmapImage(new Uri("Asset/Images/Rook_W.png", UriKind.Relative))},
                {"PAWN_B", new BitmapImage(new Uri("Asset/Images/Pawn_B.png", UriKind.Relative))},
                {"PAWN_W", new BitmapImage(new Uri("Asset/Images/Pawn_W.png", UriKind.Relative))}
            };
        //protected static BitmapImage _KING_B = new BitmapImage(new Uri("Asset/Images/King_B.png", UriKind.Relative));
        //protected static BitmapImage _KING_W = new BitmapImage(new Uri("Asset/Images/King_W.png", UriKind.Relative));

        //protected static BitmapImage _QUEEN_B = new BitmapImage(new Uri("Asset/Images/Queen_B.png", UriKind.Relative));
        //protected static BitmapImage _QUEEN_W = new BitmapImage(new Uri("Asset/Images/Queen_W.png", UriKind.Relative));

        //protected static BitmapImage _KNIGHT_B = new BitmapImage(new Uri("Asset/Images/Knight_B.png", UriKind.Relative));
        //protected static BitmapImage _KNIGHT_W = new BitmapImage(new Uri("Asset/Images/Knight_W.png", UriKind.Relative));

        //protected static BitmapImage _BISHOP_B = new BitmapImage(new Uri("Asset/Images/Bishop_B.png", UriKind.Relative));
        //protected static BitmapImage _BISHOP_W = new BitmapImage(new Uri("Asset/Images/Bishop_W.png", UriKind.Relative));

        //protected static BitmapImage _ROOK_B = new BitmapImage(new Uri("Asset/Images/Rook_B.png", UriKind.Relative));
        //protected static BitmapImage _ROOK_W = new BitmapImage(new Uri("Asset/Images/Rook_W.png", UriKind.Relative));

        //protected static BitmapImage _PAWN_B = new BitmapImage(new Uri("Asset/Images/Pawn_B.png", UriKind.Relative));
        //protected static BitmapImage _PAWN_W = new BitmapImage(new Uri("Asset/Images/Pawn_W.png", UriKind.Relative));
        #endregion

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
            _side = side;
            _position = position;
        }

        public Position Position
        {
            get { return _position; }
        }

        public BitmapImage Image
        {
            get
            {
                return _side == Side.Black ? _IMAGES[TypeName() + "_B"] : _IMAGES[TypeName() + "_W"];
            }
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
                return _possibleMoves ?? RefreshPossibleMoves();
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

        /// <summary>
        /// Return actually type of pieces.
        /// </summary>
        /// <returns></returns>
        protected abstract string TypeName();
    }
}
