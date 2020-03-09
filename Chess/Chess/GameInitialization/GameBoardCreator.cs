using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.GameInitialization
{
	public class GameBoardCreator
	{
		// ChessBoard is a matrix
		public Position[,] Board { get; private set; }
		
		public void CreateBoard()
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					Board[i, j] = new Position(i, j);
				}
			}
		}
	}
}
