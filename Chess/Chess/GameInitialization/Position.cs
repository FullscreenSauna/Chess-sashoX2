using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.GameInitialization
{
    public class Position
    {
        bool isOccupied;
        public Position(int rowNum, int columnNum)
        {
            RowNum = rowNum;
            ColumnNum = columnNum;
            isOccupied = false;
        }

        public int RowNum{ get; private set; }
        public int ColumnNum{ get; private set; }
        public bool IsOccupied { get=> isOccupied; set => value= isOccupied; }
    }
}
