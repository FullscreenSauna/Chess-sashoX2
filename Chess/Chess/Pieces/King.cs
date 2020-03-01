using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class King : Piece
    {
        bool hasMooved;

        public King(int row, int column, string color) : base(row, column, color)
        {
            hasMooved = false;
        }

        public override string Moove()
        {
        return null;
        }
        //public override string Moove(int row, char column)
        //{
        //    if (this.Row+1 == row ||  )
        //    {

        //    }
        //}
    }
}
