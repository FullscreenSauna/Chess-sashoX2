using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.GameInitialization
{
    public class Cell
    {
        public Cell(int rowNum, int columnNum)
        {
            RowNum = rowNum;
            ColumnNum = columnNum;
        }

        public int RowNum{ get; private set; }
        public int ColumnNum{ get; private set; }

        public bool IsOccupied { get; private set; }
    }
}
