using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Board
    {

        public int Size { get; set; }

        public Cell[,] theGrid;

        public Board(int s)
        {
            Size = s;

            theGrid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for(int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void MarkNextLeagleMoves(Cell currentCell, String chessPiece)
        {
            for (int r = 0; r < Size; r++)
            {
                for(int c = 0; c < Size; c++)
                {
                    theGrid[r, c].LeagalNextMove = false;
                    theGrid[r, c].CurrentlyOccupied = false;
                }
            }

            switch (chessPiece)
            {
                case "Knight":
                    theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
                    if (currentCell.RowNumber - 2 >= 0)
                    {
                        if (currentCell.ColumnNumber - 1 >= 0)
                        {
                            theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LeagalNextMove = true;
                        }
                        if (currentCell.ColumnNumber + 1 <= 7)
                        {
                            theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LeagalNextMove = true;
                        }
                    }
                    if (currentCell.RowNumber + 2 <= 7)
                    {
                        if (currentCell.ColumnNumber + 1 <= 7)
                        {
                            theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LeagalNextMove = true;
                        }
                        if (currentCell.ColumnNumber - 1 >= 0)
                        {
                            theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LeagalNextMove = true;
                        }
                    }
                    if (currentCell.RowNumber - 1 >= 0)
                    {
                        if(currentCell.ColumnNumber + 2 <= 7)
                        {
                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LeagalNextMove = true;
                        }
                        if (currentCell.ColumnNumber - 2 >= 0)
                        {
                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LeagalNextMove = true;
                        }
                    }
                    if (currentCell.RowNumber + 1 <= 7)
                    {
                        if (currentCell.ColumnNumber + 2 <= 7)
                        {
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LeagalNextMove = true;
                        }
                        if (currentCell.ColumnNumber - 2 >= 0)
                        {
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LeagalNextMove = true;
                        }
                    }

                    break;

                case "King":
                    theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
                    if (currentCell.RowNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LeagalNextMove = true;

                        if(currentCell.ColumnNumber - 1 >= 0)
                        {
                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LeagalNextMove = true;
                        }
                        if (currentCell.ColumnNumber + 1 <= 7)
                        {
                            theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LeagalNextMove = true;
                        }

                    }
                    if (currentCell.RowNumber + 1 <= 7)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 0].LeagalNextMove = true;

                        if (currentCell.ColumnNumber - 1 >= 0)
                        {
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LeagalNextMove = true;
                        }
                        if (currentCell.ColumnNumber + 1 <= 7)
                        {
                            theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LeagalNextMove = true;
                        }

                    }
                    if (currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 0, currentCell.ColumnNumber - 1].LeagalNextMove = true;
                    }
                    if (currentCell.ColumnNumber + 1 <= 7)
                    {
                        theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 1].LeagalNextMove = true;
                    }
                    break;

                case "Rook":
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
                        int i = 0;
                        int j = 0;
                        int rookRow = currentCell.RowNumber;
                        int rookCol = currentCell.ColumnNumber;
                        while (j <= 7)
                        {
                            theGrid[currentCell.RowNumber = j, currentCell.ColumnNumber = rookCol].LeagalNextMove = true;
                            j++;
                        }

                        while (i <= 7)
                        {
                            theGrid[currentCell.RowNumber = rookRow, currentCell.ColumnNumber = i].LeagalNextMove = true;
                            i++;
                        }

                        break;
                    }
                case "Bishop":
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
                        int BishopRow = currentCell.RowNumber;
                        int BishopCol = currentCell.ColumnNumber;
                        int row = BishopRow+1;
                        int colPos = BishopCol+1;
                        int colNeg = BishopCol-1;

                        while (row <= 7)
                        {
                            if (colPos <= 7)
                            {
                                theGrid[currentCell.RowNumber = row, currentCell.ColumnNumber = colPos].LeagalNextMove = true;
                                colPos++;

                            }
                            if (colNeg >= 0)
                            {
                                theGrid[currentCell.RowNumber = row, currentCell.ColumnNumber = colNeg].LeagalNextMove = true;
                                colNeg--;
                            }
                            row++;
                        }
                        
                        row = BishopRow-1;
                        colPos = BishopCol+1;
                        colNeg = BishopCol-1;
                        while (row >= 0)
                        {
                            if (colPos <= 7)
                            {
                                theGrid[currentCell.RowNumber = row, currentCell.ColumnNumber = colPos].LeagalNextMove = true;
                                colPos++;

                            }
                            if (colNeg >= 0)
                            {
                                theGrid[currentCell.RowNumber = row, currentCell.ColumnNumber = colNeg].LeagalNextMove = true;
                                colNeg--;
                            }
                            row--;
                        }
                        break;
                    }
                case "Queen":
                    {

                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
                        int i = 0;
                        int j = 0;
                        int QueenRow = currentCell.RowNumber;
                        int QueenCol = currentCell.ColumnNumber;
                        while (j <= 7)
                        {
                            theGrid[currentCell.RowNumber = j, currentCell.ColumnNumber = QueenCol].LeagalNextMove = true;
                            j++;
                        }

                        while (i <= 7)
                        {
                            theGrid[currentCell.RowNumber = QueenRow, currentCell.ColumnNumber = i].LeagalNextMove = true;
                            i++;
                        }

                        int row = QueenRow+1;
                        int colPos = QueenCol+1;
                        int colNeg = QueenCol-1;

                        while (row <= 7)
                        {
                            if (colPos <= 7)
                            {
                                theGrid[currentCell.RowNumber = row, currentCell.ColumnNumber = colPos].LeagalNextMove = true;
                                colPos++;

                            }
                            if (colNeg >= 0)
                            {
                                theGrid[currentCell.RowNumber = row, currentCell.ColumnNumber = colNeg].LeagalNextMove = true;
                                colNeg--;
                            }
                            row++;
                        }

                        row = QueenRow-1;
                        colPos = QueenCol+1;
                        colNeg = QueenCol-1;
                        while (row >= 0)
                        {
                            if (colPos <= 7)
                            {
                                theGrid[currentCell.RowNumber = row, currentCell.ColumnNumber = colPos].LeagalNextMove = true;
                                colPos++;

                            }
                            if (colNeg >= 0)
                            {
                                theGrid[currentCell.RowNumber = row, currentCell.ColumnNumber = colNeg].LeagalNextMove = true;
                                colNeg--;
                            }
                            row--;
                        }

                        break;
                    }
            }

        }
    }
}
