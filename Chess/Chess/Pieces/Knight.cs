﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Pieces
{
    public class Knight : Piece
    {
        public Knight(int row, int column, string color) : base(row, column, color)
        {
        }

        public override string Moove()
        {
            throw new NotImplementedException();
        }
    }
}
