using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.GameInitialization
{
    public class PieceCreator
    {
        public PieceCreator()
        {
            Board.CreateBoard();
        }

        public GameBoardCreator Board { get; private set; }

        public void PlacePieces()
        {
            PlaceKings();
        }

        private void PlaceKings()
        {
            King blackKing = new King(0, 4, "black");
            King whiteKing = new King(7, 4, "white");
        }
    }
}
