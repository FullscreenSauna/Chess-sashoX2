using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Pieces
{
    public class Pawn : Piece
    {
        private bool hasMoved;

        public Pawn(int row, int column, string color) : base(row, column, color)
        {
            HasMoved = false;
        }

        public bool HasMoved { get; private set; }

        public override bool CheckIfNextMooveIsLegal(int row, int column)
        {
            throw new NotImplementedException();
            //row++
            //TODO Check if the diagonal possition is occupied
        }
    }
}
