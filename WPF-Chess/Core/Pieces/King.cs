using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using WPF_Chess.Common;

namespace WPF_Chess.Core
{
    internal sealed class King : Piece
    {

        public King(Side side, Position position, IReadOnlyList<Piece> pieces) : base(side, position, pieces) { }

        protected override List<Common.Position> RefreshPossibleMoves()
        {
            throw new NotImplementedException();
        }

        protected override string TypeName()
        {
            return "KING";
        }
    }
}
