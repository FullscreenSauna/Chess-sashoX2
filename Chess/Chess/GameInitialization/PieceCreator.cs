using Chess.Pieces;
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
            PlaceQueens();
            PlaceBishops();
            PlaceKnights();
            PlaceRooks();
        }

        private void PlaceKings()
        {
            King whiteKing = new King(7, 4, "white");
            King blackKing = new King(0, 4, "black");
        }

        private void PlaceQueens()
        {
            Queen whiteQueen = new Queen(7, 3, "wjite");
            Queen blackQueen = new Queen(0, 3, "wjite");
        }

        private void PlaceBishops()
        {
            // Placing the white Bishop that starts on Black
            Bishop whiteBishopBlack = new Bishop(7, 2, "white");
            // Placing the white Bishop that starts on White
            Bishop whiteBishopWhite = new Bishop(7, 5, "white");

            // Placing the black Bishop that starts on Black
            Bishop blackBishopBlack = new Bishop(0, 5, "black");
            // Placing the blac Bishop that starts on White
            Bishop blackBishopWhite = new Bishop(0, 2, "black");
        }

        private void PlaceKnights()
        {
            // Placing the white Knight that starts on Black
            Knight whiteKnightBlack = new Knight(7, 6, "white");
            // Placing the white Knight that starts on White
            Knight whiteKnightWhite = new Knight(7, 1, "white");

            // Placing the black Knight that starts on Black
            Knight blackKnightBlack = new Knight(0, 1, "black");
            // Placing the black Knight that starts on White
            Knight blackKnightWhite = new Knight(0, 6, "black");
        }

        private void PlaceRooks()
        {
            // Placing the white Rook that starts on Black
            Rook whiteRookBlack = new Rook(7, 0, "white");
            // Placing the white Rook that starts on White
            Rook whiteRookWhite = new Rook(7, 7, "white");

            // Placing the black Rook that starts on Black
            Rook blackRookBlack = new Rook(0, 7, "black");
            // Placing the black Rook that starts on White
            Rook blackRookWhite = new Rook(0, 0, "black");
        }

        private void PlacePawns()
        {
            // Place white Pawns
            for (int i = 0; i < 7; i++)
            {
                Pawn whitePawn = new Pawn(6, i, "white");
            }

            // Place black Pawns
            for (int i = 0; i < 7; i++)
            {
                Pawn blackPawn = new Pawn(1, i, "black");
            }
        }
    }
}
