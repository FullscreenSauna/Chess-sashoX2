using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(int row, int column, string color) : base(row, column, color)
        {
        }

        public override bool CheckIfNextMooveIsLegal(int row, int column)
        {
            throw new NotImplementedException();
        }
    }
}
