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

        public override bool CheckIfNextMooveIsLegal(int row, int column)
        {
            int rowDifference = Row - row;
            int columnDifference = Column - column;
            //TODO Check if the possition is occupied
            //TODO Check if the possition is occupied by a piece of the same color
            if (rowDifference == 1 || rowDifference == 0 || rowDifference == -1 || 
                columnDifference == 1 || columnDifference == 0 || columnDifference == -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
