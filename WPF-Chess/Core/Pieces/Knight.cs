﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Chess.Common;

namespace WPF_Chess.Core
{
    internal sealed class Knight : Piece
    {
        public Knight(Side side, Position position) : base(side, position) { }

        protected override List<Common.Position> RefreshPossibleMoves()
        {
            throw new NotImplementedException();
        }

        protected override string TypeName()
        {
            return "KNIGHT";
        }
    }
}