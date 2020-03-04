using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Pieces
{
    public class Queen : Piece
    {
        public Queen(int row, int column, string color) : base(row, column, color) {}

        public override string Moove()
        {
            return null;
        }
    }
}
