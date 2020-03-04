using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Pieces
{
    public class Rook : Piece
    {
        private bool hasMoved;

        public Rook(int row, int column, string color) : base(row, column, color)
        {
            HasMoved = false;
        }

        public bool HasMoved { get; private set; }

        public override string Moove()
        {
            throw new NotImplementedException();
        }
    }
}
