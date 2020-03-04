using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class King : Piece
    {
        private bool hasMooved;

        public King(int row, int column, string color) : base(row, column, color)
        {
            HasMooved = false;
        }

        public bool HasMooved { get; private set; }

        public override string Moove()
        {
            throw new NotImplementedException();
        }
    }
}
