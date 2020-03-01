using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.GameInitialization
{
	public class GameBoardCreator
	{
		// ChessBoard is a matrix
		public Cell[,] Board { get; private set; }
		
		public void CreateBoard()
		{
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 7; j++)
				{
					Board[i, j] = new Cell(i, j);
				}
			}
		}
	}
}
