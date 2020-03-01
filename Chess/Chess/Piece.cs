using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public abstract class Piece
    {
        private int row;
        private char column;
        private string color;
        private bool isAlive;

        public Piece(int row, char column, string color)
        {
            Row = row;
            Column = column;
            Color = color;
            isAlive = true;
        }

        public int Row
        {
            get { return row; }
            set
            {
                if (value > 8 && value < 1)
                {
                    throw new ArgumentOutOfRangeException("Row should be between 1 and 8!");
                }
                row = value;
            }
        }
        public char Column
        {
            get { return column; }
            set
            {
                if (value < 'a' && value > 'h')
                {
                    throw new ArgumentOutOfRangeException("Column should be between A and H!");
                }
                column = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                if (value != "white" && value != "black")
                {
                    throw new ArgumentOutOfRangeException("Color should be black or white!");
                }
                color = value;
            }
        }


        public abstract string Moove();

        public void TakeAttack()
        {
            isAlive = false;
        }


    }
}
